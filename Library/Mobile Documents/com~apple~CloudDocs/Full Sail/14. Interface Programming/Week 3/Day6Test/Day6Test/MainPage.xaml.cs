using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Day6Test.Models;
using System.Collections.ObjectModel;

namespace Day6Test
{
    public partial class MainPage : ContentPage
    {
        private ObservableCollection<MonkeyData> AllMonkeys;

        public MainPage()
        {
            InitializeComponent();
            AllMonkeys = new ObservableCollection<MonkeyData>(AllMonkeyData.Get());
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            monkeyCarousel.ItemsSource = AllMonkeys;
        }
    }
}
