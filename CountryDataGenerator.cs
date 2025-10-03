using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Sweeft
{
    // 888 davaleba esec ragaca ar gamovida
    public class CountryDataGenerator
    {
        public static async Task GenerateCountryDataFiles()
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string folder = Path.Combine(desktopPath, "country");

          
            Directory.CreateDirectory(folder);

           
            using (HttpClient client = new HttpClient())
            {
                string url = "https://restcountries.com/v3.1/all";
                string json = await client.GetStringAsync(url);

                
                using (JsonDocument doc = JsonDocument.Parse(json))
                {
                    var countries = doc.RootElement;

                   
                    foreach (var country in countries.EnumerateArray())
                    {
                      
                        string name = country.GetProperty("name")
                                            .GetProperty("common")
                                            .GetString();

                       
                        string region = GetSafeString(country, "region");
                        string subregion = GetSafeString(country, "subregion");
                        string latlng = GetLatLng(country);
                        string area = GetSafeString(country, "area");
                        string population = GetSafeString(country, "population");

                       
                        string fileName = Path.Combine(folder, $"{CleanFileName(name)}.txt");  
                        string content = $"Region: {region}\n" +
                                       $"Subregion: {subregion}\n" +
                                       $"LatLng: {latlng}\n" +
                                       $"Area: {area}\n" +
                                       $"Population: {population}";

                        File.WriteAllText(fileName, content);
                        Console.WriteLine($"✓ created: {name}.txt");
                    }
                }
            }

            Console.WriteLine($"all files created: {folder}");
        }

      
        private static string GetSafeString(JsonElement element, string propertyName)
        {
            if (element.TryGetProperty(propertyName, out JsonElement value))
            {
                return value.ToString();
            }
            return "N/A";
        }

        private static string GetLatLng(JsonElement country)
        {
            if (country.TryGetProperty("latlng", out JsonElement latlng))
            {
                var coords = latlng.EnumerateArray();
                var list = new List<string>();
                foreach (var coord in coords)
                {
                    list.Add(coord.ToString());
                }
                return string.Join(", ", list);
            }
            return "N/A";
        }

        private static string CleanFileName(string name)
        {
            foreach (char c in Path.GetInvalidFileNameChars())
            {
                name = name.Replace(c, '_');
            }
            return name;
        }
    }
}