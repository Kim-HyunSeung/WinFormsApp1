using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assamble;
using static System.Net.Mime.MediaTypeNames;

namespace Form_List
{
    public partial class Form03_ItemMaster : Form
    {
        public Form03_ItemMaster()
        {
            InitializeComponent();
        }

        private void Form03_ItemMaster_Load(object sender, EventArgs e)
        {
            // 아이템 마스터 화면이 오픈 될때 처리되는 로직.
            Common.SetComboControl("ITEMCODE", cboItemType);
            //#region< 1. 그리드 셋팅 >
            //// 1. 데이터 테이블 생성 ( 그리드에 표현될 컬럼을 셋팅).
            //DataTable dtGrid = new DataTable();
            //dtGrid.Columns.Add("ITEMCODE", typeof(string));   // 품목 코드
            //dtGrid.Columns.Add("ITEMNAME", typeof(string));   // 품목 명
            //dtGrid.Columns.Add("ITEMTYPE", typeof(string));   // 품목 유형
            //dtGrid.Columns.Add("ITEMDESC", typeof(string));   // 품목 상세정보
            //dtGrid.Columns.Add("ENDFLAG" , typeof(string));   // 단종 여부
            //dtGrid.Columns.Add("PRODDATE", typeof(string));   // 출시 일자
            //dtGrid.Columns.Add("MAKEDATE", typeof(string));   // 데이터 생성 일시
            //dtGrid.Columns.Add("MAKER"   , typeof(string));   // 생성자, 로그인한 사람
            //dtGrid.Columns.Add("EDITDATE", typeof(string));   // 수정 일시
            //dtGrid.Columns.Add("EDITOR"  , typeof(string));   // 수정자, 로그인한 사람

            //// 2. 셋팅된 컬럼 을 그리드에 매핑.
            //// DataSource : 데이터 베이스에서 가져온 테이블 형식의 데이터를 등록. 할때 사용
            //dgvGrid.DataSource = dtGrid;

            //// 3. 그리드 컬럼에 한글 명칭으로 컬럼 Text 보여주기.
            //dgvGrid.Columns["ITEMCODE"].HeaderText = "품목 코드";
            //dgvGrid.Columns["ITEMNAME"].HeaderText = "품목 명";
            //dgvGrid.Columns["ITEMTYPE"].HeaderText = "품목 유형";
            //dgvGrid.Columns["ITEMDESC"].HeaderText = "품목 상세";
            //dgvGrid.Columns["ENDFLAG"].HeaderText  = "단종 여부";
            //dgvGrid.Columns["PRODDATE"].HeaderText = "출시 일자";
            //dgvGrid.Columns["MAKEDATE"].HeaderText = "등록 일시";
            //dgvGrid.Columns["MAKER"].HeaderText    = "등록자";
            //dgvGrid.Columns["EDITDATE"].HeaderText = "수정 일시";
            //dgvGrid.Columns["EDITOR"].HeaderText   = "수정자";


            //// 4. 컬럼의 폭 지정.
            //dgvGrid.Columns[0].Width = 100; // 품목 코드
            //dgvGrid.Columns[1].Width = 200; // 품목 명
            //dgvGrid.Columns[3].Width = 300; // 품목 상세
            //dgvGrid.Columns[6].Width = 250; // 등록 일시
            //dgvGrid.Columns[8].Width = 250; // 수정 일시


            //// 5. 컬럼의 수정 여부 설정.
            //dgvGrid.Columns["ITEMCODE"].ReadOnly = true;
            //dgvGrid.Columns["MAKEDATE"].ReadOnly = true;
            //dgvGrid.Columns["MAKER"].ReadOnly    = true;
            //dgvGrid.Columns["EDITDATE"].ReadOnly = true;
            //dgvGrid.Columns["EDITOR"].ReadOnly   = true;

            //#endregion


            //// Common.sConn : Assamble 에 등록 되어 있는 데이터베이스 접속 주소.
            //SqlConnection Connect = new SqlConnection(Common.sConn);
            //#region< 2. 품목 유형 콤보박스 셋팅 >
            //try
            //{
            //    // 데이터베이스에 공통기준정보(TB_Standard) 중 품목 유형(ITEMTYPE)의 정보를
            //    // 받아와서 콤보박스에 등록 하기.

            //    //1. 데이터베이스 접속 클래스 설정.

            //    // 데이터 베이스 오픈.
            //    Connect.Open();

            //    // 2. 품목유형 데이터 리스트 조회 SQL
            //         string sSqlSelect = string.Empty;

            //         sSqlSelect  = " SELECT ''                                             AS CODE_ID     ";
            //         sSqlSelect += "       , 'ALL'                                         AS CODE_NAME   ";
            //         sSqlSelect += " UNION ALL                                                            ";
            //         sSqlSelect += "                SELECT MINORCODE                       AS CODE_ID     ";
            //         sSqlSelect += "      ,'{' + MINORCODE + '}' + CODENAME                AS CODE_NAME   ";
            //         sSqlSelect += "                                                                      ";
            //         sSqlSelect += "    FROM TB_Standard                                                  ";
            //         sSqlSelect += " WHERE MAJORCODE = 'ITEMTYPE'                                         ";
            //         sSqlSelect += "  AND MINORCODE<> '$'                                                 ";

            //    SqlDataAdapter Adapter = new SqlDataAdapter(sSqlSelect, Connect);
            //    DataTable dtTemp = new DataTable();
            //    Adapter.Fill(dtTemp);

            //    // 콤보박스에 품목유형 리스트 등록.
            //    cboItemType.DataSource    = dtTemp;
            //    cboItemType.ValueMember   = "CODE_ID";    // 로직 상 처리될 코드가 있는 컬럼.
            //    cboItemType.DisplayMember = "CODE_NAME";  // 사용자 에게 보여줄 컬럼.
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
            //finally
            //{
            //    Connect.Close();
            //}
            //#endregion



        }

        private void btnSearch_Click(object sender = null, EventArgs e = null)
        {
            // 조회 버튼 클릭 이벤트.
            SqlConnection Connect = new SqlConnection(Common.sConn);
            try
            {
                Connect.Open();

                // 조회조건 받아올 변수 파라매터 선언 및 값 등록.
                string sItemCode  = txtItemCode.Text;                            // 품목 코드 입력 정보.
                string sItemName  = txtItemName.Text;                            // 품목 입력 정보.
                string sStartDate = dtpStart.Text;                               // 출시 일자 시작 일자.
                string sEndDate   = dtpEnd.Text;                                 // 출시 일자   끝 일자.
                string sItemType  = Convert.ToString(cboItemType.SelectedValue); // Text : DisplayMember, SqlectedValue : ValueMember
                if (chkOnlyName.Checked) sItemCode = "";                         // 품목 코드 와는 관계 없는 나머지 조회 조건으로 검색.
                
                string sEndFlag = "Y";
                if      (rdoProd.Checked == true)    sEndFlag = "N";     // 생산 버튼 선택되어있을때
                                                                         //else if (rdoEndProd.Checked == true) sEndFlag = "Y";     // 단종 버튼 선택되어있을때


                // 품목 마스터 테이블에서 데이터 를 조회 할 SQL 구문 작성.
                string sSelectSql = string.Empty;
                   
                       sSelectSql += "   SELECT ITEMCODE                                          ";
                       sSelectSql += "        , ITEMNAME                                          ";
                       sSelectSql += "        , ITEMTYPE                                          ";
                       sSelectSql += "        , ITEMDESC                                          ";
                       sSelectSql += "        , ENDFLAG                                           ";
                       sSelectSql += "        , PRODDATE                                          ";
                       sSelectSql += "        , MAKEDATE                                          ";
                       sSelectSql += "        , MAKER                                             ";
                       sSelectSql += "        , EDITDATE                                          ";
                       sSelectSql += "        , EDITOR                                            ";
                       sSelectSql += "      FROM TB_ItemMaster                                    ";
                       sSelectSql += $"  WHERE ITEMCODE LIKE '%{sItemCode}%'                      ";          
                       sSelectSql += $"    AND ITEMNAME LIKE '%{sItemName}%'                      ";           
                       sSelectSql += $"    AND PRODDATE BETWEEN '{sStartDate}' AND '{sEndDate}'   ";                   
                       sSelectSql += $"    AND ITEMTYPE LIKE '%{sItemType}%'                      ";    
                       sSelectSql += $"    AND ENDFLAG = '{sEndFlag}'                             ";




                SqlDataAdapter Adapter = new SqlDataAdapter(sSelectSql, Connect);
                DataTable dtTemp = new DataTable();
                Adapter.Fill(dtTemp);

                // 조회 결과를 그리드에 매핑(바인딩)   // 12-13 콤보박스 마저 해야댐.
                dgvGrid.DataSource = dtTemp;
            }
            catch(Exception ex)
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
            // 품목 정보 등록 을 위한 그리드 행 추가.
            // 1. 그리드 의 컬럼 포멧이 들어있는 빈 행 데이터 타입이 필요. (DataRow : 한개의 행 데이터 타입.)

            // (DataTable)dgvGrid.DataSource 데이터 테이블 형식으로 형변환한다.
            DataRow dr = ((DataTable)dgvGrid.DataSource).NewRow();  
           

            //2. 빈 깡통 행 을 그리드에 추가.
            ((DataTable)dgvGrid.DataSource).Rows.Add(dr);


            // 3. 품목 코드 입력 할 수 있도록 컬럼 수정 여부 풀기.(false)
            dgvGrid.Columns["ITEMCODE"].ReadOnly = false;


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // 품목 마스터 데이터 삭제.
            // 선택된 행에 있는 품목을 삭제.

            if (dgvGrid.Rows.Count == 0) return; // 실행했을때 그리드의 행의 수가 0이면 삭제하지마라.
            //DialogResult dirResult =  MessageBox.Show("선택한 품목을 삭제 하시겠습니까?","데이터 삭제",MessageBoxButtons.YesNo);
            //if(dirResult == DialogResult.No) return;

            // 한줄로 표현가능.
            if(MessageBox.Show("선택한 품목을 삭제 하시겠습니까?","데이터 삭제",MessageBoxButtons.YesNo) == DialogResult.No)return;

            // 데이터 베이스 접속 및 Delete 를 위한 Command 클래스 설정.

            //1. 데이터 베이스 오픈
            SqlConnection sCon = new SqlConnection(Common.sConn);
            sCon.Open();
            //3. 갱신 데이터 승인 권한 가지고 오기.Transation
            SqlTransaction sTran = sCon.BeginTransaction();

            try
            {

                //2. 삭제 (Delete) 명령어를 수행할 Command 객체
                SqlCommand cmd = new SqlCommand();

                //4. 커맨드에 트랜잭션 등록.
                cmd.Transaction = sTran;

                //5. 커맨드에 접속 경로 등록.
                cmd.Connection = sCon;

                //6. Delete SQL 구문 작성 및 Command 에 등록.

                // 선택한 행에 있는 ITEMCODE 값 추출 후 변수에 등록하기.
                string sItemCode = Convert.ToString(dgvGrid.CurrentRow.Cells["ITEMCODE"].Value);

                string sDeleteSql = string.Empty;
                sDeleteSql += "   DELETE TB_ItemMaster              ";
                sDeleteSql += $"  WHERE ITEMCODE = '{sItemCode}';   ";

                cmd.CommandText = sDeleteSql;


                //7. Command 실행.
                cmd.ExecuteNonQuery();

                //8. 정상 등록 시 Commit 실행.
                sTran.Commit();

                //9. 정상 삭제 메세지 표현.
                MessageBox.Show(" 품목 정보를 삭제 하였습니다. ");

                //10. 재 조 회.
                btnSearch_Click(); // 인수 인자값을 위에서 안썻을때 널값으로 불러올수있다. 위에서 선택적 인자를 널값으로 지정해줘서 안에 안써줘도됨.
            }
            catch(Exception ex)
            {
                sTran.Rollback();
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                // 데이터 베이스 연결 끊기.
                sCon.Close();
            }
          
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // 선택된 행의 데이터를 저장하는 기능 구현.
            if (dgvGrid.Rows.Count == 0) return;

            // 선택된 행에 있는 컬럼 별 데이터를 변수에 등록.
            string sItemCode = Convert.ToString(dgvGrid.CurrentRow.Cells["ITEMCODE"].Value); // 품목 코드
            string sItemName = Convert.ToString(dgvGrid.CurrentRow.Cells["ITEMNAME"].Value); // 품목 명
            string sItemType = Convert.ToString(dgvGrid.CurrentRow.Cells["ITEMTYPE"].Value); // 품목 타입
            string sItemDesc = Convert.ToString(dgvGrid.CurrentRow.Cells["ITEMDESC"].Value); // 품목 상세
            string sEndFlag  = Convert.ToString(dgvGrid.CurrentRow.Cells["ENDFLAG"].Value);  // 단종 여부
            string sProdDate = Convert.ToString(dgvGrid.CurrentRow.Cells["PRODDATE"].Value); // 출시 일자.


            // 필수 입력 정보 데이터 기입 여부 확인 (품목 코드, 출시일자)
            string sMessage = string.Empty;
            if (sItemCode == "")      sMessage = "품목코드";
            else if (sProdDate == "") sMessage = "출시일자";

            if(sMessage != "")
            {
                MessageBox.Show(sMessage + " 를 입력하지 않았습니다."); return;
            }

            // 현재 선택된 행의 index 찾기
            int iCuRowIndex = dgvGrid.CurrentRow.Index;

            // 조회 된 그리드의 내역 중 itemcode 가 이미 등록 되어 있는지 확인.
            for (int i = 0; i< dgvGrid.Rows.Count; i++)
            {
                // 선택한 행의 인덱스(iCuRowIndex)와 그리드의 행의 주소(i) 가 같다 = 자기자신, 일때 Continue;
                if (iCuRowIndex == i) continue;
                if (Convert.ToString(dgvGrid.Rows[i].Cells["ITEMCODE"].Value) == sItemCode)
                {
                    MessageBox.Show($"중복되는 품목코드 를 입력 하였습니다. 코드 형 : {i + 1}");
                    return;
                }
            }
            // 품목 정보 갱신 등록 로직이 시작되는곳.
            if (MessageBox.Show("선택한 품목정보를 등록 하시겠습니까?", "품목등록", MessageBoxButtons.YesNo) == DialogResult.No) return;



            // 데이터베이스 오픈
            SqlConnection sConn = new SqlConnection(Common.sConn);
            sConn.Open();

            // 품목마스터 테이블에 이미등록되어 있는 품목 코드인지 확인.
            // 있다면 UPDATE , 없다면 INSERT
            string sSelectSQL = string.Empty;
            sSelectSQL = $" SELECT * FROM TB_ITEMMASTER WHERE ITEMCODE = '{sItemCode}'";

            SqlDataAdapter Adapter =new SqlDataAdapter(sSelectSQL, sConn);
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

                // 단종여부에 아무값도 입력하지 않았을 경우 기본 N 입력.
                if (sEndFlag == "") sEndFlag = "N";


                //cmd에 UPDATE/INSERT SQL등록.
                string sUpInSQL = string.Empty;
                if(dtTemp.Rows.Count == 0)
                {
                    // INSERT SQL
                    sUpInSQL = $" INSERT INTO TB_ITEMMASTER (ITEMCODE, ITEMNAME, ITEMTYPE, ITEMDESC, ENDFLAG, PRODDATE, MAKEDATE, MAKER ) " +
                               $" VALUES('{sItemCode}','{sItemName}','{sItemType}','{sItemDesc}','{sEndFlag}','{sProdDate}',GETDATE(),'{Common.sUserID}') ";
                                  
                }
                else
                {
                    // UPDATE SQL
                    sUpInSQL = " UPDATE TB_ITEMMASTER                 " +
                              $"   SET ITEMNAME = '{sItemName}'       " +
                              $"      ,ITEMTYPE = '{sItemType}'       " +
                              $"      ,ITEMDESC = '{sItemDesc}'       " +
                              $"      ,ENDFLAG  = '{sEndFlag}'        " +
                              $"      ,PRODDATE = '{sProdDate}'       " +
                              $"      ,EDITDATE = GETDATE()           " +
                              $"      ,EDITOR   = '{Common.sUserID}'  " +
                              $" WHERE ITEMCODE = '{sItemCode}';      "; 

                }

                cmd.CommandText = sUpInSQL; // 3. 커맨드에 SQL 구문 등록.

                cmd.ExecuteNonQuery(); // 커맨드 실행.

                sTran.Commit();

                MessageBox.Show("정상적으로 등록을 완료 하였습니다.");
              
                // 재 조 회
                btnSearch_Click();
            }
            catch(Exception ex)
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
            OpenFileDialog dialog= new OpenFileDialog();
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
            // 선행 되어야 하는 일 : TB_ITEMMASTER 에 ITEMIMAGE 컬럼 생성 (IMAGE 데이터 타입)

            // 저장 버튼 클릭 시 품목 별 사진 데이터베이스에 저장.

            // 1. 밸리데이션 체크
            if(dgvGrid.Rows.Count == 0) return;        //품목 정보 미조회
            if (picItemImage.Image == null) return;   // 저장 대상 이미지 미오픈.

           DialogResult drResult = MessageBox.Show(" 현재 이미지를 품목에 등록하시겠습니까? ", "이미지 저장",MessageBoxButtons.YesNo);
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
                FileStream stream = new FileStream(Convert.ToString(picItemImage.Tag),FileMode.Open,FileAccess.Read);

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
                cmd.Connection= sConn;

                // 커맨드가 실행 할 SQL 구문 작성.
                //string sUpdateSql = " UPDATE TB_ITEMMASTER        " +
                //                   $" SET ITEMIMAGE  = '{bImage}' " +
                //                   $" WHERE ITEMCODE = '{dgvGrid.CurrentRow.Cells["ITEMCODE"].Value}' ";


                //----------------------------------------------------------------------------------
                string sUpdateSql = " UPDATE TB_ITEMMASTER                            "+
                   $" SET ITEMIMAGE  = @ITEMIMAGE                                   "+   // 품목 이미지 변수 생성.
                   $" WHERE ITEMCODE = '{dgvGrid.CurrentRow.Cells["ITEMCODE"].Value}' ";
                cmd.Parameters.AddWithValue("@ITEMIMAGE", bImage);


                //string sUpdateSql = " UPDATE TB_ITEMMASTER" +
                //    $"  SET      ITEMIMAGE = @ITEMIMAGE " + // 품목 이미지 변수 생성
                //    $"  WHERE    ITEMCODE  = '{dgvGrid.CurrentRow.Cells["ITEMCODE"].Value}' ";
                //cmd.Parameters.AddWithValue("@ITEMIMAGE", bImage);

                // 커맨드에 SQL 구문 등록
                cmd.CommandText= sUpdateSql;

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

        private void dgvGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 품목을 선택 했을때 이미지 표현.
            string sItemCode =Convert.ToString(dgvGrid.CurrentRow.Cells["ITEMCODE"].Value);


            picItemImage.Image = null;
            // 데이터베이스 오픈.
            SqlConnection sConn = new SqlConnection(Common.sConn);
            try
            {
                sConn.Open();

                // DATABASE 에서 이미지 바이트 로드를 가져올 SQL 구문 작성
                string sImageByteLoad = " SELECT ITEMIMAGE FROM TB_ITEMMASTER     " +
                                       $"   WHERE ITEMCODE = '{sItemCode}'        ";
                SqlDataAdapter Adapter  = new SqlDataAdapter(sImageByteLoad,sConn);
                DataTable dtTemp = new DataTable();
                Adapter.Fill(dtTemp);

                // 품목별 이미지 BYTE 코드 가 있는지 체크.
                if (Convert.ToString(dtTemp.Rows[0]["ITEMIMAGE"]) == "") return;

                // BYTE[] 배열 형식으로 받아올 변수 생성
                Byte[] bImage = null;

                // BYTE 배열 형식으로 BYTE 코드 형변환.
                bImage = (byte[])dtTemp.Rows[0]["ITEMIMAGE"];
                
                // byte[] 배열인 bImage 를 Bitmap(픽셀 이미지 로 변경해주는 클래스) 로 변환
                picItemImage.Image = new Bitmap(new MemoryStream(bImage));


            }
            catch(Exception ex)
            {
                MessageBox.Show("이미지 로드에 실패하였습니다\r\n" + ex.ToString());
            }
            finally
            {
                sConn.Close();
            }


        }

        private void btnImageDelete_Click(object sender, EventArgs e)
        {
            // 이미지를 삭제할 대상 품목이 있는지 확인.
            if(dgvGrid.Rows.Count == 0) return;

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
                string sItemcode = Convert.ToString(dgvGrid.CurrentRow.Cells["ITEMCODE"].Value);
                string sUpSelect = " UPDATE TB_ITEMMASTER " +
                                   $" SET ITEMIMAGE = NULL WHERE ITEMCODE = '{sItemcode}'  ";

                cmd.CommandText = sUpSelect;
                cmd.ExecuteNonQuery();
                picItemImage.Image = null;
                MessageBox.Show(" 정상적으로 이미지를 삭제 하였습니다.");
            }
            catch(Exception ex)
            {
                MessageBox.Show(" 이미지 삭제에 실패하였습니다. ");
            }
            finally
            {
                sConn.Close();
            }
        }
    }
}
