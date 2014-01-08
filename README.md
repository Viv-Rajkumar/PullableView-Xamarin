## Summary

This is a Xamarin iOS Binding for the [PullableView Project](https://github.com/crocodella/PullableView). It is based on the fork from [nelidimitrova](https://github.com/nelidimitrova/PullableView) which adds ARC support to the original project.

## Native Project Additions:

Added a new function to the Obj-C code to selectively ignore mouse clicks on the base view to allow for handle's to be of various sizes and shapes.

    - (UIView*)hitTest:(CGPoint)point withEvent:(UIEvent *)event {
      UIView *hitView = [super hitTest:point withEvent:event];
      
      if (hitView == self) {
        return nil;
      }
      return hitView;
    }

## Binding Project Additions:

1. `PullableViewDelegate`'s `DidChangeState` exposed as a C# event to allow easy subscribing to change state notifications such as:

    `_pullableView.DidChangeState += (sender, e) => Console.WriteLine ("State of Menu: " + (e.Opened ? "Open" : "Closed"));`

2. Added a new constructor to `PullableView` mapped to `initWithFrame:`


## Usage:

Refer to the example in the contained solution to see it's usage when the `PullableView` is extracted from an embedded `ContainerView`