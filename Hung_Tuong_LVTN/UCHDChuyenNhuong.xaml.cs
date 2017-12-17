using DevExpress.Xpf.Docking;
using Hung_Tuong_LVTN.Models;
using Hung_Tuong_LVTN.Page;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Hung_Tuong_LVTN
{
    /// <summary>
    /// Interaction logic for UCHDChuyenNhuong.xaml
    /// </summary>
    public partial class UCHDChuyenNhuong : UserControl
    {
        databaseDataContext dc = new databaseDataContext();
        public UCHDChuyenNhuong()
        {
            InitializeComponent();
        }

        private void mnThem_Click(object sender, RoutedEventArgs e)
        {
            frmThemHDCN them = new frmThemHDCN();
            them.Show();
        }

        private void mnXoa_Click(object sender, RoutedEventArgs e)
        {
            
            MessageBoxResult result = MessageBox.Show("Bạn có đồng ý xóa hợp đồng này ?", "Thông Báo", MessageBoxButton.YesNo);
            switch (result)
            {
                case MessageBoxResult.Yes:

                    HDCNView hdcn = grid.SelectedItem as HDCNView;
                    if (hdcn == null) MessageBox.Show("Không tồn tại hợp đồng!!");
                    foreach (HDChuyenNhuong a in dc.HDChuyenNhuongs.Where(x => x.cnid == hdcn.cnid))
                    {
                        dc.HDChuyenNhuongs.DeleteOnSubmit(a);
                        dc.SubmitChanges();
                        MessageBox.Show("Xóa hợp đồng thành công !");
                        grid.ItemsSource = new HDCNModelView().DSHDCNView;
                        

                    }
                    break;
                case MessageBoxResult.No:

                    break;
            }
        }

        private void mnBDS_Click(object sender, RoutedEventArgs e)
        {
            HDCNView hdcn = grid.SelectedItem as HDCNView;
            HDChuyenNhuong m = new HDChuyenNhuong();
            if (hdcn == null) return;
            foreach (HDChuyenNhuong a in dc.HDChuyenNhuongs.Where(x => x.cnid == hdcn.cnid))
            {
                m = a;
            }
            int q = vitri(m.bdsid.Value);

            var window = Application.Current.Windows.OfType<MainWindow>().SingleOrDefault(w => w.IsActive);
            DocumentPanel panel = new DocumentPanel();
            Frame fr = new Frame();
            BDSChiTiet chitiet = new BDSChiTiet();
            chitiet.show(q);
            fr.Content = chitiet;
            panel.Caption = "BDSID: " + m.bdsid.Value;
            panel.Content = fr;
            window.docGroup.Items.Add(panel);
        }
        public int vitri(int id)
        {
            int i = 0;
            foreach (BatDongSan bds in dc.BatDongSans)
            {
                if (id == bds.bdsid)
                {
                    return i;
                }
                i++;
            }
            return i;
        }
        private void biThem_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            frmThemHDCN them = new frmThemHDCN();
            them.Show();
        }

        private void bicn_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            grid.ItemsSource = new HDCNModelView().DSHDCNView;
        }

        private void bixoa_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Bạn có đồng ý xóa hợp đồng này ?", "Thông Báo", MessageBoxButton.YesNo);
            switch (result)
            {
                case MessageBoxResult.Yes:

                    HDCNView hdcn = grid.SelectedItem as HDCNView;
                    if (hdcn == null) MessageBox.Show("Không tồn tại hợp đồng!!");
                    foreach (HDChuyenNhuong a in dc.HDChuyenNhuongs.Where(x => x.cnid == hdcn.cnid))
                    {
                        dc.HDChuyenNhuongs.DeleteOnSubmit(a);
                        dc.SubmitChanges();
                        MessageBox.Show("Xóa hợp đồng thành công !");
                        grid.ItemsSource = new HDCNModelView().DSHDCNView;


                    }
                    break;
                case MessageBoxResult.No:

                    break;
            }
        }
    }
}
