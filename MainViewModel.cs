using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DI_ExampleWithWeatherApp
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private readonly IWeatherService _weatherService;
        private string _weatherInfo;
        public MainViewModel(IWeatherService weatherService)
        {
            _weatherService = weatherService;
            GetWeatherCommand = new RelayCommand(GetWeather);
        }
        public string WeatherInfo
        {
            get => _weatherInfo;
            set
            {
                _weatherInfo = value;
                OnPropertyChanged(nameof(WeatherInfo));
            }
        }

        public ICommand GetWeatherCommand { get; }

        private void GetWeather(object parameter)
        {
            WeatherInfo = _weatherService.GetWeather("New York");
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
