using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hung_Tuong_LVTN.Models
{
    class HDCNModelView
    {
        public IEnumerable<object> DSHDCN { get; set; }
        public IEnumerable<object> DSKhachHang { get; set; }
        public IEnumerable<object> DSBDS { get; set; }
        public databaseDataContext dc = new databaseDataContext();
        public HDCNModelView()
        {
            this.DSHDCN = dc.HDChuyenNhuongs.ToList();
            this.DSKhachHang = dc.KhachHangs.ToList();
            this.DSBDS = dc.BatDongSans.ToList();
        }
    }
    public class HDCNView
    {
        public int cnid { get; set; }
        public int dcid { get; set; }
        public int khid { get; set; }

        public double giatri { get; set; }
        public DateTime ngaylap { get; set; }

    }
}
