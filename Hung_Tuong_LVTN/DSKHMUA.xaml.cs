using System;
using System.Collections.Generic;
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

namespace Hung_Tuong_LVTN
{
    /// <summary>
    /// Interaction logic for DSKHMUA.xaml
    /// </summary>
    public partial class DSKHMUA : Window
    {
        databaseDataContext dc = new databaseDataContext();
        public DSKHMUA()
        {
            InitializeComponent();

        }



        private void grid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            
            //KhachHang a = grid.SelectedItem as KhachHang;
            //frmThemHDDC.stringkhid = a.khid.ToString();
            //frmThemHDDC frm = new frmThemHDDC();
            //frm.Show();
            this.Close();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            KhachHang a = grid.SelectedItem as KhachHang;
            var window = Application.Current.Windows.OfType<frmThemHDCN>().SingleOrDefault(w => w.IsActive);
            var window1 = Application.Current.Windows.OfType<frmThemHDDC>().SingleOrDefault(w => w.IsActive);
            if (window != null)
            {
                for (int i = 0; i < dc.KhachHangs.Count(); i++)
                {
                    if (dc.KhachHangs.ToList()[i].khid == a.khid)
                    {
                        window.cboKH1.SelectedIndex = i;
                        break;
                    }
                }
            }
            if (window1 != null)
            {
                window1.stringkhid = a.khid.ToString();
                window1.load();
            }
        }
    }
}
