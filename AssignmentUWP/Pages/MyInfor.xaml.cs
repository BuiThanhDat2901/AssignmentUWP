using AssignmentUWP.Entity;
using AssignmentUWP.Service;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace AssignmentUWP.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MyInfor : Page
    {
        public MyInfor()
        {
            this.InitializeComponent();
            this.Loaded += InfoPage_Loaded;
        }

        private void InfoPage_Loaded(object sender, RoutedEventArgs e)
        {
            Account account = App.accountUser;

            if (account != null)
            {
                ApplicationData.Current.LocalSettings.Values["CurrentAccountJSON"] = JsonConvert.SerializeObject(account);
                txtFirstName.Text = account.firstName;
                txtLastName.Text = account.lastName.ToString();
                txtEmail.Text = account.email.ToString();
                txtAddress.Text = account.address.ToString();
                txtPhone.Text = account.phone.ToString();
                BitmapImage bitmapImageAvatar = new BitmapImage(new Uri(account.avatar.ToString()));
                txtAvatar.Source = bitmapImageAvatar;
                txtGender.Text = account.gender.ToString();
                txtBirthday.Text = account.birthday.ToString();
                txtStatus.Text = account.status.ToString();
                txtIntroduction.Text = account.introduction ?? "";
            }
        }

        private async void BtnLogout_Click(object sender, RoutedEventArgs e)
        {
            ContentDialog LogoutCheck = new ContentDialog
            {
                Title = "Đăng xuất",
                Content = "Bạn có muốn đăng xuất không?",
                PrimaryButtonText = "Có",
                CloseButtonText = "Không",
            };

            ContentDialogResult result = await LogoutCheck.ShowAsync();
            if (result == ContentDialogResult.Primary)
            {
                try
                {
                    StorageFolder storageFolder = ApplicationData.Current.LocalFolder;
                    StorageFile manifestFile = await storageFolder.GetFileAsync(AccountService.tokenUserFile);
                    await manifestFile.DeleteAsync();
                    Frame rootFrame = Window.Current.Content as Frame;
                    rootFrame.Navigate(typeof(Pages.Login));
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Có lỗi xảy ra khi logout" + ex);
                }
            }
            else
            {
                Debug.WriteLine("Lỗi Đăng Xuất");
            }
        }
    }
}
