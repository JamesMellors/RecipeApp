using RecepeApp.Models;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RecepeApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RecipeList : ContentPage
    {
 

        public RecipeList()
        {
            InitializeComponent();

            BindingContext = new RecipeListViewModel();
        }

        async void MyListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var recipe = e.SelectedItem as Recipe;

            if (recipe == null)
                return;

            var detailsPage = new RecipeDetailPage(recipe);
            await Navigation.PushAsync(detailsPage);

            MyListView.SelectedItem = null;
        }
    }
}
