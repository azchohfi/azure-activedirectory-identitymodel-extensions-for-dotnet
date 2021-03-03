﻿// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Documentation", "CA1200:Avoid using cref tags with a prefix", Justification = "Vendored component", Scope = "namespaceanddescendants", Target = "Microsoft.IdentityModel.Json")]
[assembly: SuppressMessage("Usage", "CA2213:Disposable fields should be disposed", Justification = "Vendored component", Scope = "namespaceanddescendants", Target = "Microsoft.IdentityModel.Json")]
[assembly: SuppressMessage("Reliability", "CA2000:Dispose objects before losing scope", Justification = "Vendored component", Scope = "namespaceanddescendants", Target = "Microsoft.IdentityModel.Json")]
[assembly: SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "Vendored component", Scope = "namespaceanddescendants", Target = "Microsoft.IdentityModel.Json")]
[assembly: SuppressMessage("Design", "CA1064:Exceptions should be public", Justification = "Vendored component", Scope = "namespaceanddescendants", Target = "Microsoft.IdentityModel.Json")]
[assembly: SuppressMessage("Performance", "CA1802:Use literals where appropriate", Justification = "Vendored component", Scope = "namespaceanddescendants", Target = "Microsoft.IdentityModel.Json")]
[assembly: SuppressMessage("Usage", "CA2208:Instantiate argument exceptions correctly", Justification = "Vendored component", Scope = "namespaceanddescendants", Target = "Microsoft.IdentityModel.Json")]
[assembly: SuppressMessage("Usage", "CA1801:Review unused parameters", Justification = "Vendored component", Scope = "namespaceanddescendants", Target = "Microsoft.IdentityModel.Json")]
[assembly: SuppressMessage("Globalization", "CA1308:Normalize strings to uppercase", Justification = "Vendored component", Scope = "namespaceanddescendants", Target = "Microsoft.IdentityModel.Json")]
[assembly: SuppressMessage("Usage", "CA2207:Initialize value type static fields inline", Justification = "Vendored component", Scope = "namespaceanddescendants", Target = "Microsoft.IdentityModel.Json")]
[assembly: SuppressMessage("Performance", "CA1810:Initialize reference type static fields inline", Justification = "Vendored component", Scope = "namespaceanddescendants", Target = "Microsoft.IdentityModel.Json")]
[assembly: SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations.", Justification = "vendored", Scope = "namespaceanddescendants", Target = "Microsoft.IdentityModel.Json")]
[assembly: SuppressMessage("Globalization", "CA1307:Specify StringComparison", Justification = "Vendored component", Scope = "namespaceanddescendants", Target = "Microsoft.IdentityModel.Json")]
[assembly: SuppressMessage("Performance", "CA1820:Test for empty strings using string length", Justification = "Vendored component", Scope = "namespaceanddescendants", Target = "Microsoft.IdentityModel.Json")]
[assembly: SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "Vendored component", Scope = "namespaceanddescendants", Target = "Microsoft.IdentityModel.Json")]

[assembly: SuppressMessage("Usage", "CA2227:Collection properties should be read only", Justification = "Breaking change", Scope = "member", Target = "~P:Microsoft.IdentityModel.Tokens.SecurityTokenDescriptor.AdditionalHeaderClaims")]
[assembly: SuppressMessage("Usage", "CA2227:Collection properties should be read only", Justification = "Breaking change", Scope = "member", Target = "~P:Microsoft.IdentityModel.Tokens.SecurityTokenDescriptor.Claims")]
[assembly: SuppressMessage("Usage", "CA2227:Collection properties should be read only", Justification = "Breaking change", Scope = "member", Target = "~P:Microsoft.IdentityModel.Tokens.JsonWebKey.Oth")]
[assembly: SuppressMessage("Usage", "CA2227:Collection properties should be read only", Justification = "Breaking change", Scope = "member", Target = "~P:Microsoft.IdentityModel.Tokens.CallContext.PropertyBag")]
[assembly: SuppressMessage("Usage", "CA2227:Collection properties should be read only", Justification = "Breaking chnage", Scope = "member", Target = "~P:Microsoft.IdentityModel.Tokens.TokenValidationParameters.PropertyBag")]
[assembly: SuppressMessage("Usage", "CA2214:Do not call overridable methods in constructors", Justification = "Current design", Scope = "member", Target = "~M:Microsoft.IdentityModel.Tokens.TokenValidationParameters.#ctor(Microsoft.IdentityModel.Tokens.TokenValidationParameters)")]
[assembly: SuppressMessage("Usage", "CA2213:Disposable fields should be disposed", Justification = "Disposed through ReleaseSignatureProvider", Scope = "member", Target = "~F:Microsoft.IdentityModel.Tokens.AuthenticatedEncryptionProvider._symmetricSignatureProvider")]
[assembly: SuppressMessage("Reliability", "CA2002:Do not lock on objects with weak identity", Justification = "Listener doesn't have a sync lock", Scope = "member", Target = "~M:Microsoft.IdentityModel.Json.Serialization.DiagnosticsTraceWriter.Trace(System.Diagnostics.TraceLevel,System.String,System.Exception)")]
[assembly: SuppressMessage("Reliability", "CA2000:Dispose objects before losing scope", Justification = "Ownership is transfered", Scope = "member", Target = "~M:Microsoft.IdentityModel.Tokens.AsymmetricAdapter.InitializeUsingRsaSecurityKey(Microsoft.IdentityModel.Tokens.RsaSecurityKey,System.String)")]
[assembly: SuppressMessage("Reliability", "CA2000:Dispose objects before losing scope", Justification = "Ownership is transfered", Scope = "member", Target = "~M:Microsoft.IdentityModel.Tokens.CryptoProviderFactory.CreateSignatureProvider(Microsoft.IdentityModel.Tokens.SecurityKey,System.String,System.Boolean,System.Boolean)~Microsoft.IdentityModel.Tokens.SignatureProvider")]
[assembly: SuppressMessage("Reliability", "CA2000:Dispose objects before losing scope", Justification = "Doesn't own object", Scope = "member", Target = "~M:Microsoft.IdentityModel.Tokens.InMemoryCryptoProviderCache.TryRemove(Microsoft.IdentityModel.Tokens.SignatureProvider)~System.Boolean")]
[assembly: SuppressMessage("Design", "CA1052:Static holder types should be Static or NotInheritable", Justification = "Breaking change", Scope = "type", Target = "~T:Microsoft.IdentityModel.Tokens.JsonWebKeyConverter")]
[assembly: SuppressMessage("Design", "CA1052:Static holder types should be Static or NotInheritable", Justification = "Breaking change", Scope = "type", Target = "~T:Microsoft.IdentityModel.Tokens.CompressionAlgorithms")]
[assembly: SuppressMessage("Performance", "CA1819:Properties should not return arrays", Justification = "Breaking change", Scope = "member", Target = "~P:Microsoft.IdentityModel.Tokens.AuthenticatedEncryptionResult.Ciphertext")]
[assembly: SuppressMessage("Performance", "CA1819:Properties should not return arrays", Justification = "Breaking change", Scope = "member", Target = "~P:Microsoft.IdentityModel.Tokens.AuthenticatedEncryptionResult.IV")]
[assembly: SuppressMessage("Performance", "CA1819:Properties should not return arrays", Justification = "Breaking change", Scope = "member", Target = "~P:Microsoft.IdentityModel.Tokens.AuthenticatedEncryptionResult.AuthenticationTag")]
[assembly: SuppressMessage("Performance", "CA1819:Properties should not return arrays", Justification = "Breaking change", Scope = "member", Target = "~P:Microsoft.IdentityModel.Tokens.SymmetricSecurityKey.Key")]
[assembly: SuppressMessage("Usage", "CA2211:Non-constant fields should not be visible", Justification = "Breaking change", Scope = "member", Target = "~F:Microsoft.IdentityModel.Tokens.JsonWebKeySet.DefaultSkipUnresolvedJsonWebKeys")]
[assembly: SuppressMessage("Usage", "CA1801:Review unused parameters", Justification = "Used in net461", Scope = "member", Target = "~M:Microsoft.IdentityModel.Tokens.SupportedAlgorithms.IsSupportedRsaPss(Microsoft.IdentityModel.Tokens.SecurityKey)~System.Boolean")]
[assembly: SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "Used as platform test", Scope = "member", Target = "~M:Microsoft.IdentityModel.Tokens.ECDsaAdapter.SupportsCNGKey~System.Boolean")]
[assembly: SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "Used for try pattern", Scope = "member", Target = "~M:Microsoft.IdentityModel.Tokens.JsonWebKeyConverter.ConvertFromRSASecurityKey(Microsoft.IdentityModel.Tokens.RsaSecurityKey)~Microsoft.IdentityModel.Tokens.JsonWebKey")]
[assembly: SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "Used for try pattern", Scope = "member", Target = "~M:Microsoft.IdentityModel.Tokens.JsonWebKeyConverter.TryConvertToECDsaSecurityKey(Microsoft.IdentityModel.Tokens.JsonWebKey,Microsoft.IdentityModel.Tokens.SecurityKey@)~System.Boolean")]
[assembly: SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "Used for try pattern", Scope = "member", Target = "~M:Microsoft.IdentityModel.Tokens.JsonWebKeyConverter.TryConvertToSecurityKey(Microsoft.IdentityModel.Tokens.JsonWebKey,Microsoft.IdentityModel.Tokens.SecurityKey@)~System.Boolean")]
[assembly: SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "Used as platform test", Scope = "member", Target = "~M:Microsoft.IdentityModel.Tokens.AsymmetricAdapter.IsRsaCngSupported~System.Boolean")]
[assembly: SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "Used for try pattern", Scope = "member", Target = "~M:Microsoft.IdentityModel.Tokens.JsonWebKeyConverter.TryConvertToSymmetricSecurityKey(Microsoft.IdentityModel.Tokens.JsonWebKey,Microsoft.IdentityModel.Tokens.SecurityKey@)~System.Boolean")]
[assembly: SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "Used for try pattern", Scope = "member", Target = "~M:Microsoft.IdentityModel.Tokens.JsonWebKeyConverter.TryConvertToX509SecurityKey(Microsoft.IdentityModel.Tokens.JsonWebKey,Microsoft.IdentityModel.Tokens.SecurityKey@)~System.Boolean")]
[assembly: SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "Used for try pattern", Scope = "member", Target = "~M:Microsoft.IdentityModel.Tokens.JsonWebKeyConverter.TryCreateToRsaSecurityKey(Microsoft.IdentityModel.Tokens.JsonWebKey,Microsoft.IdentityModel.Tokens.SecurityKey@)~System.Boolean")]
[assembly: SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "Used as platform test", Scope = "member", Target = "~P:Microsoft.IdentityModel.Tokens.RsaSecurityKey.PrivateKeyStatus")]
[assembly: SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "Used as platform test", Scope = "member", Target = "~M:Microsoft.IdentityModel.Tokens.JsonWebKeyConverter.ConvertFromECDsaSecurityKey(Microsoft.IdentityModel.Tokens.ECDsaSecurityKey)~Microsoft.IdentityModel.Tokens.JsonWebKey")]
[assembly: SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "Used as platform test", Scope = "member", Target = "~M:Microsoft.IdentityModel.Tokens.ECDsaAdapter.SupportsECParameters~System.Boolean")]
[assembly: SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "Appropriate exception will be caught.", Scope = "member", Target = "~M:Microsoft.IdentityModel.Tokens.InMemoryCryptoProviderCache.TryRemove(Microsoft.IdentityModel.Tokens.SignatureProvider)~System.Boolean")]
[assembly: SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "Appropriate exception will be caught.", Scope = "member", Target = "~M:Microsoft.IdentityModel.Tokens.EventBasedLRUCache`2.OnStart")]
[assembly: SuppressMessage("Globalization", "CA1305:Specify IFormatProvider", Justification = "Not using Globalization", Scope = "member", Target = "~M:Microsoft.IdentityModel.Tokens.Interop.Kernel32.GetMessage(System.Int32,System.IntPtr)~System.String")]
