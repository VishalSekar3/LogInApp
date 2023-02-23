using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LogInApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ForgotPassPage : ContentPage
	{
		public ForgotPassPage ()
		{
			InitializeComponent ();
		}

		async private void BtnPass_Clicked(object sender, EventArgs e)
		{
			var response = await DisplayAlert("Warning!", "Change to new Password?", "No", "Yes");
			if (response)
			{
				await DisplayAlert("Done", "Your Password has been Changed!", "Ok");
			}

			await Navigation.PopAsync();

		}
    }
}