using DevExpress.Data.Browsing;
using DevExpress.Mvvm;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Core.Native;
using DevExpress.Xpf.Editors.Helpers;
using DevExpress.Xpf.WindowsUI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProfitManagment_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<HamburgerMenuItemViewModel> MenuItems { get; set; }

        public ObservableCollection<HamburgerMenuItemViewModel> BottomBarMenuItems { get; set; }
        public HamburgerMenuItemViewModel SelectedItem { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            HamburgerMenuNavigationButton hamburgerMenuNavigationButton = new HamburgerMenuNavigationButton();



            this.DataContext = this;

            MenuItems = new ObservableCollection<HamburgerMenuItemViewModel>();

            HamburgerMenuItemViewModel item1 = new HamburgerMenuItemViewModel("دریافت سود/زیان", typeof(GetPerfit), @"SvgImages\Export\ExportToXLS.svg", Color.FromRgb(0, 167, 150), Color.FromRgb(255, 255, 255));
            MenuItems.Add(item1);
            HamburgerMenuItemViewModel item2 = new HamburgerMenuItemViewModel("سود/زیان روزانه", typeof(DailyPerfit), @"SvgImages\Chart\ChartType_Line.svg", Color.FromRgb(0, 167, 150), Color.FromRgb(255, 255, 255));
            MenuItems.Add(item2);

          

            //BottomBarMenuItems = new ObservableCollection<HamburgerMenuItemViewModel>();

            //BottomBarMenuItems.Add(item2);

        }
    }


    public class HamburgerMenuItemViewModel : BindableBase
    {
        public string Header { get; set; }
        public object Type { get; set; }
        public bool IsSelected { get => GetValue<bool>(); set => SetValue(value); }
        public ImageSource Glygh { get; set; }
        public Brush Background { get; set; }
        public Brush Foreground { get; set; }

        public HamburgerMenuItemViewModel(string header, object type, string glyghPath, Color background, Color foreground)
        {
            Header = header;
            Type = type;
            if(glyghPath != null)
                Glygh = WpfSvgRenderer.CreateImageSource(DXImageHelper.GetImageUri(glyghPath));
            Background = background.ToSolidColorBrush();
            Foreground = foreground.ToSolidColorBrush();
        }
    }
}
