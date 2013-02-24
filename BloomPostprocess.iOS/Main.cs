using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace BloomPostprocess
{
	[Register("AppDelegate")]
	class Program : UIApplicationDelegate
	{
		public override void FinishedLaunching (UIApplication app)
		{
			// Fun begins..
			var game = new BloomPostprocess.BloomPostprocessGame();
			game.Run();
		}

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		static void Main (string[] args)
		{
			UIApplication.Main (args, null, "AppDelegate");
		}
	}    
}


