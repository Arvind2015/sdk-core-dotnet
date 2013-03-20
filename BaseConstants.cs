using System.Text;

namespace PayPal
{
    public static class BaseConstants
    {
        // Request Method in HTTP Connection
        public const string REQUESTMETHOD = "POST";

        // Log file
        public const string PAYPALLOGFILE = "PAYPALLOGFILE";

        // Encoding Format
        public static readonly Encoding ENCODING_FORMAT = Encoding.UTF8;
        
        // Account Prefix
        public const string ACCCOUT_PREFIX = "acct";

        // Sandbox Default Email Address
        public const string PayPalSandboxEmailAddressDefault = "Platform.sdk.seller@gmail.com";
        
        // SOAP Format
        public const string SOAP = "SOAP";
        
        // NVP Format
        public const string NVP = "NV";
        
        // HTTP Header Constants
        // PayPal Security UserId Header
        public const string PAYPAL_SECURITY_USERID_HEADER = "X-PAYPAL-SECURITY-USERID";

        // PayPal Security Password Header
        public const string PAYPAL_SECURITY_PASSWORD_HEADER = "X-PAYPAL-SECURITY-PASSWORD";

        // PayPal Security Signature Header
        public const string PAYPAL_SECURITY_SIGNATURE_HEADER = "X-PAYPAL-SECURITY-SIGNATURE";

        // PayPal Platform Authorization Header
        public const string PAYPAL_AUTHORIZATION_PLATFORM_HEADER = "X-PAYPAL-AUTHORIZATION";

        // PayPal Merchant Authorization Header
        public const string PAYPAL_AUTHORIZATION_MERCHANT_HEADER = "X-PP-AUTHORIZATION";

        // PayPal Application ID Header
        public const string PAYPAL_APPLICATION_ID_HEADER = "X-PAYPAL-APPLICATION-ID";

        // PayPal Request Data Header
        public const string PAYPAL_REQUEST_DATA_FORMAT_HEADER = "X-PAYPAL-REQUEST-DATA-FORMAT";

        // PayPal Request Data Header
        public const string PAYPAL_RESPONSE_DATA_FORMAT_HEADER = "X-PAYPAL-RESPONSE-DATA-FORMAT";

        // PayPal Request Source Header
        public const string PAYPAL_REQUEST_SOURCE_HEADER = "X-PAYPAL-REQUEST-SOURCE";
        
        // PayPal Sandbox Email Address Header
        public const string PAYPAL_SANDBOX_DEVICE_IPADDRESS = "X-PAYPAL-DEVICE-IPADDRESS";

        // PayPal Sandbox Email Address Header
        public const string PAYPAL_SANDBOX_EMAIL_ADDRESS_HEADER = "X-PAYPAL-SANDBOX-EMAIL-ADDRESS";

        // Allowed application modes
        public const string LIVE_MODE = "live";
        public const string SANDBOX_MODE = "sandbox";

        // Endpoints for various APIs
        public const string PLATFORM_LIVE_ENDPOINT = "https://svcs.paypal.com/";
        public const string PLATFORM_SANDBOX_ENDPOINT = "https://svcs.sandbox.paypal.com/";
        public const string MERCHANT_SIGNATURE_LIVE_ENDPOINT = "https://api-3t.paypal.com/2.0/";
        public const string MERCHANT_SIGNATURE_SANDBOX_ENDPOINT = "https://api-3t.sandbox.paypal.com/2.0/";
        public const string MERCHANT_CERTIFICATE_LIVE_ENDPOINT = "https://api.paypal.com/2.0/";
        public const string MERCHANT_CERTIFICATE_SANDBOX_ENDPOINT = "https://api.sandbox.paypal.com/2.0/";

        // Configuration key for application mode.
        public const string APPLICATION_MODE = "mode";

        // Configuration key for End point
        public const string END_POINT = "endpoint";

        // Configuration key for IPN endpoint 
        public const string IPN_ENDPOINT = "IPNEndpoint";

        // Configuration key for IPAddress
        public const string CLIENT_IP_ADDRESS = "IPAddress";
       
        // Configuration key for Email Address
        public const string PAYPAL_SANDBOX_EMAIL_ADDRESS = "sandboxEmailAddress";

        // Configuration key for HTTP Proxy Address
        public const string HTTP_PROXY_ADDRESS = "proxyAddress";

        // Configuration key for HTTP Proxy Credential
        public const string HTTP_PROXY_CREDENTIAL = "proxyCredentials";

        // Configuration key for HTTP Connection Timeout
        public const string HTTP_CONNECTION_TIMEOUT = "connectionTimeout";

        // Configuration key for HTTP Connection Retry
        public const string HTTP_CONNECTION_RETRY = "requestRetries";

        // Configuration key suffix for Credential Username
        public const string CREDENTIAL_USERNAME = "apiUsername";

        // Configuration key suffix for Credential Password
        public const string CREDENTIAL_PASSWORD = "apiPassword";

        // Configuration key suffix for Credential Application ID
        public const string CREDENTIAL_APPLICACTIONID = "applicationId";

        // Configuration key suffix for Credential Subject
        public const string CREDENTIAL_SUBJECT = "Subject";

        // Configuration key suffix for Credential Signature
        public const string CREDENTIAL_SIGNATURE = "apiSignature";

        // Configuration key suffix for Credential Certificate Path
        public const string CREDENTIAL_CERTPATH_SUFFIX = "apiCertificate";

        // Configuration key suffix for Credential Certificate Key
        public const string CREDENTIAL_CERTKEY_SUFFIX = "privateKeyPassword";


        public static class ErrorMessages
        {
            public const string PROFILE_NULL = "APIProfile cannot be null.";
            public const string PAYLOAD_NULL = "PayLoad cannot be null or empty.";
            public const string err_endpoint = "Endpoint cannot be empty.";
            public const string err_username = "API username cannot be empty";
            public const string err_passeword = "API password cannot be empty.";
            public const string err_signature = "API signature cannot be empty.";
            public const string err_appid = "Application Id cannot be empty.";
            public const string err_certificate = "Certificate cannot be empty.";
            public const string err_privatekeypassword = "Private Key password cannot be null or empty.";
        }
    }
}
