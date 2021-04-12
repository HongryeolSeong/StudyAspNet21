using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWepApp
{
    public partial class FrmControls : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LsbHobby.Items.Add("농구");
            LsbHobby.Items.Add("배구");
            LsbHobby.Items.Add("오래달리기");

            CboPhoneNum.Items.Add("010-7759-0276");

            if (!Page.IsPostBack)
            {
                CtlHidden.Value = DateTime.Now.ToShortTimeString();
            }
        }

        protected void BtnChange_Click(object sender, EventArgs e)
        {
            ImgChange.ImageUrl = "~/images/ASP-NET-Banners-02.png";
        }

        protected void BtnOk_Click(object sender, EventArgs e)
        {
            Response.Write(CtlHidden.Value);
        }
    }
}