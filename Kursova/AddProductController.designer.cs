// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Kursova
{
	[Register ("AddProductController")]
	partial class AddProductController
	{
		[Outlet]
		AppKit.NSTextField date { get; set; }

		[Outlet]
		AppKit.NSTextField price { get; set; }

		[Outlet]
		AppKit.NSTextField producerName { get; set; }

		[Outlet]
		AppKit.NSTextField productName { get; set; }

		[Action("addProductAction:")]
		partial void AddProductAction(Foundation.NSObject sender);

		void ReleaseDesignerOutlets ()
		{
			if (productName != null) {
				productName.Dispose ();
				productName = null;
			}

			if (producerName != null) {
				producerName.Dispose ();
				producerName = null;
			}

			if (price != null) {
				price.Dispose ();
				price = null;
			}

			if (date != null) {
				date.Dispose ();
				date = null;
			}
		}
	}
}
