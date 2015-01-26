using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libRZSquaresLoading.a", LinkTarget.Simulator | LinkTarget.ArmV7, SmartLink = true, ForceLoad = true)]
