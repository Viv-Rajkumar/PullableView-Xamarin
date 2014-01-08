using System.Drawing;
using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.ObjCRuntime;

namespace PullableViewBinding {

	[Model, BaseType (typeof (NSObject))]
	public partial interface PullableViewDelegate {
		[Export ("pullableView:didChangeState:"), EventArgs ("PullableViewOpened")]
		void DidChangeState (PullableView pView, bool opened);
	}

	[BaseType (typeof (UIView), Delegates=new string[] {"WeakDelegate"}, Events = new Type[] {typeof(PullableViewDelegate)})]
	public partial interface PullableView {
		[Export ("initWithFrame:")]
		IntPtr Constructor (RectangleF frame);

		[Export ("startPos")]
		PointF StartPos { get; set; }

		[Export ("minPos")]
		PointF MinPos { get; set; }

		[Export ("maxPos")]
		PointF MaxPos { get; set; }

		[Export ("verticalAxis")]
		bool VerticalAxis { get; set; }

		[Export ("handleView")]
		UIView HandleView { get; }

		[Export ("closedCenter", ArgumentSemantic.Assign)]
		PointF ClosedCenter { get; set; }

		[Export ("openedCenter", ArgumentSemantic.Assign)]
		PointF OpenedCenter { get; set; }

		[Export ("dragRecognizer")]
		UIPanGestureRecognizer DragRecognizer { get; }

		[Export ("tapRecognizer")]
		UITapGestureRecognizer TapRecognizer { get; }

		[Export ("toggleOnTap")]
		bool ToggleOnTap { get; set; }

		[Export ("animate")]
		bool Animate { get; set; }

		[Export ("animationDuration")]
		float AnimationDuration { get; set; }

		[Export ("delegate", ArgumentSemantic.Assign)]
		NSObject WeakDelegate { get; set; }

		[Wrap ("WeakDelegate")]
		PullableViewDelegate Delegate { get; set; }

		[Export ("opened")]
		bool Opened { get; }

		[Export ("setOpened:animated:")]
		void SetOpened (bool op, bool anim);
	}
}
