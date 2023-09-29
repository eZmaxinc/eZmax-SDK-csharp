using eZmaxApi.Client;
using RestSharp;
using System;
using System.Text;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Web;

#pragma warning disable CS1591    //Missing XML comment

namespace eZmaxApi.Api
{
    public class RequestSignature
    {	
		////////////////////////////////////////////////////////////////////////////////
		public static void injectSecurityHeaders(IReadableConfiguration configuration,
                                                            RestRequest request,
                                                                 String jsonBody) 
        {
            //Get required "Autorization" & possible "secret"
            //If no secret is defined, we skiped all the processing 
            //to generate the fingerprint and signature
            ////////////////////////////////////////////////////////
            var sSecret = configuration.GetApiKeyWithPrefix("secret");          		
			if (sSecret == null) { return; }
            var sAuthorization = configuration.GetApiKeyWithPrefix("Authorization");			


	        //Get Method
	        ////////////
            var sMethod = request.Method.ToString().ToUpper();


	        //We need to recreate the full URL
	        //////////////////////////////////
            var sURL =  eZmaxApi.Client.GlobalConfiguration.Instance.BasePath;
            sURL += request.Resource.ToString();


	        //Put the pathParams back in URL
            ////////////////////////////////
            foreach (var param in request.Parameters) {

                if (param.Type == ParameterType.UrlSegment) {
                        
                        sURL = sURL.Replace("{" + param.Name + "}",
                                    urlEncode(param.Value.ToString() ) );
                }
            }
	             

            //Put the queries back in URL
            /////////////////////////////
            var queryParams = new List<KeyValuePair<String, String>>();
            foreach (var param in request.Parameters) {

                if (param.Type == ParameterType.QueryString) {
                        
                    queryParams.Add(new KeyValuePair<string, string>(param.Name, param.Value.ToString()));       
                }
            }

	        if (queryParams.Count > 0) {

	            sURL += "?";
	        }

	        var iRemain = queryParams.Count;
	        foreach(KeyValuePair<string, string> entry in queryParams)
	        {
	            sURL += urlEncode(entry.Key) +
	                    "=" + 
                        urlEncode(entry.Value);
	                          
	            iRemain -= 1;
	            if (iRemain > 0) {

	                sURL += "&";
	            }
	        }
	            

	        //Get the 3 signature headers
	        /////////////////////////////
	        var headersV1 = RequestSignature.getHeadersV1(sAuthorization: sAuthorization, 
	                                                             sSecret: sSecret, 
	                                                             sMethod: sMethod, 
	                                                                sURL: sURL, 
	                                                               sBody: jsonBody,
                                                             iExpiration: null);

	        //Inject the new headers in the request
	        ///////////////////////////////////////
            foreach(var header in headersV1) {

                request.AddHeader(header.Key, header.Value);
            }			
		}

		private static string getFingerprintV1 (string sAuthorization, 
                                               string dtDate, 
                                               string sMethod, 
                                               string sURL, 
                                               string sBody,
                                                 int? iExpiration) 
        {
			var sContentToHash = sMethod        + "\n" + 
                                 sURL           + "\n" +
                                 sBody          + "\n" +
                                 sAuthorization + "\n" +
                                 dtDate;

            if (iExpiration != null) {

                sContentToHash += "\n" + iExpiration.ToString();
            }
                                
            var fingerprintV1 = stringToSha256HashHex(sContentToHash);

			return "v1=" + fingerprintV1;
		}

        ////////////////////////////////////////////////////////////////////////////////
        private static string stringToSha256HashHex(string s) 
        {    
            using (SHA256 sha256Hash = SHA256.Create())
            {
                var bytesContentToHash = Encoding.UTF8.GetBytes(s);
                byte[] bytes = sha256Hash.ComputeHash(bytesContentToHash);
                var hex = bytesToLowercaseHex(bytes);
                return hex;
            }
        }

		////////////////////////////////////////////////////////////////////////////////
		private static string getSignatureV1 (string sAuthorization, 
                                             string dtDate, 
                                             string sFingerprint,
                                             string sSecret) 
        {
			var sContentToSign = sFingerprint   + 
                                 sAuthorization + 
                                 dtDate;

			var bytesSecret        = Encoding.Default.GetBytes(sSecret);
			var bytesContentToSign = Encoding.Default.GetBytes(sContentToSign);
			var hmacSha256         = new HMACSHA256(bytesSecret);
            var bytesHmacSha256    = hmacSha256.ComputeHash(bytesContentToSign);
			var signatureV1        = bytesToLowercaseHex(bytesHmacSha256);

			return "v1=" + signatureV1;
		}


		////////////////////////////////////////////////////////////////////////////////
		private static Dictionary<string, string> getHeadersV1 (string sAuthorization,
                                                               string sSecret,
                                                               string sMethod,
                                                               string sURL, 
                                                               string sBody,
                                                                 int? iExpiration) 
        {
			var dtDate = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ");

			var sFingerprint = RequestSignature.getFingerprintV1(sAuthorization, 
                                                                 dtDate, 
                                                                 sMethod, 
                                                                 sURL, 
                                                                 sBody,
                                                                 iExpiration);
	
			var sSignature = RequestSignature.getSignatureV1(sAuthorization,
                                                             dtDate, 
                                                             sFingerprint, 
                                                             sSecret);
		
			var headersV1 = new Dictionary<string, string>();
			headersV1.Add("Ezmax-Date",        dtDate);
            headersV1.Add("Ezmax-Fingerprint", sFingerprint);
            headersV1.Add("Ezmax-Signature",   sSignature);

            if (iExpiration != null) {
                
                headersV1.Add("Ezmax-Expiration", iExpiration.ToString());
            }

			return headersV1;
		}

		////////////////////////////////////////////////////////////////////////////////
		private static string bytesToLowercaseHex(byte[] bytes) 
        {
			var sbHex = new StringBuilder(bytes.Length * 2);
			for (int i = 0; i < bytes.Length; i++) {

				sbHex.Append(bytes[i].ToString("x2"));
			}

			return sbHex.ToString();
		}

        ////////////////////////////////////////////////////////////////////////////////
        private static string urlEncode(string text)
        {
            // "sDescription like '%foo=%'"
            //   Should encode to
            // "sDescription%20like%20%25foo%3d%25"

            var urlEncoded = HttpUtility.UrlEncode(text);
            urlEncoded = urlEncoded.Replace("+", "%20");
            return urlEncoded;
        }
    }
}

#pragma warning restore CS1591     //Missing XML comment