using System;
using System.Web.UI;

namespace FirstWepApp
{
    public partial class FrmResponseWrite : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("안녕하세요.<br />");
        }

        protected void BtnMsg_Click(object sender, EventArgs e)
        {
            Response.Write("<p span style='color:blue'>반갑습니다<p/>");
        }

        protected void BtnJs_Click(object sender, EventArgs e)
        {
            // javaScript
            string strScript = @"<script Language='javascript'>
                                  window.alert('안녕하세요!');
                                 </script>";
            Response.Write(strScript);
        }

        protected void BtnLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://www.naver.com");
        }
    }
}