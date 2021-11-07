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
    public partial class AddNewCity : ContentPage
    {
        public AddNewCity()
        {
            InitializeComponent();
        }

        private void addCity_Clicked(object sender, EventArgs e)
        {

            City newCity = new City();
            newCity.Name = cityName.Text;
            newCity.Img = cityImg.Text;
            Database db = new Database();

            if (db.AddNewCity(newCity))
            {
                DisplayAlert("Thông báo", "Thêm thành phố thành công", "Ok");
                Navigation.PushAsync(new BookingAppHomePage());

            }
            else
            {
                DisplayAlert("Thông báo", "Thất bại", "Ok");
            }

        }
    }
}