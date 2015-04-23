using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace LoginBestPractice.iOS
{
	partial class SignUpViewController : UIViewController
	{
		public SignUpViewController (IntPtr handle) : base (handle)
		{
        }

        //This assumes we have successfully create a new user account
        //Naturally, you'll add your logic here, but we're ignoring
        //that for simplicity.
        partial void SignUpButton_TouchUpInside(UIButton sender)
        {
            //Create an instance of our AppDelegate
            var appDelegate = UIApplication.SharedApplication.Delegate as AppDelegate;

            //Get an instance of our MainStoryboard.storyboard
            var mainStoryboard = appDelegate.MainStoryboard;

            //Get an instance of our MainTabBarViewController
            var mainTabBarViewController = appDelegate.GetViewController(mainStoryboard, "MainTabBarController");

            //Set the MainTabBarViewController as our RootViewController
            appDelegate.SetRootViewController(mainTabBarViewController, true);
        }

        partial void CancelButton_TouchUpInside(UIButton sender)
        {
            DismissViewController(true, null);
        }
	}
}
