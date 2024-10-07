using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using SysLite.Pages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using static System.Net.Mime.MediaTypeNames;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace SysLite
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
            ExtendsContentIntoTitleBar = true;
            Title = "SysLite";
            SetTitleBar(AppTitleBar);
        }

        private HomePage Page_Home;
        private ImagePage Page_Image;

        private void Nav_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            var tmp = (string)args.SelectedItemContainer.Content;
            sender.Header = tmp;
            sender.AlwaysShowHeader = tmp != "主页";
            switch (tmp)
            {
                case "主页":
                    if (Page_Home is null) Page_Home = new HomePage();
                    NavContainer.Content = Page_Home;
                    break;
                case "映像来源":
                    if (Page_Image is null) Page_Image = new ImagePage();
                    NavContainer.Content = Page_Image;
                    break;
            }
        }
    }
}
