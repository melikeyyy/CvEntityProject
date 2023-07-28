﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProject
{
    public partial class YetenekGuncelle : System.Web.UI.Page
    {
        DBENTITYEntities db = new DBENTITYEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = int.Parse(Request.QueryString["ID"]);
            if (Page.IsPostBack==false)
            {
                var deger = db.TBLYETENEKLER.Find(x);
                TextBox1.Text = deger.Yetenek;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(Request.QueryString["ID"]);
            var deger = db.TBLYETENEKLER.Find(x);
            deger.Yetenek = TextBox1.Text;
            db.SaveChanges();
            Response.Redirect("Yetenekler.Aspx");
        }
    }
}