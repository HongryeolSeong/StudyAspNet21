using System;
using System.Configuration;
using System.Data.SqlClient;

namespace DbHandlingWebApp
{
    public partial class FrmDbConn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnConn_Click(object sender, EventArgs e)
        {
            var connString = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                if (conn.State == System.Data.ConnectionState.Closed) conn.Open();

                //LblResult.Text = conn.State.ToString(); // 상태확인

                var query = @"Insert Memos 
                              Values
                                (	
	                                '성홍렬', 'ghd0276@naver.com', '성홍렬입니다.'
	                                , GetDate(), '127.0.0.1'
                                )";

                /*var query = @"UPDATE [TestDB].[dbo].[Memos]
                               SET Email = 'ghd0276@naver.com'
                             WHERE Num = '2'";*/

                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();

                    LblResult.Text = "데이터 저장 완료";
                }
                catch (Exception ex)
                {
                    LblResult.Text = $"오류 {ex}";
                }
                
            }
        }
    }
}