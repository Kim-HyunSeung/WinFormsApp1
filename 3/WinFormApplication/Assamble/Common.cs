﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 클래스 라이브러리 = namespace = 프로젝트 = DLL 파일. 이름이 다같음
namespace Assamble
{
    // 클래스 라이브러리
    // 하나 이상의 APP 또는 프로젝트에서 호출되는 변수. 및 메서드(로직) 등을 작성하여
    // DLL 파일로 제공 할 수 있게 만든 프로젝트 형식.
    // 단독으로 실행 되지 않고 외부 프로그램에서 참조해서 호출 하는 구조
    // 배포 및 재사용이 용이. 보안성 향상. 의 장점이 있다.
    public class Common
    {
        public const string sConn = "Data Source = (local) ;Initial Catalog = AppDev;Integrated Security = SSPI;";
        // const는 기본적으로 스태틱 속성을 가지고있음.

        public static string sUserID = "";
        public static string sUserName = "";

        // 로그인 성공 여부 판단.
        // public static bool bLoginSF = false;
    } 

}
