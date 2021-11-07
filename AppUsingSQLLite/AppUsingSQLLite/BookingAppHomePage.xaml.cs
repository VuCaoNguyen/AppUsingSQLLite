using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppUsingSQLLite
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BookingAppHomePage : ContentPage
    {
        List<City> cities;
        void CityInit()
        {
            Database db = new Database();
            cities = db.GetCities();
            lstCity.ItemsSource = cities;
        }
        public BookingAppHomePage()
        {
            InitializeComponent();
            CityInit();
        }

        private void addNewCity_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddNewCity());
        }

        private void addNewHotel_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddNewHotelPage());
        }

        private void lstCity_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            City selected = (City)e.SelectedItem;
            Navigation.PushAsync(new HotelPage(selected));
        }
    }
}