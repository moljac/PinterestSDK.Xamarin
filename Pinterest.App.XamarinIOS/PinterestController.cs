using System;
using MonoTouch.UIKit;

namespace Pinterest.App.XamarinIOS
{
	public class PinterestController : UIViewController
	{
		public PinterestController () 
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
			
			UIButton button_pinterest = new UIButton(UIButtonType.RoundedRect)
				{
				  Frame = new System.Drawing.RectangleF( 60, 100, 200, 80)
				, BackgroundColor = UIColor.White
				};
			
			// Perform any additional setup after loading the view, typically from a nib.
			PinIt pin_it = new PinIt();
			PinIt.PinItButton = button_pinterest;
			
			View.AddSubview 
					(
						//button_pinterest
						PinIt.PinItButton
					);
			
		}
	}
}

