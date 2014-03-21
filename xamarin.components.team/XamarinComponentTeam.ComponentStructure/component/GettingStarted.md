# Requirements

In order to use Pinterest SDK, Pinterest moblie application must be installed 
on the device, both for iOS and Android. Pinterest application is free application.

## Usage

### iOS

In order to use PinITButton in iOS application user needs to initialize Pinterest SDK
with Client ID which can be obtained on Pinterest site. After SDK initialization in
UIViewController's ViewDidLoad method setup UIButton by obtaining it from SDK and placing
it in the Frame.mTouchUpInside calls CreatePin if all requirements are met.

PinterestViewController.cs

```csharp
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			// Perform any additional setup after loading the view, typically from a nib.
			View.BackgroundColor = UIColor.White;
			Title = "Pmterest Pint It Demo";

			// Initialize a Pinterest instance with client_id
			pinterest = new Pinterest ("1234", "prod");

			// Setup a sample imageview for the image we want to pin
			var sampleImage = UIImage.LoadFromData (
				NSData.FromUrl (
					NSUrl.FromString ("http://placekitten.com/500/400")
				)
			);
			sampleImageView = new UIImageView (sampleImage) {
				Frame = new RectangleF (0, 61, 320, 200)
			};

			View.AddSubview (sampleImageView);

			// Setup PinIt Button
			pinItButton = Pinterest.GetPinItButton ();
			pinItButton.Frame = new RectangleF (124, 281, 72, 32);

			// Add button handler
			pinItButton.TouchUpInside += (sender, e) => {
				// Check if we can pin or if we are using simulator
				if (!pinterest.CanPin)
					new UIAlertView 
							(
							  "Error:"
							, "Pinterest SDK can't pin if you are using simulator or "
							  + "you don't have Pinterest app :'("
							, null
							, "Ok"
							, null
							).Show ();
				else 
				pinterest.CreatePin (NSUrl.FromString ("http://placekitten.com/500/400"),
					NSUrl.FromString ("http://placekitten.com"),
						"Pinning from Pin It Demo"
				);
			};

			View.AddSubview (pinItButton);
		}
```

### Android

Generally PinIt button is defined in layout markup in Android xml (axml) file

```xml
    <com.pinterest.pinit.PinItButton
        android:id="@+id/pin_bt"
        android:layout_width="wrap_content"
        android:layout_height="wrap_content"
        android:layout_margin="@dimen/global_padding" 
		/>
```

NOTE: There is namespace error in Pinterest original demo.

Initialization of the Pinterest SDK occurs in OnCreate method of the Activity:

```csharp
			PinItButton pinIt = FindViewById<PinItButton> (Resource.Id.pin_bt);
			pinIt.ImageUrl = IMAGE_SOURCE;
			pinIt.Url  = WEB_URL;
			pinIt.Description  = description;
			pinIt.Listener = _listener;
```

Listener is c# implementation of the java async pattern.

There are 3 samples for Android platform and for more insights and details check
accompanying component samples.

