using DevExpress.Xpf.Docking;
using Hung_Tuong_LVTN.Model;
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
    /// Interaction logic for UCHDKyGui.xaml
    /// </summary>
    public partial class UCHDKyGui : UserControl
    {
        databaseDataContext dc = new databaseDataContext();
        public UCHDKyGui()
        {
            InitializeComponent();
        }
        private void TableView_RowUpdated(object sender, DevExpress.Xpf.Grid.RowEventArgs e)
        {
            try
            {
                HDKGView row = (HDKGView)grid.SelectedItem;
                if (row == null) return;
                grid.RefreshData();

                foreach (HopDongKyGui i in dc.HopDongKyGuis.Where(x => x.kgid == row.kgid))
                {
                    if (i != null)
                    {
                        i.BatDongSan = dc.BatDongSans.Single(x => x.bdsid == row.bdsid);
                        i.NhanVien = dc.NhanViens.Single(x => x.nvid == row.nvid);
                        i.KhachHang = dc.KhachHangs.Single(x => x.khid == row.khid);
                        i.ngaybatdau = row.ngaybatdau.Date;
                        if (row.ngayketthuc <= row.ngaybatdau)
                        {
                            MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc");
                            return;
                        }
                        i.ngayketthuc = row.ngayketthuc.Date;
                        i.chiphidv = row.chiphidv;
                        dc.SubmitChanges();
                        MessageBox.Show("Đã cập nhật thành công !");

                    }
                }
                grid.ItemsSource = new HDKGModelView().DSHDKG;
            }
            catch { return; }
        }

        private void biThem_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            frmThemHDKyGui hopdong = new frmThemHDKyGui();
            hopdong.Show();
        }

        private void bicn_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            var window = Application.Current.Windows.OfType<MainWindow>().SingleOrDefault(w => w.IsActive);
            window.usnv.Content = new UCHDKyGui();
            grid.ItemsSource = new HDKGModelView().DSHDKG;
        }

        private void bixoa_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Bạn có đồng ý xóa hợp đồng này ?", "Thông Báo", MessageBoxButton.YesNo);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    HDKGView a = grid.SelectedItem as HDKGView;
                    if (a == null)
                    {
                        MessageBox.Show("Không tồn tại hợp đồng!!");
                        return;
                    };
                    foreach (HopDongKyGui i in dc.HopDongKyGuis.Where(x => x.kgid == a.kgid))
                    {
                        if (i != null)
                        {
                            dc.HopDongKyGuis.DeleteOnSubmit(i);
                            dc.SubmitChanges();
                            MessageBox.Show("Xóa hợp đồng thành công !");
                            grid.ItemsSource = new HDKGModelView().DSHDKG;
                        }
                        else MessageBox.Show("Không thể xóa hợp đồng !!");
                    }
                    break;
                case MessageBoxResult.No:

                    break;
            }
        }

        private void TableView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Delete)
            {
                MessageBoxResult result = MessageBox.Show("Bạn có đồng ý xóa hợp đồng này ?", "Thông Báo", MessageBoxButton.YesNo);
                switch (result)
                {
                    case MessageBoxResult.Yes:
                        HDKGView a = grid.SelectedItem as HDKGView;
                        if (a == null)
                        {
                            MessageBox.Show("Không tồn tại hợp đồng!!");
                            return;
                        };
                        foreach (HopDongKyGui i in dc.HopDongKyGuis.Where(x => x.kgid == a.kgid))
                        {
                            if (i != null)
                            {
                                dc.HopDongKyGuis.DeleteOnSubmit(i);
                                dc.SubmitChanges();
                                MessageBox.Show("Xóa hợp đồng thành công !");
                                grid.ItemsSource = new HDKGModelView().DSHDKG;
                            }
                            else MessageBox.Show("Không thể xóa hợp đồng !!");
                        }
                        break;
                    case MessageBoxResult.No:

                        break;

                }

            }

        }

        private void TableView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
           
        }

        private void mnThem_Click(object sender, RoutedEventArgs e)
        {
            frmThemHDKyGui frmThem= new frmThemHDKyGui();
            frmThem.Show();
        }

        private void mnXoa_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Bạn có đồng ý xóa hợp đồng này ?", "Thông Báo", MessageBoxButton.YesNo);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    HDKGView a = grid.SelectedItem as HDKGView;
                    if (a == null)
                    {
                        MessageBox.Show("Không tồn tại hợp đồng!!");
                        return;
                    };
                    foreach (HopDongKyGui i in dc.HopDongKyGuis.Where(x => x.kgid == a.kgid))
                    {
                        if (i != null)
                        {
                            dc.HopDongKyGuis.DeleteOnSubmit(i);
                            dc.SubmitChanges();
                            MessageBox.Show("Xóa hợp đồng thành công !");
                            grid.ItemsSource = new HDKGModelView().DSHDKG;
                        }
                        else MessageBox.Show("Không thể xóa hợp đồng !!");
                    }
                    break;
                case MessageBoxResult.No:

                    break;
                }
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
        private void mnBDS_Click(object sender, RoutedEventArgs e)
        {
            HDKGView card = grid.SelectedItem as HDKGView;
            if (card == null) return;
            int x = vitri(card.bdsid);

            var window = Application.Current.Windows.OfType<MainWindow>().SingleOrDefault(w => w.IsActive);
            DocumentPanel panel = new DocumentPanel();
            Frame fr = new Frame();
            BDSChiTiet chitiet = new BDSChiTiet();
            chitiet.show(x);
            fr.Content = chitiet;
            panel.Caption = "BDSID: " + card.bdsid;
            panel.Content = fr;
            window.docGroup.Items.Add(panel);
        }
    }
}
