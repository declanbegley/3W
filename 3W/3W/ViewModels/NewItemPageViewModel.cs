using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using _3W.Models;
using _3W.Views;

namespace _3W.ViewModels
{
    public class NewItemPageViewModel : BaseViewModel
    {
        public ObservableCollection<Item> Items { get; set; }
        public Command LoadItemsCommand { get; set; }

        public NewItemPageViewModel()
        {
            Title = "Add Items View";
        
        }

       

    }
}