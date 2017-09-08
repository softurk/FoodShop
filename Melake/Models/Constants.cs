using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Melake.Models
{
    public class Constants
    {

        public static bool ısDev = true;

        public static Color BackgroundColor = Color.FromRgb(81, 35, 0);

        public static Color MainTexColor = Color.White;

        public static int LoginIconHeight = 120;




        //------ Login ------ //

        public static string LoginUrl = "https://test.com/api/Auth/Login";

        public static string NoInternetText = "No Internet, please reconnect.";
    };
}
