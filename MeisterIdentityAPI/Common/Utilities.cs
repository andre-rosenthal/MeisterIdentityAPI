using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Converters;
using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Mvc;
using MeisterIdentityAPI.Models;

namespace MeisterIdentityAPI.Common
{
    public static class Utilities
    {
        public static void ValidateId<M,C>(ref M m,C c) where C: ControllerBase where M : IIdentityModel
        {
            if (string.IsNullOrEmpty(m.Id))
            {
                m.Id = Guid.NewGuid().ToString();
                c.ModelState.Clear();
                c.TryValidateModel(m);
            }
        }
        public static string GetEnumDescription<T>(T t) where T : Enum
        {
            return GetEnumDescription<T, Attribute>(t);
        }
        private static string GetEnumDescription<T,A>(T t) where A : Attribute where T : Enum
        {
            return t.GetAttribute<DisplayAttribute>().Name;
        }
        private static TAttribute GetAttribute<TAttribute>(this Enum enumValue) where TAttribute : Attribute
        {
            return enumValue.GetType().GetMember(enumValue.ToString()).First().GetCustomAttribute<TAttribute>();
        }
        public static string ExceptionHandler<T>(ILogger<T> _logger, dynamic response, Exception ex, string endpoint)
        {
            _logger.LogError(ex, endpoint);
            response.ErrorMessage = String.Format(CultureInfo.CurrentCulture, "{0}", ex.StackTrace);
            response.success = false;
            return Newtonsoft.Json.JsonConvert.SerializeObject(response, new IsoDateTimeConverter());
        }
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }
        public static string GetHash(string input)
        {
            // generate a 128 - bit salt using a secure PRNG
            byte[] salt = new byte[128 / 8];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }
            // derive a 256-bit subkey (use HMACSHA1 with 10,000 iterations)
            return Convert.ToBase64String(KeyDerivation.Pbkdf2(password: input,
                                                               salt: salt,
                                                               prf: KeyDerivationPrf.HMACSHA1,
                                                               iterationCount: 10000,
                                                               numBytesRequested: 256 / 8));
        }
    }
}
