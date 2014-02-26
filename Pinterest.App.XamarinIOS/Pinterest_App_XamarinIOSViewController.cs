using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace Pinterest.App.XamarinIOS
{
	public partial class Pinterest_App_XamarinIOSViewController : UIViewController
	{
		static bool UserInterfaceIdiomIsPhone
		{
			get
			{
				return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone;
			}
		}

		public Pinterest_App_XamarinIOSViewController ()
			: base (UserInterfaceIdiomIsPhone ? "Pinterest_App_XamarinIOSViewController_iPhone" : "Pinterest_App_XamarinIOSViewController_iPad", null)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.
		}
	}
}

