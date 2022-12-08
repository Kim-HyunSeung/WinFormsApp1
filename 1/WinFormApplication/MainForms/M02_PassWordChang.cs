using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForms
{
         /*------------------------------------------------------
          * NAME    : M02_PassWordChang
          * DESC    : 비밀번호 변경.
          *------------------------------------------------------
          * DATE    : 2022-12-08
          * AUTHOR  : 박성진
          * DESC    : 최초 프로그램 작성
          -------------------------------------------------------*/
    public partial class M02_PassWordChang : Form
    {
        SqlConnection Connect;
        public M02_PassWordChang()
        {
            InitializeComponent();
        }
        
        private void btnPWChang_Click(object sender, EventArgs e)
        {
            // 비밀번호 변경 버튼 클릭
            try
            {
                /* 밸리데이션 체크
                    
                    응용 프로그램 실행시 발생 할 수 있는 예외상황을
                    미리 인지하여 예외상황 발샐 경우를 사용자에게
                    전달하는 로직을 구현해 둠으로서
                    시스템 오류를 막고 프로그램의 신뢰도를 높여주는
                    프로그래밍 구현 개발 방법.
                
                 */


                // 텍스트 박스에 정보 입력 여부 확인.
                string sMessage = string.Empty;
                if (txtUserID.Text == "") sMessage = "사용자 ID";
                else if(txtPerPW.Text == "") sMessage = "이전 비밀번호";
                else if (txtChangPW.Text == "") sMessage = "변경 비밀번호";
                if(sMessage != "")
                {
                    MessageBox.Show(sMessage + "을 입력하지 않았습니다.");
                    return;
                }


                // 1. 데이터 베이스 오픈
                // 
                string sConn = "Data Source = (local) ;Initial Catalog = AppDev;Integrated Security = SSPI;";
                Connect = new SqlConnection(sConn);
                Connect.Open();

                // 텍스트에 넣은 값들을 변수에 넣어줌.

                string sUserld   = txtUserID.Text;
                string sPassWord = txtPerPW.Text;
                string sChangPW  = txtChangPW.Text;

                string sFindUserImfo = $"SELECT USERID,PW FROM TB_USER WHERE USERID = '{sUserld}' AND PW ='{sPassWord}'; ";
                SqlDataAdapter adapter = new SqlDataAdapter(sFindUserImfo, Connect);

                DataTable dtTemp = new DataTable();
                adapter.Fill(dtTemp);
                string sPw = dtTemp.Rows[0]["PW"].ToString();
                // 2. 사용자 ID 와 PW 가 일치하는지 확인.

                if (dtTemp.Rows.Count == 0)
                {
                    MessageBox.Show("로그인 ID 또는 PW 가 잘못 되었습니다.");
                    return;
                }            
                // 3. 일치한다면 비밀번호 변경.
              else if(sPw == sPassWord)
                {
                    sPw = sPassWord;
                    Update();

                }
                // 4. 데이터베이스 닫기.
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                
            }
        }
    }
}
