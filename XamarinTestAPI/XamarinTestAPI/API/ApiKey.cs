using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinTestAPI.API
{
    class ApiKey
    {
        private readonly string cKey = "ck_5ea2e897c4d94fe81218cd4fd8682f21cfae1920"; //get the API key from WordPress
        private readonly string cSec = "cs_78548c346f08940263a5b4fda60337a0c9c5f22d"; //get the API key from WordPress

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
