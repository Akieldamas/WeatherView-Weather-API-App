using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Net.Http;
using Newtonsoft.Json;

namespace WeatherView
{
    


    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        

        /*  public MainWindow()
          {
              InitializeComponent();
          _: GetWeather();
          }

          public async Task<string> GetWeather()
          {
              HttpClient client = new HttpClient();
              try
              {
                  HttpResponseMessage response = await client.GetAsync("https://api.openweathermap.org/data/2.5/weather?q=annecy,fr&appid=c21a75b667d6f7abb81f118dcf8d4611&units=metric");
                  if (response.IsSuccessStatusCode)
                  {
                      var content = await response.Content.ReadAsStringAsync();
                      Root root = JsonConvert.DeserializeObject<Root>(content);

                      Main main = root.main;
                      TB_Currently.Text = "Today:  " + main.temp.ToString() + "°C";
                      TB_High.Text = "High:  " + root.main.temp_max.ToString() + "°C";
                      TB_Low.Text = "Low:  " + main.temp_min.ToString() + "°C";
                      TB_Feels.Text = "Feels:  " + main.feels_like.ToString() + "°C";
                      TB_WeatherState.Text = root.weather[0].description.ToString();
                      TB_Humidity.Text = "Precipitation: " + main.humidity.ToString() + " %";
                      return "";
                  }
              }
              catch (Exception ex)
              {
                  return ex.Message;
              }
              return null;
          }

      */
    }
}
