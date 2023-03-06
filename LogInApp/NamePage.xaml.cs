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
	public partial class NamePage : ContentPage
	{
		public NamePage()
		{
			InitializeComponent();
			if (Application.Current.Properties.ContainsKey("Name"))
			{
				Label1.Text = Application.Current.Properties["Name"].ToString();
			}
		}

		public App()
		{
			InitializeComponent(); MainPage = new NavigationPage(new Welcome());
		}

		async private void BtnBack_Clicked() 
		{

		}
	}
}