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
    public partial class Form06_CustMaster : Assamble.BaseChildForm
    {
        public Form06_CustMaster()
        {
            InitializeComponent();
        }

        private void Form06_CustMaster_Load(object sender, EventArgs e)
        {
            // 그리드 셋팅
            // 콤보박스 셋팅
        }
        public override void DoInquire()
        {
           
            string sCustCode = txtVC.Text; // 거래처 코드
            string sCustName = txtVN.Text; //거래처 이름
            string sCustType = Convert.ToString(cboC.SelectedValue);


            // 데이터 베이스 오픈.
            DBHelper helper = new DBHelper();
            try
            {
                SqlDataAdapter Adapter = new SqlDataAdapter("SP_CUSTMASTER_S1", helper.sCon);

                // Adapter 에게 지정 프로시저 형식의 SQL 을 실행할것을 등록함.
                Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                // 저장 프로시저가 받을 파라매터(인자) 값 설정.
                Adapter.SelectCommand.Parameters.AddWithValue("@CUSTCODE", sCustCode);
                Adapter.SelectCommand.Parameters.AddWithValue("@CUSTNAME", sCustName);
                Adapter.SelectCommand.Parameters.AddWithValue("@DEPTCODE", sCustType);

                // 기본적으로 모든 프로시저에 적용될 내용.
                Adapter.SelectCommand.Parameters.AddWithValue("@LANG", "KO");
                Adapter.SelectCommand.Parameters.AddWithValue("@RS_CODE", "").Direction = ParameterDirection.Output;
                Adapter.SelectCommand.Parameters.AddWithValue("@RS_MSG", "").Direction = ParameterDirection.Output;

                DataTable dtTemp = new DataTable();
                Adapter.Fill(dtTemp);

                dgvgrid.DataSource = dtTemp;

            }
            catch (Exception ex)
            {

            }
            finally
            {
                helper.Close();
            }
        }
        public override void DoNew()
        {
            // 툴바에서 추가 버튼 을 클릭 했을때 실행되는 로직.
            base.DoNew();

            // 그리드에 셋팅 되어 있는 컬럼 포멧(양식)을 가진 빈 깡통 행 생성
            // DataRow dr = ((DataTable)dgvGrid.DataSource).NewRow();

            // *Object 형식의 DataSource 를 정렬하여 양식이 같은 행을 생성 할 필요가 있음.
            // 그리드의 DataSource 를 DataTable 형식으로 정렬
            DataTable dtTemp = (DataTable)dgvgrid.DataSource;
            // 정렬된 데이터 그리드에 한 행을 신규 생성
            DataRow dr2 = dtTemp.NewRow();

            // 생성된 신규 행을 그리드 데이터 소스 에 추가.
            ((DataTable)dgvgrid.DataSource).Rows.Add(dr2);
        }


    }
    
}
