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
	public partial class RegistrationPage : ContentPage
	{
		public RegistrationPage()
		{
			InitializeComponent();
		}

		async private void Btn_Clicked(object sender, EventArgs e)
		{
			var response = await DisplayAlert("Alert", "Do you want to submit?", "Yes", "No");
			if (response)
			{
				await DisplayAlert("Done", "Your Account has been Registered!", "Ok");
			}
			
			await Navigation.PopAsync();
		}
    }
}