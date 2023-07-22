using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using RestSharp;
using eZmaxApi.Client;

namespace eZmaxApi.Api
{
    public class RequestSignature
    {
		
		public static string GetFingerprintV1 (string sAuthorization, 
                                               string dtDate, 
                                               string sMethod, 
                                               string sURL, 
                                               string sBody,
                                                 int? iExpiration) {
		
			var sContentToHash = sMethod        + "\n" + 
                                 sURL           + "\n" +
                                 sBody          + "\n" +
                                 sAuthorization + "\n" +
                                 dtDate;

            if (iExpiration != null) {

                sContentToHash += "\n" + iExpiration.ToString();
            }
                                
			var sha256             = SHA256Managed.Create();
			var bytesContentToHash = Encoding.UTF8.GetBytes(sContentToHash);
			var bytesSha256        = sha256.ComputeHash(bytesContentToHash);
			var fingerprintV1      = ToHexLowercaseWithBytes(bytesSha256);

			return "v1=" + fingerprintV1;
		}


		////////////////////////////////////////////////////////////////////////////////
		public static string GetSignatureV1 (string sAuthorization, 
                                             string dtDate, 
                                             string sFingerprint,
                                             string sSecret) {
		
			var sContentToSign = sFingerprint   + 
                                 sAuthorization + 
                                 dtDate;

			var bytesSecret        = Encoding.Default.GetBytes(sSecret);
			var bytesContentToSign = Encoding.Default.GetBytes(sContentToSign);
			var hmacSha256         = new HMACSHA256(bytesSecret);
            var bytesHmacSha256    = hmacSha256.ComputeHash(bytesContentToSign);
			var signatureV1        = ToHexLowercaseWithBytes(bytesHmacSha256);

			return "v1=" + signatureV1;
		}


		////////////////////////////////////////////////////////////////////////////////
		public static Dictionary<string, string> GetHeadersV1 (string sAuthorization,
                                                               string sSecret,
                                                               string sMethod,
                                                               string sURL, 
                                                               string sBody,
                                                                 int? iExpiration) {
	    
			var dtDate = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ");

	
			var sFingerprint = RequestSignature.GetFingerprintV1(sAuthorization, 
                                                                 dtDate, 
                                                                 sMethod, 
                                                                 sURL, 
                                                                 sBody,
                                                                 iExpiration);
	
			var sSignature = RequestSignature.GetSignatureV1(sAuthorization,
                                                             dtDate, 
                                                             sFingerprint, 
                                                             sSecret);
		
			var headersV1 = new Dictionary<string, string>();
			headersV1.Add("Ezmax-Date",        dtDate);
            headersV1.Add("Ezmax-Fingerprint", sFingerprint);
            headersV1.Add("Ezmax-Signature",   sSignature);

            if (iExpiration != null) {
                
                headersV1.Add("Ezmax-Expiration",  iExpiration.ToString());
            }

			return headersV1;
		}


		////////////////////////////////////////////////////////////////////////////////
		public static void InjectSecurityHeaders(ref Dictionary<String, String> headerParams,
                                                                         Method method,
                                                                         Object postBody,   
                                                                         string path,
                                                     Dictionary<String, String> pathParams,
                                             List<KeyValuePair<String, String>> queryParams) {


            //Get Autorization
            //////////////////
			var sAuthorization = Configuration.Default.GetApiKeyWithPrefix("Authorization");
                
            //Get Secret
            ////////////
			var sSecret = Configuration.Default.GetApiKeyWithPrefix("secret");
			
			//If no secret is defined, we skiped all the processing to generate the fingerprint and signature
			if (sSecret != null) {
				
	            //Get Method
	            ////////////
				var sMethod = method.ToString(); 

	            //We need to recreate the full URL
	            //////////////////////////////////
	            var sURL = Configuration.Default.ApiClient.RestClient.BaseUrl.ToString();
	            sURL += path;


	            //Put the pathParams back in URL
	            foreach(var param in pathParams) {

	                sURL = sURL.Replace("{" + param.Key + "}", 
	                                    ApiClient.UrlEncode(param.Value) );
	            }
	                

	            //Put the queries back in URL
	            if (queryParams != null) {

	                
	                if (queryParams.Count > 0) {

	                    sURL += "?";
	                }

	                var iRemain = queryParams.Count;
	                foreach(KeyValuePair<string, string> entry in queryParams)
	                {
	                     
	                    sURL += ApiClient.UrlEncode(entry.Key) + 
	                            "=" + 
	                            ApiClient.UrlEncode(entry.Value);
	                          

	                    iRemain -= 1;
	                    if (iRemain > 0) {

	                        sURL += "&";
	                    }
	                }
	            }


	            //Exctact the body
	            //////////////////
	            var sBody = "";
	            if (postBody != null) {

	                sBody = postBody.ToString();
	            }   


	            //Get the 3 signature headers
	            /////////////////////////////
	            var headersV1 = RequestSignature.GetHeadersV1(sAuthorization: sAuthorization, 
	                                                                 sSecret: sSecret, 
	                                                                 sMethod: sMethod, 
	                                                                    sURL: sURL, 
	                                                                   sBody: sBody,
                                                                 iExpiration: null);

	            //Inject the new headers in the headers
	            ///////////////////////////////////////
	            headerParams = headerParams.Concat(headersV1).ToDictionary(x=>x.Key,
	                                                                       x=>x.Value);
			}
		}

		////////////////////////////////////////////////////////////////////////////////
		private static string ToHexLowercaseWithBytes(byte[] bytes) {

			var sbHex = new StringBuilder(bytes.Length * 2);
			for (int i = 0; i < bytes.Length; i++) {

				sbHex.Append(bytes[i].ToString("x2"));
			}

			return sbHex.ToString();
		}
    }
}
