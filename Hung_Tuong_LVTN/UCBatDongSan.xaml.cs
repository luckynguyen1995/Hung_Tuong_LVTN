using DevExpress.Xpf.Docking;
using Hung_Tuong_LVTN.Model;
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
    /// Interaction logic for UCBatDongSan.xaml
    /// </summary>
    public partial class UCBatDongSan : UserControl
    {
        databaseDataContext dc = new databaseDataContext();
        SuaBDS eBDS;
        public UCBatDongSan()
        {
            InitializeComponent();
        }
        private void grid_SelectionChanged(object sender, DevExpress.Xpf.Grid.GridSelectionChangedEventArgs e)
        {

        }


       

        private void mnXem_Click(object sender, RoutedEventArgs e)
        {
            BDSView card = grid.SelectedItem as BDSView;
            if (card == null) return;
            frmGallery gallery = new frmGallery();
            gallery.loadData(card.bdsid);
            gallery.Show();
        }

        private void mnSua_Click(object sender, RoutedEventArgs e)
        {
            BDSView card = grid.SelectedItem as BDSView;
            if (card == null) return;
            eBDS = new SuaBDS();
            eBDS.setBDS(card.bdsid);
            eBDS.Show();
        }
        public int vitri(int id)
        {
            int i=0;
            foreach (BatDongSan bds in dc.BatDongSans)
            {
                if (id == bds.bdsid)
                {
                    return i;
                }i++;
            }
            return i;
        }
        private void mnChiTiet_Click(object sender, RoutedEventArgs e)
        {
            BDSView card = grid.SelectedItem as BDSView;
            if (card == null) return;
            int x = vitri(card.bdsid);
           
                var window = Application.Current.Windows.OfType<MainWindow>().SingleOrDefault(w => w.IsActive);
                DocumentPanel panel = new DocumentPanel();
                Frame fr = new Frame();
            BDSChiTiet chitiet= new BDSChiTiet();
            chitiet.show(x);
                fr.Content = chitiet;
                panel.Caption ="BDSID: "+ card.bdsid;
                panel.Content = fr;
                window.docGroup.Items.Add(panel);
           
        }

       

        private void mnChiTietAll_Click(object sender, RoutedEventArgs e)
        {
            var window = Application.Current.Windows.OfType<MainWindow>().SingleOrDefault(w => w.IsActive);
            DocumentPanel panel = new DocumentPanel();
            Frame fr = new Frame();
            BDSChiTiet chitiet = new BDSChiTiet();
            fr.Content = chitiet;
            panel.Caption = "Chi Tiết BĐS";
            panel.Content = fr;
            window.docGroup.Items.Add(panel);
        }

        private void mnRefresh_Click(object sender, RoutedEventArgs e)
        {
            grid.ItemsSource = new BDSModelView().DSBDS;
        }
    }
}
