using System;
using PullableViewBinding;
using MonoTouch.UIKit;

namespace PullableViewExample
{
	public class CustomPullableViewDelegate : PullableViewDelegate
	{
		private UILabel _label;
		public CustomPullableViewDelegate (UILabel label)
		{
			_label = label;
		}

		public override void DidChangeState (PullableView pView, bool opened) {
			// _label.Text = opened ? "I'm Open. Close Me Now" : "I'm Closed. Open Me Now";
		}
	}
}

