// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace PullableViewExample
{
	[Register ("PullUpContainerViewController")]
	partial class PullUpContainerViewController
	{
		[Outlet]
		MonoTouch.UIKit.UILabel SomeLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (SomeLabel != null) {
				SomeLabel.Dispose ();
				SomeLabel = null;
			}
		}
	}
}
