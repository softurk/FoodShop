using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Melake.Tabbed_Sayfalar;

namespace Melake.Views
{
    public class MyTabbedPage : TabbedPage
    {
        public MyTabbedPage()
        {

            Children.Add(new MyTab1());
            Children.Add(new MyTab2());
            Children.Add(new MyTab3());
        }
    }
}
