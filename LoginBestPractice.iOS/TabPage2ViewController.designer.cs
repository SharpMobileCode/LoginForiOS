// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace LoginBestPractice.iOS
{
	[Register ("TabPage2ViewController")]
	partial class TabPage2ViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton LogOutButton { get; set; }

		[Action ("LogOutButton_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void LogOutButton_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (LogOutButton != null) {
				LogOutButton.Dispose ();
				LogOutButton = null;
			}
		}
	}
}
