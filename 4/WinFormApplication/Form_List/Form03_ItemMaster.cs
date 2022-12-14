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
using Assamble;

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

            #region< 1. 그리드 셋팅 >
            // 1. 데이터 테이블 생성 ( 그리드에 표현될 컬럼을 셋팅).
            DataTable dtGrid = new DataTable();
            dtGrid.Columns.Add("ITEMCODE", typeof(string));   // 품목 코드
            dtGrid.Columns.Add("ITEMNAME", typeof(string));   // 품목 명
            dtGrid.Columns.Add("ITEMTYPE", typeof(string));   // 품목 유형
            dtGrid.Columns.Add("ITEMDESC", typeof(string));   // 품목 상세정보
            dtGrid.Columns.Add("ENDFLAG" , typeof(string));   // 단종 여부
            dtGrid.Columns.Add("PRODDATE", typeof(string));   // 출시 일자
            dtGrid.Columns.Add("MAKEDATE", typeof(string));   // 데이터 생성 일시
            dtGrid.Columns.Add("MAKER"   , typeof(string));   // 생성자, 로그인한 사람
            dtGrid.Columns.Add("EDITDATE", typeof(string));   // 수정 일시
            dtGrid.Columns.Add("EDITOR"  , typeof(string));   // 수정자, 로그인한 사람

            // 2. 셋팅된 컬럼 을 그리드에 매핑.
            // DataSource : 데이터 베이스에서 가져온 테이블 형식의 데이터를 등록. 할때 사용
            dgvGrid.DataSource = dtGrid;

            // 3. 그리드 컬럼에 한글 명칭으로 컬럼 Text 보여주기.
            dgvGrid.Columns["ITEMCODE"].HeaderText = "품목 코드";
            dgvGrid.Columns["ITEMNAME"].HeaderText = "품목 명";
            dgvGrid.Columns["ITEMTYPE"].HeaderText = "품목 유형";
            dgvGrid.Columns["ITEMDESC"].HeaderText = "품목 상세";
            dgvGrid.Columns["ENDFLAG"].HeaderText  = "단종 여부";
            dgvGrid.Columns["PRODDATE"].HeaderText = "출시 일자";
            dgvGrid.Columns["MAKEDATE"].HeaderText = "등록 일시";
            dgvGrid.Columns["MAKER"].HeaderText    = "등록자";
            dgvGrid.Columns["EDITDATE"].HeaderText = "수정 일시";
            dgvGrid.Columns["EDITOR"].HeaderText   = "수정자";


            // 4. 컬럼의 폭 지정.
            dgvGrid.Columns[0].Width = 100; // 품목 코드
            dgvGrid.Columns[1].Width = 200; // 품목 명
            dgvGrid.Columns[3].Width = 300; // 품목 상세
            dgvGrid.Columns[6].Width = 250; // 등록 일시
            dgvGrid.Columns[8].Width = 250; // 수정 일시


            // 5. 컬럼의 수정 여부 설정.
            dgvGrid.Columns["ITEMCODE"].ReadOnly = true;
            dgvGrid.Columns["MAKEDATE"].ReadOnly = true;
            dgvGrid.Columns["MAKER"].ReadOnly    = true;
            dgvGrid.Columns["EDITDATE"].ReadOnly = true;
            dgvGrid.Columns["EDITOR"].ReadOnly   = true;

            #endregion


            // Common.sConn : Assamble 에 등록 되어 있는 데이터베이스 접속 주소.
            SqlConnection Connect = new SqlConnection(Common.sConn);
            #region< 2. 품목 유형 콤보박스 셋팅 >
            try
            {
                // 데이터베이스에 공통기준정보(TB_Standard) 중 품목 유형(ITEMTYPE)의 정보를
                // 받아와서 콤보박스에 등록 하기.

                //1. 데이터베이스 접속 클래스 설정.

                // 데이터 베이스 오픈.
                Connect.Open();

                // 2. 품목유형 데이터 리스트 조회 SQL
             string  sSqlSelect  = "                SELECT MINORCODE                       AS CODE_ID     ";
                     sSqlSelect += "      ,'{' + MINORCODE + '}' + CODENAME                AS CODE_NAME   ";
                     sSqlSelect += "                                                                      ";
                     sSqlSelect += "    FROM TB_Standard                                                  ";
                     sSqlSelect += " WHERE MAJORCODE = 'ITEMTYPE'                                         ";
                     sSqlSelect += "  AND MINORCODE<> '$'                                                 ";

                SqlDataAdapter Adapter = new SqlDataAdapter(sSqlSelect, Connect);
                DataTable dtTemp = new DataTable();
                Adapter.Fill(dtTemp);

                // 콤보박스에 품목유형 리스트 등록.
                cboItemType.DataSource    = dtTemp;
                cboItemType.ValueMember   = "CODE_ID";    // 로직 상 처리될 코드가 있는 컬럼.
                cboItemType.DisplayMember = "CODE_NAME";  // 사용자 에게 보여줄 컬럼.
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                Connect.Close();
            }
            #endregion



        }

        private void btnSearch_Click(object sender, EventArgs e)
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

                       sSelectSql += "   SELECT ITEMCODE       ";
                       sSelectSql += "        , ITEMNAME       ";
                       sSelectSql += "        , ITEMTYPE       ";
                       sSelectSql += "        , ITEMCODE       ";
                       sSelectSql += "        , ENDFLAG        ";
                       sSelectSql += "        , PRODDATE       ";
                       sSelectSql += "        , MAKEDATE       ";
                       sSelectSql += "        , MAKER          ";
                       sSelectSql += "        , EDITDATE       ";
                       sSelectSql += "        , EDITOR         ";
                       sSelectSql += "      FROM TB_ItemMaster ";
             
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
    }
}
