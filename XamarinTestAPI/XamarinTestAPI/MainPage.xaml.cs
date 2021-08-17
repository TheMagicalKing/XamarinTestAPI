using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinTestAPI.Services;

namespace XamarinTestAPI
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public async void Item_Selected(object sender, SelectionChangedEventArgs e)
        {
            Services.Product product =
                e.CurrentSelection.First() as Services.Product;
            
            await Navigation.PushAsync(new ProductDetail(product));
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            var products = await ProductService.GetProductsAsync();
            
            BindingContext = products;
            
        }
    }
}

