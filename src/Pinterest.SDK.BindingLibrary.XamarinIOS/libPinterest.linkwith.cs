using System;
using MonoTouch.ObjCRuntime;

using System;
using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;

[assembly: LinkerSafe]
[assembly: LinkWith 
			(
			  "Pinterest"
			, LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator
			, Frameworks = "CoreGraphics"
			, SmartLink = true
			, ForceLoad = true
			)
]

// moljac 1st attempt - just to remember
//[assembly: LinkWith 
//			(
//			  "libPinterest.a"	// static library or framework (in this case renamed to .a)
//			, LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator
//			, ForceLoad = true
//			)
//]


// Specify only the library name as a constructor argument and specify everything else with properties:
//[assembly: LinkWith 
//			(
//			  "libPinterest.a"
//			, LinkTarget = LinkTarget.ArmV6 | LinkTarget.ArmV7 | LinkTarget.Simulator
//			, ForceLoad = true
//			, IsCxx = false
//			)
//]

// Or you can specify library name *and* link target as constructor arguments:
//[assembly: LinkWith 
//		(
//		  "libPinterest.a"
//		, LinkTarget.ArmV6 | LinkTarget.ArmV7 | LinkTarget.Simulator
//		//, LinkerFlags="-sqllite3"
//		//, Frameworks="MobileCoreServices SystemConfiguration ASIHTTPRequest"
//		, ForceLoad = true
//		, IsCxx = false
//		)
//]

// Equivalent  
// iOS Application Project +/ Options +/ iOS Build +/ Additional mtouch arguments:

// -v -v -v TODO: docs