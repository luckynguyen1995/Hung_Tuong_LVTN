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
    /// Interaction logic for frmThemHDCN.xaml
    /// </summary>
    public partial class frmThemHDCN : Window
    {
        databaseDataContext dc = new databaseDataContext();
        public frmThemHDCN()
        {
            InitializeComponent();
            cboKH1.SelectedValuePath = "khid";
            cboKH2.SelectedValuePath = "khid";
            reset();
        }

        private void cboKH2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cboKH2.SelectedIndex == -1)
            {
                reset();
                return;
            }
            if (cboKH1.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn khách hàng bên chuyển nhượng !");
                cboKH2.SelectedIndex = -1;
                return;
            }


            KhachHang a = tim(int.Parse(cboKH2.SelectedValue.ToString()));
            if(kiemtra(int.Parse(cboKH1.SelectedValue.ToString()), int.Parse(cboKH2.SelectedValue.ToString())))
            {
                MessageBox.Show("Bên nhận và bên chuyển phải khác nhau !");
                cboKH2.SelectedIndex =-1;
                cboKH1.SelectedIndex = -1;
                return;
            }
            
            lblHoten1.Content = a.hoten;
            lblNgaySinh1.Content = a.ngaysinh.Value;
            lblCmnd1.Content = a.cmnd;
            lblDiaChi1.Content = a.diachi;
            lblThuongTru1.Content = a.diachitt;
        }

        private void cboKH1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (cboKH1.SelectedIndex == -1)
            {
                reset();
                return;
            }
            if (cboKH2.SelectedIndex != -1)
            {
                if (kiemtra(int.Parse(cboKH1.SelectedValue.ToString()), int.Parse(cboKH2.SelectedValue.ToString())))
                {
                    MessageBox.Show("Bên nhận và bên chuyển phải khác nhau !");
                    cboKH1.SelectedIndex = -1;
                    cboKH2.SelectedIndex = -1;
                    return;
                }
            }
            
            KhachHang a = tim(int.Parse(cboKH1.SelectedValue.ToString()));
            lblHoten.Content = a.hoten;
            lblNgaySinh.Content = a.ngaysinh.Value;
            lblCmnd.Content = a.cmnd;
            lblDiaChi.Content = a.diachi;
            lblThuongTru.Content = a.diachitt;
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
            lblHoten.Content = "";
            lblNgaySinh.Content = "";
            lblCmnd.Content = "";
            lblDiaChi.Content = "";
            lblThuongTru.Content = "";
        }

        private void btnTim1_Click(object sender, RoutedEventArgs e)
        {
            DSKHMUA ds = new DSKHMUA();
            ds.Show();
        }
    }
}
