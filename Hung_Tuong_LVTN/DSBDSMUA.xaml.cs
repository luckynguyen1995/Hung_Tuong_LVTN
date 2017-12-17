using Hung_Tuong_LVTN.Model;
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
    /// Interaction logic for DSBDSMUA.xaml
    /// </summary>
    public partial class DSBDSMUA : Window
    {
        private BDSModelView bds = new BDSModelView();
        databaseDataContext dc = new databaseDataContext();
        public DSBDSMUA()
        {
            InitializeComponent();
            List<BatDongSan> lst = bds.getbds();
            grid.ItemsSource = lst;

        }

        private void grid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
           
            this.Close();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            BatDongSan a = grid.SelectedItem as BatDongSan;
            var window = Application.Current.Windows.OfType<frmThemHDCN>().SingleOrDefault(w => w.IsActive);
            var window1 = Application.Current.Windows.OfType<frmThemHDDC>().SingleOrDefault(w => w.IsActive);
            if (window != null)
            {
                for (int i = 0; i < dc.BatDongSans.Where(x=>x.tinhtrang==1).Count(); i++)
                {
                    if (dc.BatDongSans.Where(x=>x.tinhtrang==1).ToList()[i].bdsid == a.bdsid)
                    {
                        window.cboBDS.SelectedIndex = i;
                        break;
                    }
                }
            }
            if (window1 != null)
            {
                window1.stringbdsid = a.bdsid.ToString();
                window1.load();
            }
        }
    }
}
