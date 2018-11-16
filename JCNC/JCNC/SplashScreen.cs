using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JCNC
{
    /// <summary>
    /// Defined types of messages: Success/Warning/Error.
    /// </summary>
    public enum TypeOfMessage
    {
        Success,
        Warning,
        Error,
    }
    /// <summary>
    /// Initiate instance of SplashScreen
    /// </summary>
    public static class SplashScreen
    {
        static SplashScreenForm splash_screen = null;

        /// <summary>
        /// Displays the splashscreen
        /// </summary>
        public static void ShowSplashScreen()
        {
            if (splash_screen == null)
            {
                splash_screen = new SplashScreenForm();
                splash_screen.ShowSplashScreen();
            }
        }

        /// <summary>
        /// Closes the SplashScreen
        /// </summary>
        public static void CloseSplashScreen()
        {
            if (splash_screen != null)
            {
                splash_screen.CloseSplashScreen();
                splash_screen = null;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text">Message</param>
        public static void UdpateCopyRight(string Text)
        {
            if (splash_screen != null)
                splash_screen.UdpateCopyRight(Text);

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text">Message</param>
        public static void UdpateVersionText(string Text)
        {
            if (splash_screen != null)
                splash_screen.UdpateVersionText(Text);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text">Message</param>
        public static void UdpateStatusText(string Text)
        {
            if (splash_screen != null)
                splash_screen.UdpateStatusText(Text);

        }
        
        /// <summary>
        /// Update text with message color defined as green/yellow/red/ for success/warning/failure
        /// </summary>
        /// <param name="Text">Message</param>
        /// <param name="tom">Type of Message</param>
        public static void UdpateStatusTextWithStatus(string Text,TypeOfMessage tom)
        {
            
            if (splash_screen != null)
                splash_screen.UdpateStatusTextWithStatus(Text, tom);
        }
    }

}
