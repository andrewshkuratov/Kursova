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
	[Register ("ProductMarketVCController")]
	partial class ProductMarketVCController
	{
		[Outlet]
		AppKit.NSSearchField FindField { get; set; }

		[Outlet]
		AppKit.NSTableView ProductTableView { get; set; }

		[Action ("DeleteAllData:")]
		partial void DeleteAllData (Foundation.NSObject sender);

		[Action ("FindProduct:")]
		partial void FindProduct (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (FindField != null) {
				FindField.Dispose ();
				FindField = null;
			}

			if (ProductTableView != null) {
				ProductTableView.Dispose ();
				ProductTableView = null;
			}
		}
	}
}
