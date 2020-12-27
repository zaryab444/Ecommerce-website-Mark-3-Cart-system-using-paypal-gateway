using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PayPal.Api;

namespace Ecommerce_Website
{
    public class PaypalConfiguration
    {
        public readonly static string clientId;
        public readonly static string clientSecret;


        static PaypalConfiguration()
        {
            var config = getconfig();
            clientId = "AWNixhwKC5x0Rpba4u5tEXRujbcX8hkwus1tYqrH_TjAMI8kezydugLf-XRJmhw7WT4Mhgn540dB6lsv";
            clientSecret = "EF58E3yHkH8ic7-RPdpuexdQipAFQSSP6mqTQqIGDzd93P84-xJdnaUUyjU4GObK-5-j74pQS8mWG8qa";
        }

        private static Dictionary<string, string> getconfig()
        {
            return PayPal.Api.ConfigManager.Instance.GetProperties();
        }

        private static string GetAccessToken()
        {
            string accessToken = new OAuthTokenCredential(clientId, clientSecret, getconfig()).GetAccessToken();
            return accessToken;
        }
        public static APIContext GetAPIContext()
        {
            APIContext apicontext = new APIContext(GetAccessToken());
            apicontext.Config = getconfig();
            return apicontext;
        }
    }
}