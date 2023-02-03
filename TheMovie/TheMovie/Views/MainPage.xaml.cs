using TheMovie.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static Xamarin.Forms.Device;

namespace TheMovie.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();            
            
            ItemsListView.ItemSelected += (sender, e) => {
                // Manually deselect item
                ((ListView)sender).SelectedItem = null;
            };


            //var array = MainPageViewModel.GetGenres_dropdown();
            //cbxEdit.ItemsSource = array;
        }
    }
}
