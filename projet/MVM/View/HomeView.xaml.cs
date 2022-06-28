using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Microsoft.Maps.MapControl.WPF;
using ApiControler;

namespace projet.MVM.View
{
    public partial class HomeView : UserControl
    {
        public HomeView()
        {
            InitializeComponent();
            MainWindow mw = (MainWindow) Application.Current.MainWindow;

            Mymap.Focus();
            
        }
        
        private void MapWithPushpins_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {         

            e.Handled = true;
            MainWindow mw = (MainWindow) Application.Current.MainWindow;

            Point mousePosition = e.GetPosition(this);
            Location pinLocation = Mymap.ViewportPointToLocation(mousePosition);

            Pushpin pin = new Pushpin();
            pin.Location = pinLocation;


            var p = new APIcontrol();
            p.GetCity(pinLocation.Latitude.ToString(),pinLocation.Longitude.ToString());
            mw.searchbar.Text = p.objectRes.name;



        }
   
    }
}