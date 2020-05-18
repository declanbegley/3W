using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using _3W.Models;
using _3W.ViewModels;

namespace _3W.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ItemDetailPage : ContentPage
    {
        ItemDetailViewModel viewModel;

        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        public ItemDetailPage()
        {
            InitializeComponent();

            var item = new Item
            {
                Location = "New Location",
                Status = "New Status"
            };

            viewModel = new ItemDetailViewModel(item);
            BindingContext = viewModel;
        }


        public void EraseCommand(object sender, EventArgs e)
        {
            (sender as Button).Text = "Erased Click me again!";
        }

        public async void SaveButtonClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Save Alert", "This is an alert.", "OK");
        }

    }
}