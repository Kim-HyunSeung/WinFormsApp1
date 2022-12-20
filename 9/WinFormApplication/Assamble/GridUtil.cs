using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assamble
{
    public class GridUtil
    {
        private DataTable dtTemp = new DataTable();

        /// <summary>
        /// 데이터 그리드 뷰 컬럼 셋팅 메서드
        /// </summary>
        /// <param name="dgvTemp"> 셋팅 할 그리드 </param>
        /// <param name="sColumnID"> 컬럼의 ID </param>
        /// <param name="sColumnText"> 컬럼의TEXT </param>
        /// <param name="ColumnType"> 컬럼의 데이터 타입 </param>
        /// <param name="ColumnWidth"> 컬럼의 넓이 </param>
        /// <param name="Align"> 컬럼데이터 정렬방식 </param>
        /// <param name="Editable"> 컬럼 수정 여부 </param>
        public void InitColumnGrid(DataGridView dgvTemp,string sColumnID,string sColumnText,Type ColumnType,int ColumnWidth,DataGridViewContentAlignment Align,bool Editable)
        {
            // 그리드를 셋팅하는 함수(메서드)

            // 1. 데이터 테이블에 컬럼의 타입 셋팅
            dtTemp.Columns.Add(sColumnID, ColumnType);
            // 2. 그리드뷰에 컬럼 셋팅
            dgvTemp.DataSource= dtTemp;

            // 3. 컬럼의 한글 명칭 text 설정.
            dgvTemp.Columns[sColumnID].HeaderText = sColumnText;

            // 4. 컬럼의 폭 지정
            dgvTemp.Columns[sColumnID].Width = ColumnWidth;

            // 5. 컬럼 데이터 정렬
            dgvTemp.Columns[sColumnID].DefaultCellStyle.Alignment = Align;

            // 6. 컬럼의 수정 여부
            dgvTemp.Columns[sColumnID].ReadOnly = !Editable;
        }
    }
}
