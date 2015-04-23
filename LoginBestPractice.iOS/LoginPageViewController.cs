using System;

using UIKit;

namespace LoginBestPractice.iOS
{
	partial class LoginPageViewController : UIViewController
	{
        //Create an event when a authentication is successful
        public event EventHandler OnLoginSuccess;

		public LoginPageViewController (IntPtr handle) : base (handle)
		{
        }

        partial void LoginButton_TouchUpInside(UIButton sender)
        {
            //Validate our Username & Password.
            //This is usually a web service call.
            if(IsUserNameValid() && IsPasswordValid())
            {
                //We have successfully authenticated a the user,
                //Now fire our OnLoginSuccess Event.
                if(OnLoginSuccess != null)
                {
                    OnLoginSuccess(sender, new EventArgs());
                }
            }
            else
            {
                new UIAlertView("Login Error", "Bad user name or password", null, "OK", null).Show();
            }
        }

        private bool IsUserNameValid()
        {
            return !String.IsNullOrEmpty(UserNameTextView.Text.Trim());
        }

        private bool IsPasswordValid()
        {
            return !String.IsNullOrEmpty(PasswordTextView.Text.Trim());
        }
	}
}
