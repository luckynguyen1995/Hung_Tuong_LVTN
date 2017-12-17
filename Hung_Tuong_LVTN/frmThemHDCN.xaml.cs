using System;
using System.Collections.Generic;
using System.Globalization;
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
    /// Interaction logic for frmThemHDCN.xaml
    /// </summary>
    public partial class frmThemHDCN : Window
    {
        databaseDataContext dc = new databaseDataContext();
        BatDongSan r=new BatDongSan();
        HDDatCoc a;
        public frmThemHDCN()
        {
            InitializeComponent();
            cboBDS.ItemsSource = dc.BatDongSans.Where(x => x.tinhtrang == 1).ToList() ;
            cboKH2.SelectedValuePath = "khid";
            cboBDS.SelectedValuePath = "bdsid";
            reset();
        }

        private void cboKH2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cboKH2.SelectedIndex == -1)
            {
                reset();
                return;
            }
            KhachHang a = tim(int.Parse(cboKH2.SelectedValue.ToString()));
            if (a.khid == r.khid)
            {
                MessageBox.Show("Bên Chuyển Nhượng phải khác bên Nhận !");
                cboKH2.SelectedIndex = -1;
                return;
            }
            lblHoten1.Content = a.hoten;
            lblNgaySinh1.Content = a.ngaysinh.Value.ToShortDateString();
            lblCmnd1.Content = a.cmnd;
            lblDiaChi1.Content = a.diachi;
            lblThuongTru1.Content = a.diachitt;
        }

        
        public KhachHang tim(int id)
        {
            foreach(KhachHang i in dc.KhachHangs.Where(x=>x.khid==id))
            {
                if (i != null) return i;
            }
            return null; 
        }
        public bool kiemtra(int id1,int id2)
        {
            return id1 == id2 ? true : false;
        }
        public void reset()
        {
            lblHoten1.Content = "";
            lblNgaySinh1.Content = "";
            lblCmnd1.Content = "";
            lblDiaChi1.Content = "";
            lblThuongTru1.Content = "";
            //lblHoten.Content = "";
            //lblNgaySinh.Content = "";
            //lblCmnd.Content = "";
            //lblDiaChi.Content = "";
            //lblThuongTru.Content = "";
        }

        private void btnTim2_Click(object sender, RoutedEventArgs e)
        {
            DSKHMUA ds = new DSKHMUA();
            ds.Show();
        }

        private void cboBDS_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cboBDS.SelectedIndex == -1)
            {
                return;
            }
            foreach(BatDongSan bds in dc.BatDongSans.Where(x => x.bdsid == int.Parse(cboBDS.SelectedValue.ToString())))
            {
                //if (bds.khid == int.Parse(cboKH2.SelectedValue.ToString()))
                //{
                   
                //    MessageBox.Show("Bên Chuyển Nhượng phải khác bên Nhận !");
                //    cboBDS.SelectedIndex = -1;
                //    return;
                //}
                r = bds;
                double value=double.Parse((bds.dongia * bds.dientich).ToString());
                lblDientich.Content = bds.dientich+ " m2";
                lblGiatri.Content = value.ToString("#,#", CultureInfo.InvariantCulture) + " VNĐ";
                lblViTri.Content = bds.sonha + ", " + bds.tenduong + ", P." + bds.phuong + ", Q." + bds.quan + ", TP." + bds.thanhpho;
                lblLoai.Content = bds.LoaiBD.tenloai;
                lblHoten.Content = bds.KhachHang.hoten;
                lblNgaySinh.Content = bds.KhachHang.ngaysinh.Value.ToShortDateString();
                lblThuongTru.Content = bds.KhachHang.diachitt;
                lblDiaChi.Content = bds.KhachHang.diachi;
                lblCmnd.Content = bds.KhachHang.cmnd;
                foreach(HDDatCoc datcoc in dc.HDDatCocs.Where(x => x.bdsid == bds.bdsid))
                {
                    a = datcoc;
                    lblNgaylap.Content = datcoc.ngaylaphd.Value.ToShortDateString();
                    lblSotien.Content = datcoc.giatri;
                    lblNgayhethan.Content = datcoc.ngayhethan.Value.ToShortDateString();
                    
                }
            }
        }

        private void btnThemKH_Click(object sender, RoutedEventArgs e)
        {
            frmThemKH them = new frmThemKH();
            them.Show();
        }

        private void btnTim_Click(object sender, RoutedEventArgs e)
        {
            DSBDSMUA bds = new DSBDSMUA();
            bds.Show();
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                HDChuyenNhuong hdcn = new HDChuyenNhuong();
                if (a != null)
                {
                    hdcn.HDDatCoc = dc.HDDatCocs.Single(x => x.dcid == a.dcid);
                }
                if (cboKH2.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin !");
                    return;
                }
                hdcn.KhachHang = dc.KhachHangs.Single(x => x.khid == int.Parse(cboKH2.SelectedValue.ToString()));
                hdcn.giatri = r.dientich * r.dongia;
                hdcn.ngaylap = DateTime.Now.Date;
                hdcn.BatDongSan = dc.BatDongSans.Single(x => x.bdsid == r.bdsid);
                foreach(BatDongSan i in dc.BatDongSans.Where(x => x.bdsid == r.bdsid))
                {
                    i.tinhtrang = 4;
                }
                dc.HDChuyenNhuongs.InsertOnSubmit(hdcn);
                dc.SubmitChanges();
                MessageBox.Show("Lập hợp đồng thành công !");
            }
            catch (Exception)
            {
                MessageBox.Show("Lập hợp đồng thất bại !");
            }
        }

        private void btnthoat_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            var window = Application.Current.Windows.OfType<MainWindow>().SingleOrDefault(w => w.IsActive);
            window.usnv.Content = new UCHDChuyenNhuong();
        }
    }
}
