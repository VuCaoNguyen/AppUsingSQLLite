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
    public partial class AddNewHotelPage : ContentPage
    {
        List<City> cityList;

        void PickerInit()
        {
            Database db = new Database();
            cityList = db.GetCities();
            pickCity.ItemsSource = cityList;
            
        }
        public AddNewHotelPage()
        {
            InitializeComponent();
            PickerInit();
        }

        private void addHotel_Clicked(object sender, EventArgs e)
        {
            Database db = new Database();

            Hotel newHotel = new Hotel();
            City selectedCity = (City)pickCity.SelectedItem;
            newHotel.hName = hotelName.Text;
            newHotel.hImg = hotelImg.Text;
            newHotel.cId = selectedCity.Id;
            if (db.AddNewHotel(newHotel))
            {
                DisplayAlert("Thông báo", "Thêm khách sạn thành công", "Ok");
                Navigation.PushAsync(new BookingAppHomePage());
            }
            else
            {
                DisplayAlert("Thông báo", "Thêm khách sạn thất bại", "Ok");

            }
        }
    }
}