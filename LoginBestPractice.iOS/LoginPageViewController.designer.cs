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
	[Register ("LoginPageViewController")]
	partial class LoginPageViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton LoginButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField PasswordTextView { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton SignUpButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField UserNameTextView { get; set; }

		[Action ("LoginButton_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void LoginButton_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (LoginButton != null) {
				LoginButton.Dispose ();
				LoginButton = null;
			}
			if (PasswordTextView != null) {
				PasswordTextView.Dispose ();
				PasswordTextView = null;
			}
			if (SignUpButton != null) {
				SignUpButton.Dispose ();
				SignUpButton = null;
			}
			if (UserNameTextView != null) {
				UserNameTextView.Dispose ();
				UserNameTextView = null;
			}
		}
	}
}
