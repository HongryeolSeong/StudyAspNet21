using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateMngWebApp
{
    public partial class FrmStateShow : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TxtApplication.Text = $"{Application["Now"]}";
            TxtSession.Text = Session["Now"].ToString();

            // 저장된 캐시, 쿠키, 뷰상태가 있다면 출력
            if (Cache["Now"] != null)
                TxtCache.Text = Cache["Now"].ToString();

            if (Request.Cookies["UserID"] != null)
                TxtCookies.Text = Server.UrlDecode(Request.Cookies["UserID"].Value);

            if (ViewState["Now"] != null)
                TxtViewState.Text = ViewState["Now"].ToString();

            LblSiteName.Text = WebConfigurationManager.AppSettings["SITE_NAME"].ToString();
            LblConnectinoString.Text = WebConfigurationManager.ConnectionStrings["Local_Connstring"].ConnectionString;
        }
    }
}