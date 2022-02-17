using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace AssignmentUWP.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Navigation : Page
    {
        public static Frame NavigationFrame;

        private readonly List<(string Tag, Type Page)> _pages = new List<(string Tag, Type Page)>
        {
           
            //("myListSong", typeof(Pages.MyListSong)),
           
            ("createMySong", typeof(Pages.CreateMySong)),
            ("myInfor", typeof(Pages.MyInfor)),
        };
        public Navigation()
        {
            this.InitializeComponent();
        }

        private void NavigationViewPage_Loaded(object sender, RoutedEventArgs e)
        {
            MainContent.Navigate(typeof(Pages.MyInfor));
        }

        private void NavView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
           
            
                var selectItem = sender.SelectedItem as NavigationViewItem;
                var item = _pages.FirstOrDefault(p => p.Tag.Equals(selectItem.Tag));
                MainContent.Navigate(item.Page);
            
        }
    }
}
