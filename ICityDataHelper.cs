using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherClientTool.APIHelper;

namespace WeatherClientTool
{
    public interface ICityDataHelper
    {
        public Task<List<CityData>> GetCityData();
        public  Task<string> HttpCall(string url);
    }
}
