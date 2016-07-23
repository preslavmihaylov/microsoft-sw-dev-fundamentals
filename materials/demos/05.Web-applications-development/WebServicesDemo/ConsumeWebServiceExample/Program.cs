using System;
using System.Collections.Specialized;

namespace ConsumeWebServiceExample
{
    class Program
    {
        static void Main()
        {
            using (var wb = new System.Net.WebClient())
            {
                var data = new NameValueCollection();
                data["input"] = "kEsHo";

                var response = wb.UploadValues("http://localhost:65236/Strings.asmx/ToLower", "POST", data);
                
                string result = System.Text.Encoding.UTF8.GetString(response);
                Console.WriteLine(result);
            }

        }
    }
}
