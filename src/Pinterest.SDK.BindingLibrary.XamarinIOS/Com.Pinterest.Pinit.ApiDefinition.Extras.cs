using System;
using MonoTouch.Foundation;

// additions/extensions to Com.Pinterest.Pinit.Pinterest class generated 

// Pinterest API used NSUrl which where GC-ed, so this is workaround to have working 
// references.

namespace Com.Pinterest.Pinit 
{
	public partial class Pinterest
	{
		static NSString nsclientId;
		static NSString nssuffix;

		public Pinterest (string clientId) : 
			this ((nsclientId = new NSString (clientId)))
		{	
		}

		public Pinterest (string clientId, string suffix) : 
			this ((nsclientId = new NSString (clientId)), (nssuffix = new NSString (suffix)))
		{
		}
	}
}
