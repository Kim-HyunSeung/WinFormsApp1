using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assamble;

namespace Form_List
{
    public partial class Form04_userMaster : Form
    {
        public Form04_userMaster()
        {
            InitializeComponent();
        }
        // 현재 선택된 행의 index 찾기
    
        private void Form04_userMaster_Load(object sender, EventArgs e)
        {
            DataTable dtTemp = new DataTable();
            dtTemp.Columns.Add("USERID", typeof(string));
            dtTemp.Columns.Add("USERNAME", typeof(string));
            dtTemp.Columns.Add("PW", typeof(string));
            dtTemp.Columns.Add("PW_FCNT", typeof(string));
            dtTemp.Columns.Add("DEPTCODE", typeof(string));
            dtTemp.Columns.Add("MAKEDATE", typeof(string));
            dtTemp.Columns.Add("MAKER", typeof(string));
            dtTemp.Columns.Add("EDITDATE", typeof(string));
            dtTemp.Columns.Add("EDITOR", typeof(string));
            dgvGrid.DataSource = dtTemp;

            dgvGrid.Columns["USERID"].HeaderText = "사용자ID";
            dgvGrid.Columns["USERNAME"].HeaderText = "사용자명";
            dgvGrid.Columns["PW"].HeaderText = "비밀번호";
            dgvGrid.Columns["PW_FCNT"].HeaderText = " 실패횟수 ";
            dgvGrid.Columns["DEPTCODE"].HeaderText = "부서";
            dgvGrid.Columns["MAKEDATE"].HeaderText = "등록일시";
            dgvGrid.Columns["MAKER"].HeaderText = "등록자";
            dgvGrid.Columns["EDITDATE"].HeaderText = "수정일시";
            dgvGrid.Columns["EDITOR"].HeaderText = "수정자";
            
          


            SqlConnection Connect = new SqlConnection(Common.sConn);

            try
            {
                Connect.Open();


                string sSqlSelect = " SELECT '' AS USER_ID                            ";
                sSqlSelect += "      , 'ALL' AS USER_NAME                             ";
                sSqlSelect += " UNION ALL                                             ";
                sSqlSelect += " SELECT MINORCODE                        AS CODE_ID    ";
                sSqlSelect += "       ,'[' + MINORCODE + ']' + CODENAME AS CODE_NAME  ";
                sSqlSelect += " FROM TB_STANDARD                                       ";
                sSqlSelect += " WHERE MAJORCODE = 'DEPTCODE'                          ";
                sSqlSelect += " AND MINORCODE<>'$'                                    ";

                SqlDataAdapter Adapter = new SqlDataAdapter(sSqlSelect, Connect);
                 DataTable dtTemp1 = new DataTable();
                Adapter.Fill(dtTemp1);


                cboDePart.DataSource = dtTemp1;
                cboDePart.ValueMember = "USER_ID";
                cboDePart.DisplayMember = "USER_NAME";

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

        private void btnSerach_Click(object sender = null, EventArgs e = null)
        {

            SqlConnection Connect = new SqlConnection(Common.sConn);
            try
            {
                Connect.Open();

                dgvGrid.Columns["USERID"].ReadOnly = true;

                string sUserId = txtUserId.Text;          //유저 아이디 입력                 
                string sUserName = txtUserName.Text;        // 유저 이름 입력
                
                string sDePart = Convert.ToString(cboDePart.SelectedValue);


                string sSqlSelect = $" SELECT USERID, USERNAME, PW,PW_FCNT, DEPTCODE, MAKEDATE, MAKER, EDITDATE, EDITOR " +
                                  $"FROM TB_User WHERE USERID LIKE '%{sUserId}%' AND USERNAME LIKE '%{sUserName}%' AND ISNULL(DEPTCODE,'') LIKE '%{sDePart}%' ";
                                 
                
                SqlDataAdapter Adapter = new SqlDataAdapter(sSqlSelect, Connect);
                DataTable dtTemp = new DataTable();
                Adapter.Fill(dtTemp);
                dgvGrid.DataSource = dtTemp;
               
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
        
        private void btnAdd_Click(object sender, EventArgs e)
        {

            

            DataRow dr = ((DataTable)dgvGrid.DataSource).NewRow();
     
            ((DataTable)dgvGrid.DataSource).Rows.Add(dr);

          
            dgvGrid.Columns["MAKER"].ReadOnly = true;
            dgvGrid.Columns["MAKEDATE"].ReadOnly = true;
            dgvGrid.Columns["EDITDATE"].ReadOnly = true;
            dgvGrid.Columns["EDITOR"].ReadOnly = true;

            dgvGrid.Columns["USERID"].ReadOnly = false;
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
          
            if (dgvGrid.Rows.Count == 0) return; 
                     
            if (MessageBox.Show("선택한 사용자를 삭제 하시겠습니까?", "데이터 삭제", MessageBoxButtons.YesNo) == DialogResult.No) return;

            SqlConnection sCon = new SqlConnection(Common.sConn);
            sCon.Open();
         
            SqlTransaction sTran = sCon.BeginTransaction();

            try
            {
           
                SqlCommand cmd = new SqlCommand();
             
                cmd.Transaction = sTran;
       
                cmd.Connection = sCon;

                // 선택한 행에 있는 ITEMCODE 값 추출 후 변수에 등록하기.
                string sUserId = Convert.ToString(dgvGrid.CurrentRow.Cells["USERID"].Value);

                string sDeleteSql = string.Empty;
                sDeleteSql += "   DELETE TB_USER              ";
                sDeleteSql += $"  WHERE USERID = '{sUserId}';   ";

                cmd.CommandText = sDeleteSql;
              
                cmd.ExecuteNonQuery();
             
                sTran.Commit();
                
                MessageBox.Show(" 사용자 정보를 삭제 하였습니다. ");

                btnSerach_Click();
            }
            catch (Exception ex)
            {
                sTran.Rollback();
                MessageBox.Show(ex.ToString());
            }
            finally
            {
              
                sCon.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            if (dgvGrid.Rows.Count == 0) return;

            // 선택된 행에 있는 컬럼 별 데이터를 변수에 등록.
            string sUserId = Convert.ToString(dgvGrid.CurrentRow.Cells["USERID"].Value); // 사용자 ID
            string sUserName = Convert.ToString(dgvGrid.CurrentRow.Cells["USERNAME"].Value); // 사용자 이름
            string sPw = Convert.ToString(dgvGrid.CurrentRow.Cells["PW"].Value); // 비밀번호
            string sPw_F = Convert.ToString(dgvGrid.CurrentRow.Cells["PW_FCNT"].Value); // 비밀번호 틀린횟수
            string sDERCODE = Convert.ToString(dgvGrid.CurrentRow.Cells["DEPTCODE"].Value);  // 부서
            string sMakeD = Convert.ToString(dgvGrid.CurrentRow.Cells["MAKEDATE"].Value); // 등록일시
            string sMaker = Convert.ToString(dgvGrid.CurrentRow.Cells["MAKER"].Value); // 등록자
            string sEditD = Convert.ToString(dgvGrid.CurrentRow.Cells["EDITDATE"].Value); // 수정일시
            string sEditor = Convert.ToString(dgvGrid.CurrentRow.Cells["EDITOR"].Value); // 수정자


            // 필수 입력 정보 데이터 기입 여부 확인 (품목 코드, 출시일자)
            string sMessage = string.Empty;
            if (sUserId == "") sMessage = "사용자 아이디";
            else if (sUserName == "") sMessage = "사용자 이름";
            else if (sPw == "") sMessage = "비밀번호";
            if (sMessage != "")
            {
                MessageBox.Show(sMessage + " 를 입력하지 않았습니다."); return;
            }

            // 현재 선택된 행의 index 찾기
            int iCuRowIndex = dgvGrid.CurrentRow.Index;

            // 조회 된 그리드의 내역 중 itemcode 가 이미 등록 되어 있는지 확인.
            for (int i = 0; i < dgvGrid.Rows.Count; i++)
            {
                // 선택한 행의 인덱스(iCuRowIndex)와 그리드의 행의 주소(i) 가 같다 = 자기자신, 일때 Continue;
                if (iCuRowIndex == i) continue;
                if (Convert.ToString(dgvGrid.Rows[i].Cells["USERID"].Value) == sUserId)
                {
                    MessageBox.Show($"중복되는 품목코드 를 입력 하였습니다. 코드 형 : {i + 1}");
                    return;
                }
            }
            // 품목 정보 갱신 등록 로직이 시작되는곳.
            if (MessageBox.Show("선택한 사용자 정보를 등록 하시겠습니까?", "사용자 등록", MessageBoxButtons.YesNo) == DialogResult.No) return;



            // 데이터베이스 오픈
            SqlConnection sConn = new SqlConnection(Common.sConn);
            sConn.Open();

            // 품목마스터 테이블에 이미등록되어 있는 품목 코드인지 확인.
            // 있다면 UPDATE , 없다면 INSERT
            string sSelectSQL = string.Empty;
            sSelectSQL = $" SELECT * FROM TB_USER WHERE USERID = '{sUserId}'";

            SqlDataAdapter Adapter = new SqlDataAdapter(sSelectSQL, sConn);
            DataTable dtTemp = new DataTable();
            Adapter.Fill(dtTemp);

            // UPDATE, INSERT SQL 실행.


            SqlTransaction sTran = sConn.BeginTransaction();
            SqlCommand cmd = new SqlCommand();
            try
            {
                //1. cmd에 트랜잭션 연결
                cmd.Transaction = sTran;
                //2. 커맨드에 접속정보 연결
                cmd.Connection = sConn;

                
                //cmd에 UPDATE/INSERT SQL등록.
                string sUpInSQL = string.Empty;
                if (dtTemp.Rows.Count == 0)
                {
                   
                    string sMessage1 = string.Empty;
                    if (sUserId == "") sMessage1 = "사용자 아이디";
                    else if (sUserName == "") sMessage1 = "사용자 이름";
                    else if (sPw == "") sMessage1 = "비밀번호";
                    if (sMessage1 != "")
                    {
                        MessageBox.Show(sMessage1 + " 를 입력하지 않았습니다."); return;
                    }


                    // INSERT SQL
                    sUpInSQL = $" INSERT INTO TB_USER (USERID, USERNAME, PW, DEPTCODE, MAKEDATE, MAKER ) " +
                                    $" VALUES('{sUserId}','{sUserName}','{sPw}','{sDERCODE}',GETDATE(),'{Common.sUserID}') ";
                }
                else
                {
                    
                    // UPDATE SQL
                    sUpInSQL = " UPDATE TB_USER                " +
                              $"   SET      " +
                              $"      USERNAME = '{sUserName}'       " +
                              $"      ,PW = '{sPw}'       " +
                              $"      ,PW_FCNT  = '{sPw_F}'        " +
                              $"      ,DEPTCODE = '{sDERCODE}'     " +
                              $"      ,EDITDATE = GETDATE()           " +
                              $"      ,EDITOR   = '{Common.sUserID}'  " +
                              $" WHERE USERID = '{sUserId}';      ";
                   
                }
               
                cmd.CommandText = sUpInSQL; // 3. 커맨드에 SQL 구문 등록.

                cmd.ExecuteNonQuery(); // 커맨드 실행.

                sTran.Commit();

                MessageBox.Show("정상적으로 등록을 완료 하였습니다.");

                // 재 조 회
                btnSerach_Click();
            }
            catch (Exception ex)
            {
                sTran.Rollback();
            }
            finally
            {
                sConn.Close();
            }
        }

        private void btnImageLoad_Click(object sender, EventArgs e)
        {
            // 이미지 불러오기
            if (dgvGrid.Rows.Count == 0) return;

            // 파일 탐색기 호출 (OpenFileDialog : 파일 탐색기 클래스, Window 제공 API)
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult dirResult = dialog.ShowDialog();
            if (dirResult != DialogResult.OK) return;  // 사진칸에 값이없다면 리턴.

            // 사진을 선택하였을 경우 처리되는 로직.
            string sImageFilePath = dialog.FileName; // 사진 파일이 저장되어 있는 폴더의 경로 와 사진파일의 정보.

            // 사진 파일의 경로를 찾아가 Byte[] 배열 형식으로 반환하여 이미지뷰어(picItemImage) 에 표현한다. 
            picItemImage.Image = Bitmap.FromFile(sImageFilePath);
            // 파일의 경로 및 정보 를 tag 에 저장.
            picItemImage.Tag = sImageFilePath;
        }

        private void btnImageSave_Click(object sender, EventArgs e)
        {
          

            // 저장 버튼 클릭 시 품목 별 사진 데이터베이스에 저장.

            // 1. 밸리데이션 체크
            if (dgvGrid.Rows.Count == 0) return;        //품목 정보 미조회
            if (picItemImage.Image == null) return;   // 저장 대상 이미지 미오픈.

            DialogResult drResult = MessageBox.Show(" 현재 이미지를 품목에 등록하시겠습니까? ", "이미지 저장", MessageBoxButtons.YesNo);
            if (drResult == DialogResult.No) return;

            Byte[] bImage = null; // 이미지 파일의 등록 될 Byte 배열.

            SqlConnection sConn = new SqlConnection(Common.sConn);

            try
            {
                /*
                    -------------        BinaryReader     -----------------         FileStream          ------------
                      APP (BYTE)     <-----------------      RAM (Binary)     <---------------------->   File (Byte)
                    -------------                         -----------------                             ------------
                    Byte 바이트     : CPU 가 아닌 가상머신(OS) 에서 이해 할 수 있는 코드 의 이진 파일.
                    Binary 바이너리 : 컴퓨터(CPU) 가 인식 할 수 있는 0,1 로 이루어진 이진코드.     
                */

                #region<  사진파일을 APP 으로 전달 >

                // 2. File Stream 을 통해 파일을 오픈 하고 Binary 형식으로 변환.
                // FileMode.Open   : 경로에 있는 사진 파일에 접근
                // FileAccess.Read : 읽기 전용으로 읽어오겠다.
                // 픽처이미지 태그에있는값에 주소랑 이미지를 넣어둬서 불러옴 언박싱해서 스트링 형식으로 바꿔줌.
                FileStream stream = new FileStream(Convert.ToString(picItemImage.Tag), FileMode.Open, FileAccess.Read);

                // 3. Stream을 통해 읽어온 Binaey 코드, Byte 코드 변환.
                BinaryReader reader = new BinaryReader(stream);

                // 4. 만들어진 Binary 코드의 이미지를 Byte화 하여 APP 의 데이터 자료형 구조에 담는다.
                bImage = reader.ReadBytes(Convert.ToInt32(stream.Length));

                // 5. Binary Reader 종료
                reader.Close();
                // 6. 파일 스트림 종료.
                stream.Close();

                #endregion


                #region < 품목 마스터 에 품목 별 사진 저장 (UPDATE) >

                // 데이터베이스 오픈.
                sConn.Open();

                // 커맨드 생성
                SqlCommand cmd = new SqlCommand();

                // 커맨드에 db접속 주소 등록
                cmd.Connection = sConn;

                // 커맨드가 실행 할 SQL 구문 작성.

                string sUpdateSql = " UPDATE TB_USER                              " +
                   $" SET USERIMAGE  = @USERIMAGE                                 " +   // 품목 이미지 변수 생성.
                   $" WHERE USERID = '{dgvGrid.CurrentRow.Cells["USERID"].Value}' ";
                cmd.Parameters.AddWithValue("@USERIMAGE", bImage);

                // 커맨드에 SQL 구문 등록
                cmd.CommandText = sUpdateSql;

                // 커맨드 실행
                cmd.ExecuteNonQuery();

                MessageBox.Show(" 이미지가 정상적으로 등록 되었습니다. ");
                #endregion

            }
            catch (Exception ex)
            {
                MessageBox.Show(" 이미지 등록에 실패 하였습니다. \r\n" + ex.ToString());
            }
            finally
            {
                sConn.Close();
            }
        }

        private void btnImageDelete_Click(object sender, EventArgs e)
        {
            // 이미지를 삭제할 대상 품목이 있는지 확인.
            if (dgvGrid.Rows.Count == 0) return;

            // 이미지가 없을경우 반환해서 메세지박스로 표현해줌.
            if (picItemImage.Image == null)
            {
                MessageBox.Show(" 현재 삭제할 이미지가 없습니다. ");
                return;
            }

            // 품목별 이미지를 삭제 (NULL 로 UPDATE)

            // 데이터 베이스 오픈.
            SqlConnection sConn = new SqlConnection(Common.sConn);
            try
            {
                sConn.Open();
                // 커맨드 생성
                SqlCommand cmd = new SqlCommand();

                // 커맨드 접속 주소 연결
                cmd.Connection = sConn;

                // 커맨드 실행 SQL 문 작성
                string sUserId = Convert.ToString(dgvGrid.CurrentRow.Cells["USERID"].Value);
                string sUpSelect = " UPDATE TB_USER " +
                                   $" SET USERIMAGE = NULL WHERE USERID = '{sUserId}'  ";

                cmd.CommandText = sUpSelect;
                cmd.ExecuteNonQuery();
                picItemImage.Image = null;
                MessageBox.Show(" 정상적으로 이미지를 삭제 하였습니다.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(" 이미지 삭제에 실패하였습니다. ");
            }
            finally
            {
                sConn.Close();
            }

        }

        private void dgvGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 품목을 선택 했을때 이미지 표현.
            string sUserId = Convert.ToString(dgvGrid.CurrentRow.Cells["USERID"].Value);


            picItemImage.Image = null;
            // 데이터베이스 오픈.
            SqlConnection sConn = new SqlConnection(Common.sConn);
            try
            {
                sConn.Open();

                // DATABASE 에서 이미지 바이트 로드를 가져올 SQL 구문 작성
                string sImageByteLoad = " SELECT USERIMAGE FROM TB_USER     " +
                                       $"   WHERE USERID = '{sUserId}'        ";
                SqlDataAdapter Adapter = new SqlDataAdapter(sImageByteLoad, sConn);
                DataTable dtTemp = new DataTable();
                Adapter.Fill(dtTemp);

                // 품목별 이미지 BYTE 코드 가 있는지 체크.
                if (Convert.ToString(dtTemp.Rows[0]["USERIMAGE"]) == "") return;

                // BYTE[] 배열 형식으로 받아올 변수 생성
                Byte[] bImage = null;

                // BYTE 배열 형식으로 BYTE 코드 형변환.
                bImage = (byte[])dtTemp.Rows[0]["USERIMAGE"];

                // byte[] 배열인 bImage 를 Bitmap(픽셀 이미지 로 변경해주는 클래스) 로 변환
                picItemImage.Image = new Bitmap(new MemoryStream(bImage));


            }
            catch (Exception ex)
            {
                MessageBox.Show("이미지 로드에 실패하였습니다\r\n" + ex.ToString());
            }
            finally
            {
                sConn.Close();
            }
        }
    }
    
}
