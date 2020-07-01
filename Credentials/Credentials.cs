using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Linkedin.Credentials
{
    class Credentials
    {
        public string email = "";
        public string password = "";
        public string json = "";

        public Credentials()
        {
            using (StreamReader r = new StreamReader("C:\\Users\\rebel\\source\\repos\\Linkedin\\Credentials\\data.json"))
            {
                json = r.ReadToEnd();
            }

            dynamic array = JsonConvert.DeserializeObject(json);
            Console.WriteLine("Array::::" + array["email"]);
            email = array["email"];
            password = array["password"];
        }
    }
}
