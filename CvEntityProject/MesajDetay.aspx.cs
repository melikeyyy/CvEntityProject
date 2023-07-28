using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProject
{
    public partial class MesajDetay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DBENTITYEntities db = new DBENTITYEntities();
            int x = int.Parse(Request.QueryString["ID"]);
            var mesaj = db.TBLILETISIM.Find(x);
            TxtAdSoyad.Text = mesaj.AdSoyad;
            TxtMail.Text = mesaj.Mail;
            TxtKonu.Text = mesaj.Konu;
            TxtMesaj.Text = mesaj.Mesaj;
            
        }
    }
}