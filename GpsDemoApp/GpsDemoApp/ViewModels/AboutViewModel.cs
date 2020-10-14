using Plugin.Geolocator;
using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace GpsDemoApp.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamain-quickstart"));
        }

        public ICommand OpenWebCommand { get; }

        /// <summary>
        /// ゲオロケーター
        /// https://jamesmontemagno.github.io/GeolocatorPlugin/GettingStarted.html
        /// を学習する
        /// </summary>
        private void test()
        {
            IsLocationAvailable();
        }

        /// <summary>
        /// GeolocatorPluginを使用する
        /// </summary>
        /// <returns></returns>
        public bool IsLocationAvailable()
        {
            if (!CrossGeolocator.IsSupported) return false;

            return CrossGeolocator.Current.IsGeolocationAvailable;
        }
    }
}