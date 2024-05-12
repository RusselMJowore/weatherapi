namespace productsapi.Models
{
    public class WeatherAPI
    {
        public class main 
        {
                public double temp { get; set; } 
                public double feels_like { get; set; } 
                public double temp_min { get; set; } 
                public double temp_max { get; set; } 
                public int pressure { get; set; } 
                public int sea_level { get; set; } 
                public int grnd_level { get; set; } 
                public int humidity { get; set; } 
                public double temp_kf { get; set; }
        }
        public class weather
        {
            public double id { get; set; }
            public double main { get; set; }
            public double description { get; set; }
            public double icon { get; set; }

        }
        public class wind
        {
            public double speed { get; set; }
            public double deg { get; set; }
            public double gust { get; set; }
        }

        public class clouds
        {
            public double all { get; set; }
         
        }
        public class sys
        {
            public string pod { get; set; }

        }
        public class WeatherResponse 
        {
            public main main { get; set; }
            public List<weather> weather { get; set;}
            public wind wind { get; set; }
            public clouds clouds { get; set;}
            public sys sys { get; set; }
       
        }
    }
}
