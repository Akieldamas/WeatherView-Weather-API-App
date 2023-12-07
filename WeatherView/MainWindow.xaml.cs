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
       // Uri NameFilePath = new Uri("Files/Name.txt", UriKind.Relative);

        APIManager apimanager;

        public MainWindow()
          {
            InitializeComponent();

            apimanager = new APIManager();
            cityboxmanager = new CityBoxManager();
            Initializer();
            Initialize_Timer();
        }
        private async void UpdateUI(string cityUpdate) // function to change UI using data from API
        {
            try
            {
                Root root = await apimanager.DataGrabber(cityUpdate);
                if (root == null)
                {
                    TB_City.Text = "City not found";
                    return;
                }
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
               string PrevCity = previousCity;
               UpdateUI(PrevCity);
            }
        }
        
        private void Initializer() 
        {

            // Enregistre tout les villes favorites dans une variable 
            string filePathCB = @"Files/FavoriteCities.txt";
            string[] linesCB = File.ReadAllLines(filePathCB);

            ComboBox_Cities.ItemsSource = linesCB; // nitialize combobox with favorite cities
            ComboBox_Cities.SelectedIndex = 0;

            if (File.ReadAllText(@"Files/Name.txt").Length > 1)
            {
                TB_Name.Text = File.ReadAllText(@"Files/Name.txt"); // initialize name textbox with name from file
            }
     }
        private void ComboBox_Cities_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboBox_Cities.SelectedItem == null)
            {
                return;
            }
            string cityCombobox = ComboBox_Cities.SelectedItem.ToString();
            UpdateUI(cityCombobox);
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
                UpdateUI(TB_City.Text);
                Debug.WriteLine("Resetting to 0");
            }
        }

        private void TB_Name_GotFocus(object sender, RoutedEventArgs e)
        {
            TB_Name.Text = "";
        }

        private void OnKeyDownHandler8_Search(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                previousCity = TB_City.Text;
                UpdateUI(SearchBox.Text);
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

            string filePathCB = @"Files/FavoriteCities.txt";
            string[] linesCB = File.ReadAllLines(filePathCB);

            ComboBox_Cities.ItemsSource = linesCB; // nitialize combobox with favorite cities
            ComboBox_Cities.SelectedIndex = 0;
        }
        private void SearchBox_GotFocus(object sender, RoutedEventArgs e) // function to clear search box when clicked
        {
           SearchBox.Text = "";
        }

        private void SaveNameButton_Click(object sender, RoutedEventArgs e)
        {
            string NameFilePath = @"Files/Name.txt";
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


    public class CityBoxManager
    {
        string filePathCB = @"Files/FavoriteCities.txt";
        public CityBoxManager()
        {
        }
        public ComboBox ComboBox_Cities { get; set; }


        public void AddCity_Favorite(string city)
        {
            File.AppendAllText(filePathCB, city + Environment.NewLine);
        }

        public void RemoveCity_Favorite(string city)
        {
            string[] lines = File.ReadAllLines(filePathCB);
            List<string> linesList = lines.ToList();
            linesList.Remove(city);
            File.WriteAllLines(filePathCB, linesList.ToArray());
        }
        public string[] GetCities()
        {
            string[] lines = File.ReadAllLines(filePathCB);
            return lines;
        }
    }
}
