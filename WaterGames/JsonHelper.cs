using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaterGames
{
    public class JsonHelper
    {
        public List<City> getCitiesFromJsonFile()
        {
            string fileName = @"..\..\Resources\javascript\cities.json";
            List<City> cities = new List<City>();
            if (File.Exists(fileName))
            {
                var result = JsonConvert.DeserializeObject<List<City>>(File.ReadAllText(fileName));
                for (int i = 0; i < result.Count; i++)
                {
                    City city = new City
                    {
                        Id = result[i].Id,
                        CityName = result[i].CityName,
                    };
                    cities.Add(city);
                }
            }
            return cities;
        }
        public List<District> getDistrictsFromJsonFile()
        {
            string fileName = @"..\..\Resources\javascript\districts.json";
            List<District> districts = new List<District>();
            if (File.Exists(fileName))
            {
                var result = JsonConvert.DeserializeObject<List<District>>(File.ReadAllText(fileName));
                for (int i = 0; i < result.Count; i++)
                {
                    District district = new District
                    {
                        CityId = result[i].CityId,
                        DistrictTitle = result[i].DistrictTitle
                    };
                    districts.Add(district);
                }
            }
            return districts;
        }

        public void addCityToComboBox(ComboBox comboBox, params ComboBox[] comboBoxes)
        {
            foreach (var city in getCitiesFromJsonFile())
            {
                comboBox.Items.Add(city.CityName);

                foreach (var _comboBox in comboBoxes)
                {
                    _comboBox.Items.Add(city.CityName);
                }
            }

        }
    }
}
