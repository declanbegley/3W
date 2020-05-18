using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace _3W.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("http://www.track3w.com"));
        }

        public ICommand OpenWebCommand { get; }
    }
}