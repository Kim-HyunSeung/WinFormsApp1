using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstCSharp
{
    public partial class chap25_Exception_TryCatch : Form
    {
        public chap25_Exception_TryCatch()
        {
            InitializeComponent();
        }

        private void btnException_Click(object sender, EventArgs e)
        {
            // 시스템 오류 만들기
            int[] iValues = { 1, 2, };
            MessageBox.Show(Convert.ToString(iValues[3]));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Exception : 발생 할 수 있는 시스템 오류의 원인을 검출.
            // 개발자 또는 사용자에게 오류의 유형을 확인 할 수 있게 하는 기능
            // 예외 상황이 발생 되었을때 마다 상황에 맞는 예외 클래스 의 기능을 이용하여
            // 검출 할 수 있으나, 통상적으로는 Exception 클래스(모든 상황을 검출) 를 사용하여
            // 자세한 오류 내역을 검출 하고자 할때는 그에 맞는 예외 클래스를 혼합하여 사용.

            // Exception 클래스의 종류

            // Exception 모든 종류의 예외를 처리할 수 있다.
            //
            // ArgumentException 메서드에 전달 되는 null이 아닌 인수가 잘못되었다.
            //
            // ArgumentNullException 메서드에 전달 되는 인수가 null이다.
            // 
            // ArgumentOutOfRangeException 인수가 유효한 값 범위를 벗어났다.
            // 
            // DirectoryNotFoundException 디렉터리 경로 일부가 잘못되었다.
            // 
            // DivideByZeroException 0으로 나누었다.
            // 
            // DriveNotFoundException 드라이브가 없거나 사용할 수 없다. 

            // FileNotFoundException 파일이 없다.
            // 
            // FormatException 문자열에서 변환할 수 있는 적절 한 형식이 아니다.
            // 
            // IndexOutOfRangeException 인덱스가 배열 또는 컬렉션의 범위를 벗어났다.
            // 
            // InvalidOperationException 개체의 현재 상태에서 메서드 호출을 사용할 수 없다.
            // 
            // KeyNotFoundException 컬렉션의 멤버에 액세스 하는 데 지정 된 키를 찾을 수 없다.
            // 
            // NotImplementedException 메서드 또는 작업이 구현 되지 않았다.
            // 
            // NotSupportedException 메서드 또는 작업이 지원 되지 않는다.
            // 
            // ObjectDisposedException 삭제 된 개체에 대한 작업을 수행했다.
            // 
            // OverflowException 산술, 캐스팅 또는 변환 작업을 수행 하면 오버플로가 발생한다.
            // 
            // OverflowException 작업 결과가 대상 데이터 형식의 범위를 벗어났다.
            // 
            // PathTooLongException 경로 또는 파일 이름이 시스템에서 정의한 최대 길이를 초과한다.
            // 
            // PlatformNotSupportedException 현재 플랫폼에서 작업이 지원 되지 않는다.
            // 
            // RankException 차원 수가 잘못되었다.
            // 
            // TimeoutException 작업에 할당 된 시간 간격이 만료 되었다.
            // 
            // UriFormatException 잘못 된 URI(Uniform Resource Identifier)가 사용 되었다.



            try
            {
                int iResult = DivideMethod(1, 2);
                MessageBox.Show(iResult.ToString());
            }

            catch(DivideByZeroException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        int DivideMethod(int iValue, int iValue2)
        {
            int iResult = iValue / iValue2;
            return iResult;
        }

        private void btnFinarry_Click(object sender, EventArgs e)
        {
            try
            {
                // 정상 적인 로직
            }
            catch(Exception ex)
            {
                //예외 상황이 생겼을때 처리 로직

            }
            finally
            {
                // 정상적으로 로직이 수행 되든 예외상황이 발생이 되든
                // 무조건 수행하는 로직이 오는 부분

                // ex)데이터베이스 작업 후 데이터 베이스 접속을 종료 하는 구문
            }

        }

        private void btnThrow_Click(object sender, EventArgs e)
        {
            // 예외 던지기 
            // 예외 상황을 임의로 발생 시켜 예외 처리 로직을 수행 하게 하는 기능.

            try
            {
                Random Ran = new Random();
                int iRandom = Ran.Next(0,20);
                if (iRandom < 15)
                {
                    throw new Exception($"15 미만의 값을 받았습니다. 값 : {iRandom}");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
