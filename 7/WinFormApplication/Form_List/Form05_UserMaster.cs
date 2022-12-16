using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Assamble;

namespace Form_List
{

    /*------------------------------------------------------
 * NAME    : Form05_UserMaster
 * DESC    : 저장 프로시저를 이요안 사용자 관리 화면.
 *------------------------------------------------------
 * DATE    : 2022-12-16
 * AUTHOR  : 김현승
 * DESC    : 최초 프로그램 작성
 -------------------------------------------------------*/



    public partial class Form05_UserMaster : Assamble.BaseChildForm
    {
        public Form05_UserMaster()
        {
            InitializeComponent();
        }


        private void Form05_UserMaster_Load(object sender, EventArgs e)
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

           Common.SetComboControl("DEPTCODE",cboDePart); // 부서에 관련된 공통 기준정보 조회.
          

        }


        public override void DoInquire()
        {
            // BaseChildForm 에 있는 DoInquire() 메서드 기능을 수행.

            // 조회 버튼 클릭시 사용자 정보 조회
            string sUserId   = txtUserId.Text;
            string sUserName = txtUserName.Text;
            string sDeptCode = Convert.ToString(cboDePart.SelectedValue);


            // 데이터 베이스 오픈.
            DBHelper helper = new DBHelper();
            try
            {
                SqlDataAdapter Adapter = new SqlDataAdapter("BM_UseriMaster_S1",helper.sCon);
                
                // Adapter 에게 지정 프로시저 형식의 SQL 을 실행할것을 등록함.
                Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                // 저장 프로시저가 받을 파라매터(인자) 값 설정.
                Adapter.SelectCommand.Parameters.AddWithValue("@USERID",   sUserId);
                Adapter.SelectCommand.Parameters.AddWithValue("@USERNAME", sUserName);
                Adapter.SelectCommand.Parameters.AddWithValue("@DEPTCODE", sDeptCode);

                // 기본적으로 모든 프로시저에 적용될 내용.
                Adapter.SelectCommand.Parameters.AddWithValue("@LANG",    "KO");
                Adapter.SelectCommand.Parameters.AddWithValue("@RS_CODE",   "").Direction = ParameterDirection.Output;
                Adapter.SelectCommand.Parameters.AddWithValue("@RS_MSG",    "").Direction = ParameterDirection.Output; 

                DataTable dtTemp = new DataTable();
                Adapter.Fill(dtTemp);

                dgvGrid.DataSource= dtTemp;

            }
            catch(Exception ex)
            {

            }
            finally
            {
                helper.Close();
            }    
        }

    }
}
