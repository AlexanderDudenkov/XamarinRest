using System;
using System.Collections.Generic;
using System.Text;

namespace ServerApp.util
{
    class Constants
    {
        private static Constants instance;
        private Constants() { }

        public static Constants getInstance()
        {
            if (instance == null)
                instance = new Constants();
            return instance;
        }

        public string url = "https://api.unsplash.com/photos?client_id=ab5ded39073363283b5528fa4f194f320ae8561078b98e5c658780bc4f7a7459";
    }
}
