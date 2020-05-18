using System;
using System.Threading.Tasks;
using _3W.Models;
using Xamarin.Forms;

namespace _3W.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Item Item { get; set; }
        public ItemDetailViewModel(Item item = null)
        {
            Title = "Asset Detail";
            Item = item;
        }

    

        private Task DisplayAlert(string v1, string v2, string v3)
        {
            throw new NotImplementedException();
        }
    }

}
