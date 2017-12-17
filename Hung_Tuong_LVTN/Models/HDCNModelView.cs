using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hung_Tuong_LVTN.Models
{
    class HDCNModelView
    {
        public IEnumerable<object> DSHDCN { get; set; }
        public IEnumerable<object> DSHDCNView { get; set; }
        public IEnumerable<object> DSKhachHang { get; set; }
        public IEnumerable<object> DSBDS { get; set; }
        public databaseDataContext dc = new databaseDataContext();
        public HDCNModelView()
        {
            this.DSHDCN = dc.HDChuyenNhuongs.ToList();
            this.DSKhachHang = dc.KhachHangs.ToList();
            this.DSBDS = dc.BatDongSans.ToList();
            this.DSHDCNView = getHDCNView();
        }
        public IEnumerable<object> getHDCNView()
        {

            return dc.HDChuyenNhuongs.Select(x => new HDCNView
            {
                cnid = x.cnid,
                dcid = x.dcid==null?null:x.dcid.ToString(),
                hoten = x.KhachHang.hoten,
               giatri=x.giatri.Value.ToString("#,#", CultureInfo.InvariantCulture),
               ngaylap=x.ngaylap.Value.ToShortDateString(),
               
            }).ToList();
        }
    }
    public class HDCNView
    {
        public int cnid { get; set; }
        public string dcid { get; set; }
        public string hoten { get; set; }
        public string giatri { get; set; }
        public string ngaylap { get; set; }

    }
}
