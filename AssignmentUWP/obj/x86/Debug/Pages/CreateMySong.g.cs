#pragma checksum "C:\Users\ADMIN\source\repos\AssignmentUWP\AssignmentUWP\Pages\CreateMySong.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2A27877D03FC28479059891B3B4C97528C98C6A6C9A1C29FD56AC911F5332FE9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AssignmentUWP.Pages
{
    partial class CreateMySong : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Pages\CreateMySong.xaml line 23
                {
                    this.txtName = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 3: // Pages\CreateMySong.xaml line 24
                {
                    this.lblCheckName = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4: // Pages\CreateMySong.xaml line 26
                {
                    this.txtDescription = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 5: // Pages\CreateMySong.xaml line 27
                {
                    this.lblCheckDescription = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6: // Pages\CreateMySong.xaml line 28
                {
                    this.txtSinger = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 7: // Pages\CreateMySong.xaml line 29
                {
                    this.lblCheckSinger = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8: // Pages\CreateMySong.xaml line 30
                {
                    this.txtAuthor = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 9: // Pages\CreateMySong.xaml line 31
                {
                    this.lblCheckAuthor = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 10: // Pages\CreateMySong.xaml line 32
                {
                    this.txtThumbnail = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 11: // Pages\CreateMySong.xaml line 36
                {
                    this.btnCreateThumbnail = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnCreateThumbnail).Click += this.Button_CreateThumbnail;
                }
                break;
            case 12: // Pages\CreateMySong.xaml line 37
                {
                    this.btnDeleteThumbnail = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnDeleteThumbnail).Click += this.Button_DeleteThumbnail;
                }
                break;
            case 13: // Pages\CreateMySong.xaml line 38
                {
                    this.lblCheckThumbnail = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 14: // Pages\CreateMySong.xaml line 39
                {
                    this.txtLink = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 15: // Pages\CreateMySong.xaml line 40
                {
                    this.lblCheckLink = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 16: // Pages\CreateMySong.xaml line 44
                {
                    this.waitingRespone = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 17: // Pages\CreateMySong.xaml line 42
                {
                    global::Windows.UI.Xaml.Controls.Button element17 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element17).Click += this.Button_CreateSong;
                }
                break;
            case 18: // Pages\CreateMySong.xaml line 34
                {
                    this.imgThumbnail = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

