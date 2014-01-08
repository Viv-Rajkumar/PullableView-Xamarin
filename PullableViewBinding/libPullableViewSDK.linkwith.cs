using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libPullableViewSDK.a", LinkTarget.Simulator | LinkTarget.ArmV7, ForceLoad = true)]
