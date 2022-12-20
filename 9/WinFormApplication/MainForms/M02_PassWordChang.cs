using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assamble;

namespace MainForms
{
         /*------------------------------------------------------
          * NAME    : M02_PassWordChang
          * DESC    : 비밀번호 변경.
          *------------------------------------------------------
          * DATE    : 2022-12-08
          * AUTHOR  : 김현승
          * DESC    : 최초 프로그램 작성
          -------------------------------------------------------*/
    public partial class M02_PassWordChang : Form
    {
        //******************************************************************************
        // SQL SERVER 와 연동하기 위해 필요한 클래스를 필드멤버로 지정함.
        //*******************************************************************************
        // 1. 공통 클래스 데이터베이스 접속 클래스.
        private SqlConnection sCon;

        // 2. 데이터베이스에 SELECT 를 실행하여 데이터를 받아오는 클래스
        private SqlDataAdapter sAdaprt;

        // 3. INSERT, UPDATE, DELETE 의 명령을 전달 할 클래스.
        private SqlTransaction sTran; // 데이터베이스 데이터 관리 권한 클래스(Commit, Rollbeck)
        private SqlCommand  sCmd;  // 데이터베이스 갱신 명령을 전달하는 클래스.



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


                // 0. 텍스트박스에 입력한 사용자 정보 와 변경 비밀번호 변수에 담기.
                string sUserID = txtUserID.Text;   // 사용자 ID
                string sPerPW  = txtPerPW.Text;    // 기존 비밀번호
                string sNewPW  = txtChangPW.Text;  // 변경 할 비밀번호


                // 1. 데이터 베이스 오픈

                // 데이터 베이스 주소 변수에 담기
                string strCon = Common.sConn;

                // 접속 경로를 데이터베이스 커넥터 객체에 전달.
                sCon = new SqlConnection(strCon);
                
                // DB OPEN
                sCon.Open();

                #region < 기존 비밀번호 와 비교하여 변경 가능한 상태인지 체크 >
                // 기존 사용자 ID 와 비밀번호가 일치하는지 찾아보는 SQL
                string sSelectSQL = "SELECT PW                    ";
                sSelectSQL       += " FROM TB_USER                ";
                sSelectSQL       += $" WHERE USERID = '{sUserID}' ";
                sSelectSQL       += $"   AND PW     = '{sPerPW}'  ";

                // Adapter 에 SQL 구문 과 접속 정보 등록
                sAdaprt = new SqlDataAdapter(sSelectSQL, sCon);

                // DB 로 부터 받아올 결과를 담는 자료형 변수.
                DataTable dtTemp = new DataTable();

                // SQL 실행 및 결과 받아오기.
                sAdaprt.Fill(dtTemp);

                // 받아온 결과로 로직 처리
                // 사용자 ID 와 PW 가 일치 하는지 확인.
                if(dtTemp.Rows.Count == 0)
                {
                    MessageBox.Show("사용자 ID 와 PW 가 일치하지 않습니다.");
                    return;
                }
                #endregion


                #region< 비밀번호 변경 로직 >
                // 3. 일치한다면 비밀번호 변경하는 로직.
                if (MessageBox.Show("비밀번호를 변경 하시겠습니까 ?", "비밀번호변경", MessageBoxButtons.YesNo) == DialogResult.No) return;
                //         메세지박스 표현     ,  메세지 박스 제목 , 메세지박스 버튼이뜨면서 YES OR NO 뜨고
                // NO버튼을 클릭하셨을때 리턴값을 반환함 Ctrl + Shift + B 를 눌리면 모든 프로젝트 빌드가됨.

                //1. SQL 구문 UPDATE, INSERT, DELETE (갱신) 명령 전달 클래스.
                sCmd = new SqlCommand();

                //2. 트랜잭션 사용 선언 (Commit, RollBack)
                sTran = sCon.BeginTransaction();

                // 3. 데이터베이스에 데이터 갱신 명령 전달 클래스 객체에 트랜잭션 등록.
                sCmd.Transaction = sTran;

                //4. 접속 정보 등록
                sCmd.Connection = sCon;

                //5. SQL 문 등록.
                string sUpdateSql = "UPDATE TB_USER                " ;
                sUpdateSql       += $"   SET PW       = '{sNewPW}' " ;
                sUpdateSql       += $"   WHERE USERID = '{sUserID}'" ;

                sCmd.CommandText = sUpdateSql;

                //6. Command 명령 실행
                sCmd.ExecuteNonQuery(); // 커맨드에 등록해라 외우자

                //7. 변경내역 승인 명령
                sTran.Commit();

                MessageBox.Show("비밀번호가 정상적으로 변경 되었습니다."); // 메

                this.Close();
                #endregion
            }

            catch (Exception ex)
            {
                // 트랜잭션 설정 하였을 경우에만 Rollback 하도록 분기문 적용.
                if(sTran != null) sTran.Rollback();
                MessageBox.Show(ex.ToString());
            }
            finally
            {              
                sCon.Close();
            }
        }
    }
}
