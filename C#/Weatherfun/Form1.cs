using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Weatherfun
{
    public partial class Form1 : Form
    {

        private static readonly HttpClient client = new HttpClient();

        public Form1()
        {
            InitializeComponent();
        }


        string city;
        private void GetCity()
        {
            string city = cityTextbox.Text;
        }
        

        private void GetJason(){
            string APIkey = "4835cc6a727ba8d950f6866e7a7d287d";
            string APIreq = $"api.openweathermap.org/data/2.5/weather?q={city}&APPID={APIkey}";            string test = "www.google.com";
             

            var responseString =  client.GetStringAsync(APIreq);
        }

        private void getReqButton_Click(object sender, EventArgs e)
        {
            GetJason();
        }
    }



    public class DataObject
    {
        public string Name { get; set; }
    }

    public class Class1
    {
        private const string URL = "https://sub.domain.com/objects.json";
        private string urlParameters = "?api_key=123";

        private string APIkey = "4835cc6a727ba8d950f6866e7a7d287d";
        string APIreq = $"api.openweathermap.org/data/2.5/weather?q=London&APPID={APIkey}";

        static void Main(string[] args)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL);

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

            // List data response.
            HttpResponseMessage response = client.GetAsync(APIkey).Result;  // Blocking call! Program will wait here until a response is received or a timeout occurs.
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body.
                var dataObjects = response.Content.ReadAsAsync<IEnumerable<DataObject>>().Result;  //Make sure to add a reference to System.Net.Http.Formatting.dll
                foreach (var d in dataObjects)
                {
                    Console.WriteLine("{0}", d.Name);
                }
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }

            //Make any other calls using HttpClient here.

            //Dispose once all HttpClient calls are complete. This is not necessary if the containing object will be disposed of; for example in this case the HttpClient instance will be disposed automatically when the application terminates so the following call is superfluous.
            client.Dispose();
        }
    }



}






