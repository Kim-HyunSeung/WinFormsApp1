using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//SQL Sever 접속 클래스 라이브러리
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// WinFormApplication 강의의 목표.
// C# .NetFreamWork WinForm 의 기본 도구 와 프로그래밍 문법을 사용하여 
// 데이터 베이스 와 유기적으로 연결 되는 
// 개발 솔루션의 프레임을 만들어 보고 
// 시스템 개발 프레임 코어 소스의 구성 원리를 이해 및 기능을 습득 한다.


/*------------------------------------------------------
 * NAME    : M01_Login
 * DESC    : 시스템 로그인.
 *------------------------------------------------------
 * DATE    : 2022-12-08
 * AUTHOR  : 박성진
 * DESC    : 최초 프로그램 작성
 -------------------------------------------------------*/
namespace MainForms
{
    
    public partial class M01_LogIn : Form
    {
        #region <필드 멤버>
        int PWCnt = 0; // 비밀번호 오기입 횟수.
        int a = 0;
        SqlConnection Connect;
        #endregion
        public M01_LogIn()
        {
            InitializeComponent();
        }

        #region <METHOD>
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            DoLogin();
        }
        private void DoLogin()
        {
            //try
            //{  // 데이터 베이스에 접속 할 경로.
            //    string sConn = "Data Source = (local) ;Initial Catalog = AppDev;Integrated Security = SSPI;";

            //   // 데이터 베이스 접속.
            //   SqlConnection Connect = new SqlConnection(sConn);
            //   Connect.Open();

            //   // ID/ PW 를 데이터 베이스에서 가져와서 비교 로직.
            //   string sUserld = txtUseID.Text;
            //   string sPassWord = txtPassWord.Text;

            //    // ID 와 PW 를 정확하게 입력 하였는지 확인.
            //    string sFindUserImfo = $"SELECT USERID,PW FROM TB_USER WHERE USERID = '{sUserld}' AND PW ='{sPassWord}'; ";

            //    // SqlDataAdapter : 데이터베이스 연결 후 SELECT SQL 구문 전달 및 결과를
            //    //                  응용프로그램에 받아 오는 기능 클래스.
            //    SqlDataAdapter adapter = new SqlDataAdapter(sFindUserImfo, Connect);

            //    //DataTable : 프로그래밍 언어에서 데이터를 테이블 형태로 관리하는 클래스
            //    DataTable dtTemp = new DataTable();

            //    adapter.Fill(dtTemp);



            //    // ID 와 PW를 정확히 입력하지 않은 경우
            //    //Aif(dtTemp.Rows.Count == 0)
            //    //{
            //    //    MessageBox.Show("로그인 ID 또는 PW 가 잘못 되었습니다.");
            //    //    return;
            //    //}

            //    // 로그인을 성공하였을 경우 로직.
            //    string sPw = dtTemp.Rows[0]["PW"].ToString();
            //    string sId = dtTemp.Rows[0]["USEID"].ToString();


            //    if (sUserld != sId)
            //    {
            //        MessageBox.Show("ID 가 잘못 되었습니다.");
            //        return;
            //    }
            //    if (sUserld == sId || sPassWord != sPw)
            //    {
            //        MessageBox.Show("PW 가 잘못 되었습니다.");
            //        return;
            //    }




            //}
            //catch(Exception ex) 
            //{

            //}
            //finally 
            //{ 

            //}

            //try
            //{  // 데이터 베이스에 접속 할 경로.
            //    string sConn = "Data Source = (local) ;Initial Catalog = AppDev;Integrated Security = SSPI;";

            //   // 데이터 베이스 접속.
            //   SqlConnection Connect = new SqlConnection(sConn);
            //   Connect.Open();

            //   // ID/ PW 를 데이터 베이스에서 가져와서 비교 로직.
            //   string sUserld = txtUseID.Text;
            //   string sPassWord = txtPassWord.Text;

            //    // ID 와 PW 를 정확하게 입력 하였는지 확인.
            //    string sFindUserImfo = $"SELECT USERID,PW FROM TB_USER WHERE USERID = '{sUserld}' AND PW ='{sPassWord}'; ";

            //    // SqlDataAdapter : 데이터베이스 연결 후 SELECT SQL 구문 전달 및 결과를
            //    //                  응용프로그램에 받아 오는 기능 클래스.
            //    SqlDataAdapter adapter = new SqlDataAdapter(sFindUserImfo, Connect);

            //    //DataTable : 프로그래밍 언어에서 데이터를 테이블 형태로 관리하는 클래스
            //    DataTable dtTemp = new DataTable();

            //    adapter.Fill(dtTemp);



            //    // ID 와 PW를 정확히 입력하지 않은 경우
            //    //if(dtTemp.Rows.Count == 0)
            //    //{
            //    //    MessageBox.Show("로그인 ID 또는 PW 가 잘못 되었습니다.");
            //    //    return;
            //    //}

            //    // 로그인을 성공하였을 경우 로직.
            //    string sPw = dtTemp.Rows[0]["PW"].ToString();
            //    string sId = dtTemp.Rows[0]["USEID"].ToString();


            //    if (sUserld != sId)
            //    {
            //        MessageBox.Show("ID 가 잘못 되었습니다.");
            //        return;
            //    }
            //    if (sUserld == sId || sPassWord != sPw)
            //    {
            //        MessageBox.Show("PW 가 잘못 되었습니다.");
            //        return;
            //    }




            //}
            //catch(Exception ex) 
            //{

            //}
            //finally 
            //{ 

            //}
         
            
            
            
            try
            {
                // 데이터 베이스에 접속 할 경로.
                string sConn = "Data Source =(local); Initial Catalog  = AppDev; Integrated Security = SSPI;";

                // 데이터 베이스 접속 객체 생성.
                Connect = new SqlConnection(sConn);

                // 데이터 베이스 오픈 명령
                Connect.Open();

                // ID / PW 를 데이터 베이스에서 가자와서 비교 로직. 
                string sUserId   = txtUseID.Text;
                string sPassWord = txtPassWord.Text;

                #region < ID 와 PW 가 동시에 일치 하는지 를 비교하는 경우 >
                //// ID 와 PW 를 정확하게 입력 하였는지 확인.
                //string sFindUserImfo = $"SELECT USERID,PW FROM TB_USER WHERE USERID = '{sUserId}' AND PW = '{sPassWord}';  ";

                //// SqlDataAdapter : 데이터베이스 연결 후 SELECT SQL 구문 전달 및 결과를 
                ////                  응용프로그램에 받아오는 기능 클래스.
                //SqlDataAdapter adapter= new SqlDataAdapter(sFindUserImfo, Connect);

                //// DataTable : 프로그래밍 언어에서 데이터를 테이블 형태로 관리하는 클래스.
                //DataTable dtTemp = new DataTable();

                //adapter.Fill(dtTemp);


                //// ID 와 PW 를 정확히 입력하지 않은 경우. 
                //if (dtTemp.Rows.Count == 0)
                //{
                //    MessageBox.Show("로그인 ID 또는 PW 가 잘못 되었습니다.");
                //    return;
                //}
                //// 로그인을 성공하였을 경우 로직.
                #endregion


                #region < ID 의 존재 여부에 따라 PW 의 일치 여부를 비교하는 경우 >
                //string sFindUserImfo = $"SELECT USERNAME,PW FROM TB_USER WHERE USERID = '{sUserId}';";
                //SqlDataAdapter adapter = new SqlDataAdapter(sFindUserImfo, sConn);

                //DataTable dtTemp = new DataTable(); 
                //adapter.Fill(dtTemp);

                ////ID를 잘 못 입력 한 경웅 받아온 결과의 행이 없다.
                //if(dtTemp.Rows.Count ==0)
                //{
                //    MessageBox.Show("존재 하지 않는 ID 입니다.");
                //    return;
                //}

                //// 존재 하는 id 를 입력하여 데이터 베이스에서 사용자 정보를 받아 왓을경우
                //else if (sPassWord != dtTemp.Rows[0]["PW"].ToString())
                //{
                //    MessageBox.Show("비밀번호를 잘못 입력 하였습니다.");
                //    return;
                //}

                #endregion

                #region<비밀번호 3회 이상 실패시 프로그램 종료>

                // UPDATE 구문을 사용 하지 않고 프로그램에서만 3회 실패 시 종료 하는 로직.
                // string sFindUserImfo = $"SELECT USERNAME, PW FROM TB_USER WHERE USERID = '{sUserId}';";

                // sqlDataAdapter adapter = new SqlDataAdapter(sFindUserImfo, sConn);

                // DataTable dtTemp = new DataTable(); 그릇생성
                //  adapter.Fill(dtTemp); 그릇에 담아라



                string sFindUserImfo = $"SELECT USERNAME,PW FROM TB_USER WHERE USERID = '{sUserId}';";
                // 문자열 변수안에 데이터베이스에서 사용하는 쿼리문으로 적고 where 조건에 userid에 텍스트id박스에
                // 작성하는 값을 입력을 받는거고
                SqlDataAdapter adapter = new SqlDataAdapter(sFindUserImfo, sConn);
                //sql데이터 어댑터에 변수를 하나만들어 새로운 객체를만드는데 뒤에 뉴값 괄호안은 위변수와 뒤에 연결할
                //주소 변수를 넣음
                
                DataTable dtTemp = new DataTable(); 
                adapter.Fill(dtTemp); //여기는 데이터를 받는데 데이터를 받을 깡통을 만들어 데이터를 받는다.

               
                if (dtTemp.Rows.Count == 0)
                {
                   MessageBox.Show("ID 가 존재하지 않습니다.");
                   return;
                }

                else if(sPassWord != dtTemp.Rows[0]["PW"].ToString())
                {
                    PWCnt++;
                    if(PWCnt == 3)
                    {
                        MessageBox.Show("3회 비밀번호를 잘못입력하여 프로그램을 종료합니다.");
                        this.Close();
                    }
                    MessageBox.Show($" 비밀번호를 잘못 입력하셨습니다. 남은 횟수 : {3 - PWCnt} ");
                    return;                  
                               
                }

                #endregion
                // 로그인을 성공 하였을 경우 로직.
                PWCnt = 0;
                MessageBox.Show(dtTemp.Rows[0]["USERNAME"].ToString() + "님 반갑습니다. ");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                Connect.Close();
            }
        }


        private void txtPassWord_KeyDown(object sender, KeyEventArgs e)
        {      // 엔터키를 눌렸을 경우 로그인한다.
            if (e.KeyCode == Keys.Enter) DoLogin();  // e라는 키이벤트 변수에 키가 엔터를 눌렷을때 로그인을 실행하라.  
        }

        #endregion

        private void btnPWChang_Click(object sender, EventArgs e)
        {
            // 비밀번호 변경 창 호출.
            M02_PassWordChang M02 = new M02_PassWordChang(); //NEW는 객체화해서 M02에 담아라
           
            // 로그인 창 숨기기
            this.Visible= false;

            // show는 동기식임. 병렬로 창을 다사용할수있음. ShowDialog 비동기식임 이창이 종료될때까지 이전창 사용 ㄴ
            M02.ShowDialog(); // 보여주긴하는데 이전 창 사용 안하게끔 만드는것.비동기식임.
            

            // 로그인 창 표시하기
            this.Visible= true;
           

        }
    }

}
