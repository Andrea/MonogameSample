using System;

namespace BloomPostprocess.Windows8
{
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
#if !NETFX_CORE
			using (BloomPostprocessGame game = new BloomPostprocessGame())
			{
				game.Run();
			}
#endif
#if  NETFX_CORE
			var factory = new MonoGame.Framework.GameFrameworkViewSource<BloomPostprocessGame>();
            Windows.ApplicationModel.Core.CoreApplication.Run(factory);
#endif
        }
    }
}
