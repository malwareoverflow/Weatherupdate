using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Mvc;
using WeatherApplication.Class;
using WeatherApplication.Models;

namespace WeatherApplication.Controllers
{
    public class OpenWeatherMapMvcController : Controller
    {

    
        public JsonResult GetWeather(string City)
        {
            string apiKey = "4adc4c875f2abf2f26c97b92478ed06b";
            HttpWebRequest apiRequest = WebRequest.Create("http://api.openweathermap.org/data/2.5/weather?q=" + City + "&APPID=" +apiKey) as HttpWebRequest;
          
            string apiResponse = "";
            using (HttpWebResponse response = apiRequest.GetResponse() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());
                apiResponse = reader.ReadToEnd();
            }
   

            return Json(apiResponse, JsonRequestBehavior.AllowGet);
        }
        // GET: OpenWeatherMapMvc
        public ActionResult Index()
        {

           
            return View();
        }
      
    }
}