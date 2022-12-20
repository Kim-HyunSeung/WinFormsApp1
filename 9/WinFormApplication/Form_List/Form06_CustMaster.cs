﻿using System;
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
            DataTable dtTemp = new DataTable();
            dtTemp.Columns.Add("CUSTTYPE", typeof(string));
            dtTemp.Columns.Add("CUSTCODE", typeof(string));
            dtTemp.Columns.Add("CUSTNAME", typeof(string));
            dtTemp.Columns.Add("BIZREQNO", typeof(string));
            dtTemp.Columns.Add("BIZADDRESS", typeof(string));
            dtTemp.Columns.Add("PHONE", typeof(string));
            dtTemp.Columns.Add("OWNERNAME", typeof(string));
            dtTemp.Columns.Add("MAKEDATE", typeof(string));
            dtTemp.Columns.Add("MAKER", typeof(string));
            dtTemp.Columns.Add("EDITDATE", typeof(string));
            dtTemp.Columns.Add("EDITOR", typeof(string));
            dgvgrid.DataSource = dtTemp;

            dgvgrid.Columns["CUSTTYPE"].HeaderText = "거래처구분";
            dgvgrid.Columns["CUSTCODE"].HeaderText = "거래처코드";
            dgvgrid.Columns["CUSTNAME"].HeaderText = "거래처명";
            dgvgrid.Columns["BIZREQNO"].HeaderText = " 사업자등록번호 ";
            dgvgrid.Columns["BIZADDRESS"].HeaderText = "주소";
            dgvgrid.Columns["PHONE"].HeaderText = "전화번호";
            dgvgrid.Columns["OWNERNAME"].HeaderText = "대표자";
            dgvgrid.Columns["MAKEDATE"].HeaderText = "생성일시";
            dgvgrid.Columns["MAKER"].HeaderText = "생성자";
            dgvgrid.Columns["EDITDATE"].HeaderText = "수정일시";
            dgvgrid.Columns["EDITOR"].HeaderText = "수정자";

            Common.SetComboControl("CUSTTYPE", cboC); // 거래처에 관련된 공통 기준정보 조회.

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
                Adapter.SelectCommand.Parameters.AddWithValue("@CUSTTYPE", sCustType);

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


        public override void DoDelete()
        {
            // 툴바의 삭제 버튼 을 클릭 하였을 경우 로직.
            // 1. 삭제 할 내역이 있는지 확인.
            if (dgvgrid.Rows.Count == 0) return;

            // RemoveAt() : 행 자체를 삭제 한다. 복구 할 수 없으며 행의 상태를 확인 할 수 없다.
            //// 2. 삭제 할 행의 위치 index 찾기
            //int iRowIndex = dgvGrid.CurrentRow.Index;

            //// 3. grid 의 DataSource 에 바인딩(매핑,연결) 된 DataTable 의 행을 삭제.
            //DataTable dtTemp = (DataTable)dgvGrid.DataSource;

            //// 4. 선택한 행의 위치 정보를 가진 DataTable 데이터 삭제.
            //dtTemp.Rows.RemoveAt(iRowIndex);

            // Delete() : 삭제 데이터를 복구 가능 하여 행의 상태를 삭제 상태로 확인 할 수 있다.
            //            그리드에 표현되는 내용은 삭제가 된 것 처럼 표현 가능.

            int iRowIndex = dgvgrid.CurrentRow.Index;
            DataTable dtTemp = (DataTable)dgvgrid.DataSource;
            dtTemp.Rows[iRowIndex].Delete();

        }

        public override void DoSave()
        {
            // 표 형식의 데이터 (DataGridView) 의 데이터를 등록하는 방법으로 주로 사용되는 방법.
            // 그리드에 표현된 데이터를 일괄 추가, 수정, 삭제 로직 적용.

            // 1. 데이터베이스 open
            DBHelper helper = new DBHelper();

            // 3. 일괄 승인 및 일괄 복구 트랜잭션 설정.
            SqlTransaction sTran = helper.sCon.BeginTransaction();


            try
            {
                // 2. 데이터베이스 갱신,명령, 전달 클래스 객체  생성.
                SqlCommand cmd = new SqlCommand();


                // 4. 트랜잭션 커맨드에 연결
                cmd.Transaction = sTran;
                // 5. 커맨드에 접속 정보 연결.
                cmd.Connection = helper.sCon;
                // 6 . 커맨드에 저장 프로시저 형식 선언
                cmd.CommandType = CommandType.StoredProcedure;


                // 6 . 그리드의 행 중에 갱신 이력이 있는 행만 추출 하여 DataTable 에 담기.
                dgvgrid.Update(); // 그리드에 갱신 된 데이터 확정.

                // GetChanges : 변경된거를 찾는 메소드
                DataTable dtTemp = ((DataTable)dgvgrid.DataSource).GetChanges();

                string sMessage = string.Empty;
                // 7 . 갱신된 행만 추출한 데이터테이블의 행 수 만큼 반복하여
                //     UPDATE, INSERT, DELETE 분기 찾기.
                foreach (DataRow dr in dtTemp.Rows)
                {
                    // 데이터 테이블에서 추출한 행의 상태 비교
                    switch (dr.RowState)
                    {
                        case DataRowState.Deleted:
                            dr.RejectChanges(); // 지워진 행의 데이터를 복구.
                            cmd.CommandText = "SP_CUSTMASTER_D1";
                            cmd.Parameters.AddWithValue("@CUSTCODE", Convert.ToString(dr["CUSTCODE"]));

                            cmd.Parameters.AddWithValue("@LANG", "KO");
                            cmd.Parameters.AddWithValue("@RS_CODE", "").Direction = ParameterDirection.Output;
                            cmd.Parameters.AddWithValue("@RS_MSG", "").Direction = ParameterDirection.Output;

                            cmd.ExecuteNonQuery();
                            break;
                        case DataRowState.Added:
                            // 지금 추출한 행의 상태가 신규 추가 상태 라면
                            // 1. 필수 입력 데이터 확인

                            if (Convert.ToString(dr["CUSTCODE"]) == "") sMessage = "업체 코드";
                            else if (Convert.ToString(dr["CUSTNAME"]) == "") sMessage = "업체명";
                            else if (Convert.ToString(dr["CUSTTYPE"]) == "") sMessage = "업체타입";
                            if (sMessage != "")
                            {
                                sTran.Rollback();
                                MessageBox.Show(sMessage + " 를 입력하지 않았습니다.");
                                return;
                            }

                            // 2. 사용자 등록 로직 구현.
                            cmd.CommandText = "SP_CUSTMASTER_I1";
                            cmd.Parameters.AddWithValue("@CUSTCODE", Convert.ToString(dr["CUSTCODE"]));
                            cmd.Parameters.AddWithValue("@CUSTNAME", Convert.ToString(dr["CUSTNAME"]));
                            cmd.Parameters.AddWithValue("@CUSTTYPE", Convert.ToString(dr["CUSTTYPE"]));
                            cmd.Parameters.AddWithValue("@BIZREQNO", Convert.ToString(dr["BIZREQNO"]));
                            cmd.Parameters.AddWithValue("@BIZADDRESS", Convert.ToString(dr["BIZADDRESS"]));
                            cmd.Parameters.AddWithValue("@PHONE", Convert.ToString(dr["PHONE"]));
                            cmd.Parameters.AddWithValue("@OWNERNAME", Convert.ToString(dr["OWNERNAME"]));
                            cmd.Parameters.AddWithValue("@MAKER", Common.sUserID);

                            cmd.Parameters.AddWithValue("@LANG", "KO");
                            cmd.Parameters.AddWithValue("@RS_CODE", "").Direction = ParameterDirection.Output;
                            cmd.Parameters.AddWithValue("@RS_MSG", "").Direction = ParameterDirection.Output;

                            // 커맨드를 실행.
                            cmd.ExecuteNonQuery();

                            break;
                        case DataRowState.Modified:
                            // 지금 추출한 행의 상태가 신규 추가 상태 라면
                            // 1. 필수 입력 데이터 확인

                            if (Convert.ToString(dr["CUSTCODE"]) == "") sMessage = "업체 코드";
                            else if (Convert.ToString(dr["CUSTNAME"]) == "") sMessage = "업체명";
                            else if (Convert.ToString(dr["CUSTTYPE"]) == "") sMessage = "업체타입";
                            if (sMessage != "")
                            {
                                sTran.Rollback();
                                MessageBox.Show(sMessage + " 를 입력하지 않았습니다.");
                                return;
                            }

                            // 2. 사용자 정보 수정 로직 구현.
                            cmd.CommandText = " SP_CUSTMASTER_U1";
                            cmd.Parameters.AddWithValue("@CUSTCODE", Convert.ToString(dr["CUSTCODE"]));
                            cmd.Parameters.AddWithValue("@CUSTNAME", Convert.ToString(dr["CUSTNAME"]));
                            cmd.Parameters.AddWithValue("@CUSTTYPE", Convert.ToString(dr["CUSTTYPE"]));
                            cmd.Parameters.AddWithValue("@BIZREQNO", Convert.ToString(dr["BIZREQNO"]));
                            cmd.Parameters.AddWithValue("@BIZADDRESS", Convert.ToString(dr["BIZADDRESS"]));
                            cmd.Parameters.AddWithValue("@PHONE", Convert.ToString(dr["PHONE"]));
                            cmd.Parameters.AddWithValue("@OWNERNAME", Convert.ToString(dr["OWNERNAME"]));
                            cmd.Parameters.AddWithValue("@EDITOR", Common.sUserID);
                            cmd.Parameters.AddWithValue("@LANG", "KO");
                            cmd.Parameters.AddWithValue("@RS_CODE", "").Direction = ParameterDirection.Output;
                            cmd.Parameters.AddWithValue("@RS_MSG", "").Direction = ParameterDirection.Output;

                            // 커맨드를 실행.
                            cmd.ExecuteNonQuery();

                            break;
                    }

                    string sRs_Code = Convert.ToString(cmd.Parameters["@RS_CODE"].Value);
                    string sRs_Msg = Convert.ToString(cmd.Parameters["@RS_MSG"].Value);

                    if (sRs_Code != "S")
                    {
                        sTran.Rollback();
                        MessageBox.Show(sRs_Msg);
                        return;
                    }

                    // 처리한 커맨드의 파라매터(인자) 정보 삭제.
                    // 다음 커맨드에서 인수를 받아와서 또 다시 처리하게 하기위해
                    cmd.Parameters.Clear();
                }

                // 6 . 커맨드에 프로시저 연결.               
                // INSERT

                // UPDATE

                // DELETE
                sTran.Commit();
                MessageBox.Show("정상적으로 데이터를 등록 하였습니다.");
                DoInquire(); // 재 조 회
            }
            catch (Exception ex)
            {
                sTran.Rollback();
                MessageBox.Show("데이터 등록에 실패 하였습니다", ex.ToString());
            }
            finally
            {
                helper.Close();
            }

        }
    }   
}
