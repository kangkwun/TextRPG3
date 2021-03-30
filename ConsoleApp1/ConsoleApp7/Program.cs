using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            string name="Harry Potter";

            //1. 문자열이 있는지 찾기
            
            bool found = name.Contains("Harryy");

            //2. 찾기 어디쯤 있는지
            int index = name.IndexOf('p');

            //3. 변형
            name = name + "junior";

            //4. 모든 문자를 소문자로, 소문자를 대문자로
            
            string lowerCaseName = name.ToLower();
            string PuwerCaseName = name.ToUpper();

            //5. 문자를 바꾼다 ex) r -> l
            string newname = name.Replace('r', 'l');

            //6. 분할 -> 띄어쓰기한 것으로 분할
            string[] names = name.Split(new char[]{' '});

            //7. 새로운 이름을 넣기
            // 5번째 부터 새롭게 넣기
            string subStringName = name.Substring(5);
        }
    }
}
