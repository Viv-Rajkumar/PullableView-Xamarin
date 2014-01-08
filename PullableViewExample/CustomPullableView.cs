using System;
using System.Drawing;
using PullableViewBinding;

namespace PullableViewExample
{
	public class CustomPullableView : PullableView
	{
		public CustomPullableView (RectangleF rectangle)
			: base(rectangle) {
		}

		public override MonoTouch.UIKit.UIView HitTest (System.Drawing.PointF point, MonoTouch.UIKit.UIEvent uievent)
		{
			var replyView = base.HitTest (point, uievent);
			if (replyView == this)
				return null;
			return replyView;
		}
	}
}

