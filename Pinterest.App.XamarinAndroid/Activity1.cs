using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using Com.Pinterest.Pinit;

namespace Pinterest.App.XamarinAndroid
{
	[Activity(Label = "Pinterest.App.XamarinAndroid", MainLauncher = true, Icon = "@drawable/icon")]
	public class Activity1 : Activity
	{
		int count = 1;

		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			

			PinItButton.PartnerId = "1436429";	// required
			PinItButton.DebugMode = true;				// optional

			PinItButton pinIt = FindViewById<PinItButton>(Resource.Id.pin_it);
			pinIt.ImageUrl = "http://xamarin.com/images/xamarin-logo-v2.png";
			pinIt.Url = "http://xamarin.com"; // optional
			pinIt.Description = "Create Native iOS, Android, Mac and Windows apps in C#"; // optional

			pinIt.Click += new EventHandler(pinIt_Click);

			return;
		}

		void pinIt_Click(object sender, EventArgs e)
		{

			return;
		}
	}
}

