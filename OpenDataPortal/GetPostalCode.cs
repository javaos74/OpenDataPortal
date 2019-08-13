using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;
using System.ComponentModel;
using System.Data;

namespace OpenDataPortal
{

    public enum SearchCondition
    {
        우편번호 = 0,
        동이름,
        도로이름
    }

    public sealed class GetPostalCode : CodeActivity
    {
        private static readonly string [ ]SearchCondition = new string[3] { "post", "dong", "road" };
        //서비스키 정보 
        [Category("Input")]
        [RequiredArgument]
        public InArgument<string> ServiceKey { get; set; }

        // 검색 구분  동/주소/우편번호 
        [Category("Input")]
        [RequiredArgument]
        public SearchCondition Condition { get; set; }

        //검색어 키워드 
        [Category("Input")]
        [RequiredArgument]
        public InArgument<string> Keyword { get; set; }


        //결과 
        [Category("Output")]
        [RequiredArgument]
        public OutArgument<DataTable> Result { get; set; }


        // 작업 결과 값을 반환할 경우 CodeActivity<TResult>에서 파생되고
        // Execute 메서드에서 값을 반환합니다.
        protected override void Execute(CodeActivityContext context)
        {
            // 텍스트 입력 인수의 런타임 값을 가져옵니다.
            throw new Exception("아직 구현되지 않았습니다.");
        }
    }
}
