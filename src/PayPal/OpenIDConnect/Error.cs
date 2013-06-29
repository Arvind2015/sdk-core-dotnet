/* NuGet Install
 * Visual Studio 2005 or 2008
    * Install Newtonsoft.Json -OutputDirectory .\packages
    * Add reference from "net20" for Visual Studio 2005 or "net35" for Visual Studio 2008
 * Visual Studio 2010 or higher
    * Install-Package Newtonsoft.Json
    * Reference is auto-added 
*/
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace PayPal.OpenIdConnect
{
	public class Error
    {
        /// <summary>
        /// A single ASCII error code from the following enum.
        /// </summary>
        private string errorValue;

        /// <summary>
        /// A resource Id that indicates the starting resource in the returned results.
        /// </summary>
        private string error_descriptionValue;

        /// <summary>
        /// A URI identifying a human-readable web page with information about the error, used to provide the client developer with additional information about the error.
        /// </summary>
        private string error_uriValue;

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string error
        {
            get
            {
                return errorValue;
            }
            set
            {
                errorValue = value;
            }
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string error_description
        {
            get
            {
                return error_descriptionValue;
            }
            set
            {
                error_descriptionValue = value;
            }
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string error_uri
        {
            get
            {
                return error_uriValue;
            }
            set
            {
                error_uriValue = value;
            }
        }

        /// <summary>
        /// Explicit default constructor
        /// </summary>
        public Error() { }

        /// <summary>
		/// Constructor overload
		/// </summary>
		public Error(string error)
		{
			this.error = error;
		}		
	}
}


