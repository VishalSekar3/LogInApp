using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LogInApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		async private void BtnLogout_Clicked(object sender, EventArgs e)
		{
			await Navigation.PopAsync();
        }
    }
}
