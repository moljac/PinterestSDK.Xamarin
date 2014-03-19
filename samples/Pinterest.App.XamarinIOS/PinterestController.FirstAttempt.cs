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

		Com.Pinterest.Pinit.Pinterest _pinterest = null;
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
		
			this.View.BackgroundColor = UIColor.White;
						
			RectangleF rect_label = new RectangleF(0,0,0,0);
			UILabel titleLabel = new UILabel(rect_label);
	    	// CGFloat centerX = CGRectGetMidX(self.view.frame);
			float centerX = this.View.Bounds.GetMidX();
		    
			titleLabel.Text = @"Pinterest Pin It Demo";
		    titleLabel.BackgroundColor =  UIColor.Clear;
		    titleLabel.SizeToFit();
		    titleLabel.Frame =
						  // CGRectMake
						  new RectangleF
							(
							  //centerX - CGRectGetWidth(titleLabel.frame)/2
							  centerX - (float)(titleLabel.Frame.Width / 2.0)
							, kMargin
							//, CGRectGetWidth(titleLabel.frame)
							, titleLabel.Frame.Width
							// , CGRectGetHeight(titleLabel.frame)
							, titleLabel.Frame.Height
							);
		    this.View.AddSubview(titleLabel);
			
		   // Setup a sample imageview for the image we want to pin
		    NSUrl aURL = new NSUrl(@"http://placekitten.com/500/400");
			NSData data = NSData.FromUrl(aURL);
			UIImage sampleImage = new UIImage(data);
		    UIImageView sampleImageView = new UIImageView(new RectangleF(0,0,0,0));
		    sampleImageView.Image = sampleImage;
			sampleImageView.Frame = 
					 //:CGRectMake
					new RectangleF
						(
						  centerX - (float)(kSampleImageWidth / 2)
						//, tCGRectGetMaxY(titleLabel.frame) + kMargin
						, titleLabel.Frame.GetMaxY() + kMargin
						, kSampleImageWidth
						, kSampleImageHeight
						);
			this.View.AddSubview(sampleImageView);


			// Setup PinIt Button
			UIButton pinItButton = Com.Pinterest.Pinit.Pinterest.GetPinItButton();
		    // pinItButton is null!?!?!/
			pinItButton.Frame =
					new RectangleF
						(
						  (float) (centerX - kPinItButtonWidth/2)
						//, CGRectGetMaxY(sampleImageView.frame) + kMargin,
                        , sampleImageView.Frame.GetMaxY() + kMargin
						, kPinItButtonWidth
						, kPinItButtonHeight
						);
    		//[pinItButton addTarget:self
            //        action:@selector(pinIt:)
            //			forControlEvents:UIControlEventTouchUpInside
			//];
			//-------------------------------------------------------------------------
			//pinItButton.AddTarget
			//				(
			//				this
			//				, new MonoTouch.ObjCRuntime.Selector("PinIt")
			//				, UIControlEvent.TouchUpInside
			//				);
			//-------------------------------------------------------------------------
			_pinterest = new Com.Pinterest.Pinit.Pinterest(client_id, "prod");
			//_pinterest = new PinterestSDK.PinterestBinding(client_id);
			//_pinterest = new PinterestSDK.PinterestBinding();

			pinItButton.TouchUpInside += PinItButton_HandleTouchUpInside;
			pinItButton.SetTitle("Press", UIControlState.Normal);
			pinItButton.BackgroundColor = UIColor.Blue;
			this.View.AddSubview(pinItButton);

			return;
		}
		
		// (void)pinIt:(id)sender
		void PinIt (object sender)
		{
			try
			{
				_pinterest.CreatePin
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

