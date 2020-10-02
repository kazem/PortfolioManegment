using DevExpress.Xpf.WindowsUI;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;

namespace ProfitManagment_WPF
{
    /// <summary>
    /// Interaction logic for DailyPerfit.xaml
    /// </summary>
    public partial class DailyPerfit : UserControl
    {
        public DailyPerfit()
        {                        
            InitializeComponent();

            string path = Directory.GetCurrentDirectory();
            string xmlFileName = @"\dashboard1.xml";
            string xlsxFileName = @"\inputDashboard.xlsx";            
            if (!System.IO.File.Exists(path + xmlFileName) || !System.IO.File.Exists(path + xlsxFileName))
            {
                WinUIMessageBox.Show("گزارشی جهت نمایش وجود ندارد.", "خطا", MessageBoxButton.OK, MessageBoxImage.Error);

            }
            else
            {                
                DashboardCTRL.DashboardSource = path + xmlFileName;
            }
                


        }

    }
}
