using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinTestAPI.API
{
    class ApiKey
    {
        private readonly string cKey = "yessdsadsadsdss"; //get the API key from WordPress
        private readonly string cSec = "yes"; //get the API key from WordPress

        public string CKey
        {
            get
            {
                return cKey;
            }
        }
        public string CSec
        {
            get
            {
                return cSec;
            }
        }
    }
}
