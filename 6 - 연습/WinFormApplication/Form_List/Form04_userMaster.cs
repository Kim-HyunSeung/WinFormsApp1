using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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

        private void Form04_userMaster_Load(object sender, EventArgs e)
        {
            DataTable dtTemp = new DataTable();
            dtTemp.Columns.Add("USERID", typeof(string));
            dtTemp.Columns.Add("USERNAME", typeof(string));
            dtTemp.Columns.Add("PW", typeof(string));
            dtTemp.Columns.Add("PW_F_CNT", typeof(string));
            dtTemp.Columns.Add("DEPTCODE", typeof(string));
            dtTemp.Columns.Add("MAKEDATE", typeof(string));
            dtTemp.Columns.Add("MAKER", typeof(string));
            dtTemp.Columns.Add("EDITDATE", typeof(string));
            dtTemp.Columns.Add("EDITOR", typeof(string));
            dgvGrid.DataSource = dtTemp;

            dgvGrid.Columns["USERID"].HeaderText = "사용자ID";
            dgvGrid.Columns["USERNAME"].HeaderText = "사용자명";
            dgvGrid.Columns["PW"].HeaderText = "비밀번호";
            dgvGrid.Columns["PW_F_CNT"].HeaderText = " 실패횟수 ";
            dgvGrid.Columns["DEPTCODE"].HeaderText = "부서";
            dgvGrid.Columns["MAKEDATE"].HeaderText = "등록일시";
            dgvGrid.Columns["MAKER"].HeaderText = "등록자";
            dgvGrid.Columns["EDITDATE"].HeaderText = "수정일시";
            dgvGrid.Columns["EDITOR"].HeaderText = "수정자";


            SqlConnection Connect = new SqlConnection(Common.sConn);

            try
            {
                Connect.Open();


                string sSqlSelect = " SELECT '' AS CODE_ID                             ";
                sSqlSelect += "      , 'ALL' AS CODE_NAME                             ";
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
                cboDePart.ValueMember = "CODE_ID";
                cboDePart.DisplayMember = "CODE_NAME";

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
            string sItemCode = Convert.ToString(dgvGrid.CurrentRow.Cells["ITEMCODE"].Value); // 품목 코드
            string sItemName = Convert.ToString(dgvGrid.CurrentRow.Cells["ITEMNAME"].Value); // 품목 명
            string sItemType = Convert.ToString(dgvGrid.CurrentRow.Cells["ITEMTYPE"].Value); // 품목 타입
            string sItemDesc = Convert.ToString(dgvGrid.CurrentRow.Cells["ITEMDESC"].Value); // 품목 상세
            string sEndFlag = Convert.ToString(dgvGrid.CurrentRow.Cells["ENDFLAG"].Value);  // 단종 여부
            string sProdDate = Convert.ToString(dgvGrid.CurrentRow.Cells["PRODDATE"].Value); // 출시 일자.
        }
    }
}
