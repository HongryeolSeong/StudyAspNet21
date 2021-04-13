using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateMngWebApp
{
    public partial class FrmStateMng : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                TxtApplication.Text = $"{Application["Now"]}";
                TxtSession.Text = Session["Now"].ToString();

                // 저장된 캐시, 쿠키, 뷰상태가 있다면 출력
                if (Cache["Now"] != null)
                    TxtCache.Text = Cache["Now"].ToString();

                if (Request.Cookies["Now"] != null)
                    TxtCookies.Text = Server.UrlDecode(Request.Cookies["Now"].Value);

                if (ViewState["Now"] != null)
                    TxtViewState.Text = ViewState["Now"].ToString();
            }
        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            // 각각의 상태 변수에 데이터 저장
            Application["Now"] = TxtApplication.Text;
            Session["Now"] = TxtSession.Text;
            Cache["Now"] = TxtCache.Text;
            Response.Cookies["Now"].Value = Server.UrlEncode(TxtCookies.Text);
            ViewState["Now"] = TxtViewState.Text;
            Response.Redirect("FrmStateShow.aspx");
        }
    }
}