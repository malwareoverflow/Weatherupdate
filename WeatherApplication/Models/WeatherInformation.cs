using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeatherApplication.Models
{
    public class WeatherInformation
    {
        public string Description { get; set; }
        public float Tempreture { get; set; }
        public float Pressure { get; set; }
        public float Humidity { get; set; }
        public float TempretureMax { get; set; }
        public float TempretureMin { get; set; }
        public float WindSpeed { get; set; }
    }
}