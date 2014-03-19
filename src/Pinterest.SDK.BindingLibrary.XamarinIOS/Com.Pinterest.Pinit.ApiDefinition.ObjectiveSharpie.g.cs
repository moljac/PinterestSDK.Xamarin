using System;

using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;
using MonoTouch.UIKit;

namespace Com.Pinterest.Pinit 
{

	[BaseType (typeof (NSObject))]
	public partial interface Pinterest {

		[Export ("initWithClientId:")]
		IntPtr Constructor (string clientId);

		[Export ("initWithClientId:urlSchemeSuffix:")]
		IntPtr Constructor (string clientId, string suffix);

		[Export ("canPinWithSDK")
			//, Verify ("ObjC method massaged into getter property", "/Users/moljac/Projects/HolisticWare/Components/PinterestSDK.Xamarin/developer.pinterest.com/PinItSDKiOS/Pinterest.embeddedframework/Pinterest.framework/Versions/A/Headers/Pinterest.h", Line = 52)
		]
		bool CanPinWithSDK { get; }

		[Export ("createPinWithImageURL:sourceURL:description:")]
		void CreatePinWithImageURL (NSUrl imageURL, NSUrl sourceURL, string descriptionText);

		[Static, Export ("pinItButton")
			//, Verify ("ObjC method massaged into getter property", "/Users/moljac/Projects/HolisticWare/Components/PinterestSDK.Xamarin/developer.pinterest.com/PinItSDKiOS/Pinterest.embeddedframework/Pinterest.framework/Versions/A/Headers/Pinterest.h", Line = 71)
		]
		UIButton PinItButton { get; }

		[Export ("openUserWithUsername:")]
		void OpenUserWithUsername (string username);

		[Export ("openPinWithIdentifier:")]
		void OpenPinWithIdentifier (string identifier);

		[Export ("openBoardWithSlug:fromUser:")]
		void OpenBoardWithSlug (string slug, string username);
	}
}
