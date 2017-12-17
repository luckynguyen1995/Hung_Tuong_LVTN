using DevExpress.Xpf.Docking;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public UCNVList a;
        public UCNV b ;
        public UCBatDongSan c;
        public UCHDKyGui d;
        public UCHDChuyenNhuong cn;
        //DocumentPanel panel = new DocumentPanel();
        //Frame fr = new Frame();
        public MainWindow()
        {
            InitializeComponent();
            a = new UCNVList();
            usnv.Content = a;
            biNV.IsEnabled = false;
            nbiDetail.IsEnabled = true;
            
        }
        private void biNV_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            isclick();
            biNV.IsEnabled = false;
            nbiList.IsEnabled = true;
            
            b = new UCNV();
            usnv.Content = b;
        }

        private void biKH_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            isclick();
            biKH.IsEnabled = false;
            UCKH uskh = new UCKH();
            usnv.Content = uskh;
            doc.DockController.Hide(lpmenu);
        }

        private void nbiDetail_Click(object sender, System.EventArgs e)
        {
            
            b = new UCNV();
            usnv.Content = b;
            biNV.IsEnabled = false;
            nbiDetail.IsEnabled = false;
            nbiList.IsEnabled = true;
        }

        private void nbiList_Click(object sender, System.EventArgs e)
        {
            UCNVList a = new UCNVList();
            usnv.Content = a;
            nbiList.IsEnabled = false;
            nbiDetail.IsEnabled = true;

        }


        private void biBDS_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            isclick();
            biBDS.IsEnabled = false;
            c = new UCBatDongSan();
            usnv.Content = c;
            //fr.Content = new BDSChiTiet();
            //panel.Caption = "Chi Tiết BĐS";
            //panel.AllowClose = false;
            //panel.Content = fr;
           
            doc.DockController.Hide(lpmenu);
        }

        private void biHDDC_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            isclick();
            biHDDC.IsEnabled = false;
            frmThemHDDC a = new frmThemHDDC();
            a.Show();
        }

        private void biKG_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            isclick();
            d = new UCHDKyGui();
            usnv.Content = d;
            biKG.IsEnabled = false;
        }
        public void isclick()
        {
            biNV.IsEnabled = true;
            biBDS.IsEnabled = true;
            biKH.IsEnabled = true;
            biKG.IsEnabled = true;
            biHDDC.IsEnabled = true;
            biHDCN.IsEnabled = true;
            nbiList.IsEnabled = false;
            nbiDetail.IsEnabled = false;
        }

        private void biHDCN_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            isclick();
            biHDCN.IsEnabled = false;
            cn= new UCHDChuyenNhuong();
            usnv.Content = cn;

        }
    }
}
