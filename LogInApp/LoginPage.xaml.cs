using SQLite;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogInApp.Helper;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LogInApp
{

	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		UserDB userData;
		public LoginPage()
		{
			InitializeComponent();
			userData = new UserDB();
			NavigationPage.SetHasNavigationBar(this, false);
			userNameEntry.ReturnCommand = new Command(() => passwordEntry.Focus());
			firstPassword.ReturnCommand = new Command(() => secondPassword.Focus());
			var forgetpassword_tap = new TapGestureRecognizer();
			forgetpassword_tap.Tapped += Forgetpassword_tap_Tapped;
			forgetLabel.GestureRecognizers.Add(forgetpassword_tap);


		}

		protected override async void OnAppearing()
		{
			await _connection.CreateTableAsync<LoginDetails>();
			//var username=await _connection.Table<LoginDetails>().ToListAsync();

		}


		async private void BtnLogin_Clicked(object sender, EventArgs e)
		{
			//if (Username == EntField1.Text && Password == EntField2.Text)
			//{
			//	await Navigation.PushAsync(new MainPage());
			//}
			//else {
			//	await DisplayAlert("LogIn Failed", "Username or Password Incorrect", "Retry");
			
			//}
		}

		private async void userIdCheckEvent(object sender, EventArgs e)
		{
			if ((string.IsNullOrWhiteSpace(useridValidationEntry.Text)) || (string.IsNullOrWhiteSpace(useridValidationEntry.Text)))
			{
				await DisplayAlert("Alert", "Enter Mail Id", "OK");
			}
			else
			{
				admin = useridValidationEntry.Text;
				var textresult = userData.updateUserValidation(useridValidationEntry.Text);
				if (textresult)
				{
					popupLoadingView.IsVisible = false;
					passwordView.IsVisible = true;
				}
				else
				{
					await DisplayAlert("User Mail Id Not Exist", "Enter Correct User Name", "OK");
				}
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