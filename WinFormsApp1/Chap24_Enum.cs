using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyfirstCSharp
{

    // Enum : 정수형 상수의 모음.
    // 1. 상수 데이터의 묶음(그룹화를 통한 식별을 용이)
    // 2. 별도의 클래스 없이 네임스페이스 아래에 등록이 가능.
    // 3. 기본값을 지정하지 않아도 된다.
    // 4. 컴퓨터가 연산처리 할 때 문자가 아닌 정수 형으로 처리 하므로 연산이 용이.
    // 5. 상수명에 대한 오탈자로 인한 오류 상황을 방지 할 수 있다.
    // 6. 중복되는 값을 가지지 않기 때문에 로직상 처리되는 오류도 방지 할 수 있다.



    internal class Chap24_Enum
    {
        // 1. 상수를 아래와 같이 정의하여 사용 할 경우
        // 상수의 이름으로 식별 할 수 있으나
        // 그룹화 되지 않아서 어떤 유형의 상수 인지 파악하기 어려울때가 있다.

        // 상수는 반드시 값이 초기화 되어 등록 되어야 하는 단점이 있다.
        const int HAWA      = 0; // 상품
        const int ROH       = 1; // 원자재
        const int HALB      = 2; // 반제품
        const int UPH       = 0; // 시간당 생산 수량
        const int CYCLETIME = 1; // 공정 당 생산 시간
        const int TAKTTIME  = 2; // 제품 1개 생산 시간


        public enum ItemType
        {
            HAWA, // 0 자동적으로 값이 들어가있음.
            ROH,  // 1
            HALB  // 2
        }
        public enum ProductProcee
        {
            UPH = 10,
            CYCLETIME, // 11 자동적으로  숫자가 들어감.
            TAKTTIME   // 12
        }
    
    }
}
