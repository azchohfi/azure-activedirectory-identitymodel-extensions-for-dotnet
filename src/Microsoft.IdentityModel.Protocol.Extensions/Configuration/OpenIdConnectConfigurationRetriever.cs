﻿//-----------------------------------------------------------------------
// Copyright (c) Microsoft Open Technologies, Inc.
// All Rights Reserved
// Apache License 2.0
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IdentityModel.Tokens;
using System.Net.Http;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.IdentityModel.Protocols
{
    /// <summary>
    /// OpenIdConnectConfigurationRetriever - TODO
    /// </summary>
    public class OpenIdConnectConfigurationRetriever : IConfigurationRetriever<OpenIdConnectConfiguration>
    {
        private static string rsaImportTemplate = @"<RSAKeyValue><Modulus>{0}</Modulus><Exponent>{1}</Exponent></RSAKeyValue>";

        /// <summary>
        /// GetAsync
        /// </summary>
        /// <param name="address">TODO</param>
        /// <param name="cancel">TODO</param>
        /// <returns></returns>
        public static Task<OpenIdConnectConfiguration> GetAsync(string address, CancellationToken cancel)
        {
            return GetAsync(new GenericDocumentRetriever(), address, cancel);
        }

        /// <summary>
        /// GetAsync
        /// </summary>
        /// <param name="address">TODO</param>
        /// <param name="httpClient">TODO</param>
        /// <param name="cancel">TODO</param>
        /// <returns></returns>
        public static Task<OpenIdConnectConfiguration> GetAsync(string address, HttpClient httpClient, CancellationToken cancel)
        {
            return GetAsync(new HttpDocumentRetriever(httpClient), address, cancel);
        }

        Task<OpenIdConnectConfiguration> IConfigurationRetriever<OpenIdConnectConfiguration>.GetConfigurationAsync(IDocumentRetriever retriever, string address, CancellationToken cancel)
        {
            return GetAsync(retriever, address, cancel);
        }


        /// <summary>
        /// GetAsync
        /// </summary>
        /// <param name="retriever">TODO</param>
        /// <param name="address">TODO</param>
        /// <param name="cancel">TODO</param>
        /// <returns></returns>
        public static async Task<OpenIdConnectConfiguration> GetAsync(IDocumentRetriever retriever, string address, CancellationToken cancel)
        {
            if (retriever == null)
            {
                throw new ArgumentNullException("retriever");
            }
            if (string.IsNullOrWhiteSpace(address))
            {
                throw new ArgumentNullException("address");
            }

            OpenIdConnectConfiguration openIdConnectConfiguration = null;
            string doc = await retriever.GetDocumentAsync(address, cancel);

            openIdConnectConfiguration = new OpenIdConnectConfiguration(doc);
            if (!string.IsNullOrEmpty(openIdConnectConfiguration.JwksUri))
            {
                doc = await retriever.GetDocumentAsync(openIdConnectConfiguration.JwksUri, cancel);
                JsonWebKeySet jsonWebKeys = new JsonWebKeySet(doc);

                foreach (JsonWebKey webKey in jsonWebKeys.Keys)
                {
                    if ((string.IsNullOrWhiteSpace(webKey.Use) || (StringComparer.Ordinal.Equals(webKey.Use, JsonWebKeyUseNames.Sig))))
                    {
                        // Add chaining
                        if (webKey.X5c.Count == 1)
                        {
                            X509Certificate2 cert = new X509Certificate2(Convert.FromBase64String(webKey.X5c[0]));
                            openIdConnectConfiguration.SigningTokens.Add(new X509SecurityToken(cert));
                        }

                        // create NamedSecurityToken for Kid's, only RSA keys are supported.
                        if (!string.IsNullOrWhiteSpace(webKey.Kid))
                        {
                            List<SecurityKey> keys = new List<SecurityKey>();

                            if (!string.IsNullOrWhiteSpace(webKey.N) && !string.IsNullOrWhiteSpace(webKey.E))
                            {
                                RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
                                rsa.FromXmlString(string.Format(CultureInfo.InvariantCulture, rsaImportTemplate, webKey.N, webKey.E));
                                
                                keys.Add(new RsaSecurityKey(rsa));
                                openIdConnectConfiguration.SigningTokens.Add(new NamedKeySecurityToken(webKey.Kid, keys.AsReadOnly()));
                            }
                        }
                    }

                    openIdConnectConfiguration.JsonWebKeySet.Keys.Add(webKey);
                }
            }

            return openIdConnectConfiguration;
        }
    }
}
