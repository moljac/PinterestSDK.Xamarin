using System;
using MonoTouch.UIKit;
using System.Drawing;

using MonoTouch.CoreGraphics;
using MonoTouch.Foundation;


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

		Com.Pinterest.Pinit.Pinterest pinterest = null;
		UIImageView sampleImageView = null;
		UIButton pinItButton = null;
		
		string client_id = "1436429";
		
		// #define kMargin             20.0
		float kMargin = 20.0f;
		float kSampleImageWidth = 320.0f;
		float kSampleImageHeight = 200.0f;

		float kPinItButtonWidth = 72.0f;
		float kPinItButtonHeight = 32.0f;

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
//			UIButton button_pinterest = new UIButton(UIButtonType.RoundedRect)
//				{
//				  Frame = new System.Drawing.RectangleF( 60, 100, 200, 80)
//				, BackgroundColor = UIColor.White
//				};
//			
//			// Perform any additional setup after loading the view, typically from a nib.
//			PinIt pin_it = new PinIt();
//			PinIt.PinItButton = button_pinterest;
//			
//			View.AddSubview 
//					(
//						//button_pinterest
//						PinIt.PinItButton
//					);
		
			// Perform any additional setup after loading the view, typically from a nib.
			View.BackgroundColor = UIColor.White;
			Title = "Pmterest Pint It Demo";

			// Initialize a Pinterest instance with our client_id
			pinterest = new Com.Pinterest.Pinit.Pinterest ("1234", "prod");

			// Setup a sample imageview for the image we want to pin
			var sampleImage = UIImage.LoadFromData (
				                  NSData.FromUrl (
					                  NSUrl.FromString ("http://placekitten.com/500/400")
				                  )
			                  );
			sampleImageView = new UIImageView (sampleImage) {
				Frame = new RectangleF (0, 61, kSampleImageWidth, kSampleImageHeight)
			};

			View.AddSubview (sampleImageView);

			// Setup PinIt Button
			pinItButton = Com.Pinterest.Pinit.Pinterest.GetPinItButton ();
			pinItButton.Frame = new RectangleF (124, 281, 72, 32);

			// Add button handler
			pinItButton.TouchUpInside += 	
								pinItButton_HandleTouchUpInside;
								//(sender, e) => {};

			View.AddSubview (pinItButton);

			return;
		}

		void pinItButton_HandleTouchUpInside (object sender, EventArgs e)
		{
			// Check if we can pin or if we are using simulator
			if (!pinterest.CanPin)
			{
				new UIAlertView ("Error:", "Pinterest SDK can't pin if you are using simulator or you don't have Pinterest app :'(", null, "Ok", null).Show ();
			}
			else
			{
				pinterest.CreatePin (NSUrl.FromString ("http://placekitten.com/500/400"),
				                     NSUrl.FromString ("http://placekitten.com"),
				                     "Pinning from Pin It Demo"
				);
			}
		}
		
		// (void)pinIt:(id)sender
		void PinIt (object sender)
		{
			try
			{
				pinterest.CreatePin
					(
					new NSUrl (@"http://placekitten.com/500/400")
	                //, sourceURL:[NSURL URLWithString:@"http://placekitten.com"]
					, new NSUrl (@"http://placekitten.com")
	                //, description:@"Pinning from Pin It Demo"
					, @"Pinning from Pin It iOS Demo"
				);
				//];
			}
			catch (Exception exc)
			{
				string msg = exc.Message;
			}
			
			return;
		}

		void PinItButton_HandleTouchUpInside (object sender, EventArgs e)
		{
			PinIt(sender);
			
			return;
		}
	}
}

