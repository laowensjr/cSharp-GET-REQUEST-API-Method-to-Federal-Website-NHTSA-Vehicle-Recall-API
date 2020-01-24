using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;


namespace VehicleAPITest2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Task t1 = Task.Run(() =>
              {
                 GetRequest("https://vpic.nhtsa.dot.gov/api/vehicles/GetModelsForMakeId/480?format=json");

              });
              t1.Wait();
              Console.WriteLine("Main Thread Completed");
              Console.ReadLine();*/

            /* Task t1 = new Task(GetRequest);
            t1.Start();
            Console.WriteLine("Main Thread Completed");
            Console.ReadLine();*/

            GetRequest("https://vpic.nhtsa.dot.gov/api/vehicles/GetModelsForMakeId/440?format=json");
            Console.ReadKey();
        }

        async static void GetRequest(string url)
        {
            //string url = "https://vpic.nhtsa.dot.gov/api/vehicles/GetModelsForMakeId/480?format=csv";

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                using (HttpResponseMessage response = await client.GetAsync(url))
                {
                    using (HttpContent content = response.Content)
                    {
                        string mycontent = await content.ReadAsStringAsync();
                        var vehrec = JObject.Parse(mycontent);

                        // HttpContentHeaders headers = content.Headers;

                        //Console.WriteLine(headers);
                        //Console.WriteLine( mycontent);
                        //double Make_ID = vehrec["Make_ID"].Value<double>();
                        //Result data = JsonConvert.DeserializeObject<Result>("{\"Make_ID\":500}");
                       //Console.WriteLine(data.Make_ID);

                        Console.WriteLine(vehrec);
                        
                        /* Console.WriteLine(vehrec.Make_ID);
                         Console.WriteLine(vehrec.Make_Name);
                         Console.WriteLine(vehrec.Model_ID);
                         Console.WriteLine(vehrec.Model_Name);
                       */
                    }

                }

            }



        }






    }


 






}
