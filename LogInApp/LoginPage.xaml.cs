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
	public partial class LoginPage : ContentPage
	{

		public LoginPage()
		{
			InitializeComponent();
		}

		string Username = "admin";
		string Password = "admin";

		async private void BtnLogin_Clicked(object sender, EventArgs e)
		{
			if (Username == EntField1.Text && Password == EntField2.Text)
			{
				await Navigation.PushAsync(new MainPage());
			}
			else {
				await DisplayAlert("LogIn Failed", "Username or Password Incorrect", "Retry");
			
			}
		}

		async private void BtnRegister_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new RegistrationPage());
		}

		async private void BtnForgot_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new ForgotPassPage());
		}
	}
}