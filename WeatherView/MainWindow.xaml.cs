using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.IO;
using System.Reflection;
using System.Windows.Threading;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Input;
using WeatherView.Service;

namespace WeatherView
{
    public partial class MainWindow : Window
    {
        string previousCity;

        int seconds = 0;
        DispatcherTimer timer;

        CityBoxManager cityboxmanager;

        //CHANGER filepath pathcombine par Uri
        string filePath = "Files/FavoriteCities.txt";
        string NameFilePath = "Files/Name.txt";
        APIManager apimanager;

        public MainWindow()
          {
            InitializeComponent();

            apimanager = new APIManager();
            cityboxmanager = new CityBoxManager();
            Initializer();
            Initialize_Timer();
        }
        
        
        private async void UpdateUI() // function to change UI using data from API
        {
            try
            {
                Root root = await apimanager.DataGrabber(TB_City.Text);

                CurrentCondition currentcondition = root.current_condition;
                FcstDay0 TodayForecast = root.fcst_day_0;
                FcstDay1 ForecastDay1 = root.fcst_day_1;
                FcstDay2 ForecastDay2 = root.fcst_day_2;
                FcstDay3 ForecastDay3 = root.fcst_day_3;

                Uri resourceUri = new Uri(currentcondition.icon_big, UriKind.Absolute);

                TB_City.Text = root.city_info.name.ToString();
                TB_Date.Text = currentcondition.date.ToString();
                TB_Day.Text = TodayForecast.day_long.ToString();

                TB_Temperature.Text = currentcondition.tmp.ToString();

                WeatherImage.Source = new BitmapImage(resourceUri);
                TB_MaxTemperature.Text = TodayForecast.tmax.ToString() + "°C";
                TB_MinTemperature.Text = TodayForecast.tmin.ToString() + "°C";
                TB_WeatherState.Text = currentcondition.condition.ToString();
                TB_Humidity.Text = currentcondition.humidity.ToString() + "%";
                TB_WindSpeed.Text = currentcondition.wnd_spd.ToString() + " km/h";
                TB_Sunrise.Text = root.city_info.sunrise.ToString();
                TB_Sunset.Text = root.city_info.sunset.ToString();


                TB_Day1MinMax.Text = ForecastDay1.day_short + " " + ForecastDay1.tmin.ToString() + " / " + ForecastDay1.tmax.ToString();
                TB_Day2MinMax.Text = ForecastDay2.day_short + " " + ForecastDay2.tmin.ToString() + " / " + ForecastDay2.tmax.ToString();
                TB_Day3MinMax.Text = ForecastDay3.day_short + " " + ForecastDay3.tmin.ToString() + " / " + ForecastDay3.tmax.ToString();
                Uri ForecastDay1Icon = new Uri(ForecastDay1.icon_big, UriKind.Absolute);
                Uri ForecastDay2Icon = new Uri(ForecastDay2.icon_big, UriKind.Absolute);
                Uri ForecastDay3Icon = new Uri(ForecastDay3.icon_big, UriKind.Absolute);
                WeatherDay1.Source = new BitmapImage(ForecastDay1Icon);
                WeatherDay2.Source = new BitmapImage(ForecastDay2Icon);
                WeatherDay3.Source = new BitmapImage(ForecastDay3Icon);
            }
            catch (Exception ex)
            {
           //  Handle exceptions, log, or display an error message
               string city = previousCity;
               apimanager.DataGrabber(city);
            }
        }

        private void Initializer() 
        {
            string[] lines = File.ReadAllLines(filePath);
            ComboBox_Cities.ItemsSource = lines; // nitialize combobox with favorite cities
            ComboBox_Cities.SelectedIndex = 0;
            if (ComboBox_Cities.SelectedItem == null)
            {
                cityboxmanager.AddCity_Favorite("Paris");
            }

        }
        public void Initialize_Timer() // timer function to reset data every minute
        {
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        public void Timer_Tick(object sender, EventArgs e)
        {
            seconds++;
            Debug.WriteLine(seconds);
            if (seconds >= 60)
            {
                seconds = 0;
                apimanager.DataGrabber(TB_City.Text);
                Debug.WriteLine("Resetting to 0");
            }
        }

        private void TB_Name_GotFocus(object sender, RoutedEventArgs e)
        {
            string[] lines = File.ReadAllLines(NameFilePath);
            string Name = lines.FirstOrDefault();

            if (TB_Name.Text == TB_Name.Text)
            {
                TB_Name.Text = "";
            }
        }
        private void OnKeyDownHandler8_Name(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                string[] lines = File.ReadAllLines(NameFilePath);
                if (TB_Name.Text.Length > 0)
                {
                    string Name = TB_Name.Text;
                    File.WriteAllText(NameFilePath, Name);
                }
                else
                {
                    string Name = lines.FirstOrDefault();
                    TB_Name.Text = Name;
                }
            }
        }
        private void OnKeyDownHandler8_Search(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                previousCity = TB_City.Text;
                apimanager.DataGrabber(SearchBox.Text);
                SearchBox.Text = "Search...";
            }
        }
        private void FavoriteButton_Click(object sender, RoutedEventArgs e) // function for button to add or remove city from favorite cities
        {
            string currentCity = TB_City.Text;

            if (cityboxmanager.GetCities().Contains(currentCity))
            {
                cityboxmanager.RemoveCity_Favorite(currentCity);
            }
            else
            {
                cityboxmanager.AddCity_Favorite(currentCity);
            }
            
            Initializer();
        }
        private void ComboBox_Cities_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string city = ComboBox_Cities.SelectedItem.ToString();
            apimanager.DataGrabber(city);

        }
        private void SearchBox_GotFocus(object sender, RoutedEventArgs e) // function to clear search box when clicked
        {
            if (SearchBox.Text == "Search...")
            {
                SearchBox.Text = "";
            }
        }
    }


    public class CityBoxManager
    {
        string city;

        string filePath = Path.Combine("..", "..", "..", "Files", "FavoriteCities.txt");

        public CityBoxManager()
        {
        }
        public ComboBox ComboBox_Cities { get; set; }


        public void AddCity_Favorite(string city)
        {
           File.AppendAllText(filePath, city + Environment.NewLine);
        }

        public void RemoveCity_Favorite(string city)
        {
           File.WriteAllText(filePath, "");
        }
        public string GetCities()
        {
            string[] lines = File.ReadAllLines(filePath);
            string cities = lines.FirstOrDefault();
            return cities;
        }
    }
}
