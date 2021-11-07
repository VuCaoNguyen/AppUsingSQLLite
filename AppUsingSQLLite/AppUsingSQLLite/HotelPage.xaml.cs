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
    public partial class HotelPage : ContentPage
    {
        List<Hotel> listHotels;
        public HotelPage()
        {
            InitializeComponent();
        }

        public HotelPage(City city)
        {
            InitializeComponent();
            Title = city.Name;
            HotelInit(city);
        }
        void HotelInit(City city)
        {
            Database db = new Database();
            listHotels = db.GetHotels(city.Id);
            listHotel.ItemsSource = listHotels;
        }
    }
}