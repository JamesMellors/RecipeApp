using RecepeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RecepeApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RecipeDetailPage : ContentPage
	{
        Recipe _selectedRecipe;

        public RecipeDetailPage (Recipe selectedRecipe)
		{
			InitializeComponent ();

            _selectedRecipe = selectedRecipe;

            BindingContext = selectedRecipe;
		}
	}
}