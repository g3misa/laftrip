// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace Laftrip.iOS
{
	[Register ("JokesShareViewController")]
	partial class JokesShareViewController
	{
		[Outlet]
		MonoTouch.UIKit.UIButton btnTwitterShare { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton btnFacebookShare { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton btnEmailShare { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton btnTextShare { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (btnTwitterShare != null) {
				btnTwitterShare.Dispose ();
				btnTwitterShare = null;
			}

			if (btnFacebookShare != null) {
				btnFacebookShare.Dispose ();
				btnFacebookShare = null;
			}

			if (btnEmailShare != null) {
				btnEmailShare.Dispose ();
				btnEmailShare = null;
			}

			if (btnTextShare != null) {
				btnTextShare.Dispose ();
				btnTextShare = null;
			}
		}
	}
}