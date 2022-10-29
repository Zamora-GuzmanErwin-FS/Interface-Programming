using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Day8Test
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();

            NavigationPage view1Navigation = new NavigationPage(new Tab1View());
            view1Navigation.IconImageSource = "number1.png";
            view1Navigation.Title = "Tab 1 View";

            NavigationPage view2Navigation = new NavigationPage(new Tab2View());
            view2Navigation.IconImageSource = "number2.png";
            view2Navigation.Title = "Tab 2 View";

        }
    }
}
