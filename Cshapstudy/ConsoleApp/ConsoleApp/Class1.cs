using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Class1
    {
        static void Main(string[] args)
        {

            //Writeline 사용법
            System.Console.WriteLine("Hello World");
            //Write 사용법
            System.Console.Write("만나서 반갑습니다.");
            string MyName;
            MyName = "이태근";
            System.Console.Write("제 이름은 ");
            System.Console.Write(MyName);
            System.Console.WriteLine("입니다");
            string Address;
            Address = "인천";
            System.Console.WriteLine("저는 현재 인천에 살고 있습니다.");
            System.Console.Write("그리고 지금 기계설계 일을 하고 있습니다.");
            string year;
            year = "10년";
            System.Console.WriteLine("이 일을 시작한 지는 벌써 10년이 되었습니다.");
            System.Console.Write("하지만 저는 다른 전공으로 직종을 변경하고자 합니다.");
            System.Console.WriteLine("그래서 지금 이렇게 수업을 받고 있습니다.");
            System.Console.Write("잘 부탁 드립니다.");
            System.Console.WriteLine("끝");

            //주석 사용법 //만 치면 됨.
            //System.Console.Write("Hi!!")

            //String - 데이터 형
            string myName;

            myName = "이태근";

            System.Console.WriteLine(myName);

            //ReadLine

            string Name;

            System.Console.WriteLine("이름을 입력해주세요 : ");
            Name = System.Console.ReadLine();

            System.Console.Write("당신의 이름은 : ");
            System.Console.WriteLine(Name);

            string adress;

            System.Console.WriteLine("주소를 입력해주세요 : ");
            adress = System.Console.ReadLine();

            System.Console.Write("당신의 주소는 : ");
            System.Console.WriteLine(adress);

            string age;

            System.Console.WriteLine("나이를 입력해주세요 : ");
            age = System.Console.ReadLine();

            System.Console.Write("당신의 나이는 : ");
            System.Console.WriteLine(age);

            string sex;

            System.Console.WriteLine("성별을 입력해주세요 : ");
            sex = System.Console.ReadLine();

            System.Console.Write("당신의 성별은 : ");
            System.Console.WriteLine(sex);

            System.Console.WriteLine($"당신의 이름은 {Name}이고, 당신의 나이는 {age}입니다");
            System.Console.WriteLine("당신의 주소는 {0}이고, 당신의 성별은 {1}입니다", adress, sex);

            //2장 변수

            int Age = 3;
            string name = "tg";
            float today = 1.29f;

            System.Console.WriteLine(int.MaxValue);
            System.Console.WriteLine(int.MinValue);

            int number = 2147483647;
            System.Console.WriteLine(number + 1);

            System.Console.WriteLine("강사님이 말했다.");

            string name2 = "tg";

            System.Console.WriteLine(name2);

            string age2 = "3";

            string MMM = name2 + age2;

            System.Console.Write(MMM);

            string age3;
            System.Console.WriteLine("나이를 입력해주세요 : ");
            age3 = System.Console.ReadLine();

            int age3number = Convert.ToInt32(age3);

            string nowage = (age3number + 3).ToString();
            //위 코드는 문자 형식의 숫자를 숫자로 변형한 것

            //태어난 년도 입력 후 지금 나이를 도출하기

            //string year1;
            //string year2;
            //year1 = System.Console.ReadLine();
            //year2 = System.Console.ReadLine();

            //int year11 = Convert.ToInt32(year1);
            //int year22 = Convert.ToInt32(year2);

            //string nowage1 = (year22 - year11).ToString();
            //System.Console.WriteLine($"제 나이는 {nowage1} 입니다");

            // 여러줄 문자 에 @ 입력

            System.Console.WriteLine("-------------------------------------------------------------------");

            //1. 변수형 종류 주석으로 작성 후 각 변수형들의 최대값 최소값

            System.Console.WriteLine("1번");
            int strength;
            string health;
            float day;

            System.Console.WriteLine(int.MaxValue);
            System.Console.WriteLine(int.MinValue);
            System.Console.WriteLine(float.MaxValue);
            System.Console.WriteLine(float.MinValue);
            System.Console.WriteLine(long.MaxValue);
            System.Console.WriteLine(long.MinValue);
            System.Console.WriteLine(double.MaxValue);
            System.Console.WriteLine(double.MinValue);

            //2. string으로 이름 나이 입력 받고, 출력하기
            // 나이는 출생년도만 입력 받기

            System.Console.WriteLine("2번");
            string Myname;
            string Myage;

            System.Console.WriteLine("이름를 입력해주세요.");
            Myname = System.Console.ReadLine();

            System.Console.WriteLine("출생년도를 입력해주세요.");
            string myage2 = System.Console.ReadLine();
            System.Console.WriteLine("현재년도를 입력해주세요.");
            string myage3 = System.Console.ReadLine();

            int myage4 = Convert.ToInt32(myage2);
            int myage5 = Convert.ToInt32(myage3);

            string Myage2 = (myage5 - myage4).ToString();

            System.Console.WriteLine($"제 이름은 {Myname} 입니다. 그리고 제 나이는 {myage2}");


            //3. @사용해서 별 그리기
            System.Console.WriteLine("3번");
            System.Console.WriteLine(@"
          0
       0000000
        00000
       00   00");


            //4. int값을 float로 캐스팅하기
            System.Console.WriteLine("4번");
            float ageage = 3.12f;
            int ageage2 = Convert.ToInt32(ageage);

            System.Console.WriteLine($"int값 {ageage2}");


            int a1234 = 3;
            double a12345 = Convert.ToDouble(a1234);
            System.Console.WriteLine($"값은 {a12345 / 2}");

            //5. 이름을 입력받고 숫자로 바꾼 후 출력한다.

            System.Console.WriteLine("이름을 입력하세요");
            string Name1;
            Name1 = System.Console.ReadLine();
            int length = Name1.Length;
            System.Console.WriteLine(length);



            //3장

            //string name34 = "이태근";
            //int ii = 3;

            //값을 가져올때 int,string,char 형인지 모를경우
            //var name45 = "이태근";


            //대열

            int[] iiii = new int[3];
            int[] kkk = new int[4] { 89, 6, 456, 4 };
            System.Console.WriteLine(kkk[0]);

            //string[] lang = new string[3] { "c#", "C++", "C" };


            //int형 배열을 5칸 짜리 5개
            //string형 배열 5칸 짜리 5개

            int[] i1 = new int[5] { 3, 1, 5, 10, 7 };
            int[] i2 = new int[5] { 12, 20, 18, 13, 16 };
            int[] i3 = new int[5] { 25, 22, 27, 30, 21 };
            int[] i4 = new int[5] { 35, 31, 39, 36, 33 };
            int[] i5 = new int[5] { 48, 50, 41, 42, 46 };

            string[] s1 = new string[5] { "김치", "참치", "부대", "된장", "동태" };
            string[] s2 = new string[5] { "국", "찌개", "밥", "조림", "튀김" };
            string[] s3 = new string[5] { "콜라", "사이다", "주스", "식혜", "쿨피스" };
            string[] s4 = new string[5] { "새우깡", "고구마깡", "감자깡", "치토스", "계란과자" };
            string[] s5 = new string[5] { "말보로", "디스", "시가", "마일드세븐", "사탕" };

            System.Console.WriteLine(i1[4]);


            //

            int[] LaterArray;

            System.Console.WriteLine("배열의 크기는?");
            string Arraysize;
            Arraysize = System.Console.ReadLine();

            LaterArray = new int[Convert.ToInt32(Arraysize)];

            String[] _lang = new string[3];
            _lang[0] = "c";
            _lang[1] = "C++";
            _lang[2] = "c#";

            System.Console.WriteLine($"0번 값은 {_lang[0]}입니다");
            _lang[0] = "밥줘";

            System.Console.WriteLine($"0번 값은 {_lang[0]}입니다");

            //식당에 음식이 떡볶이, 김밥, 라면, 라뽁이가 있다. string 배열 추가
            //이중에 숫자를 입력받으면 입력값은 비어있게 된다.

            //먹고싶은 음식은? 질문
            //최초 음식들과 숫자를 입력받았을때 음식을 출력하고
            //비어있게 되었다라는 결과값도 출력하라.

            string[] Manu = new string[4];
            Manu[0] = "1.떡볶이";
            Manu[1] = "2.김밥";
            Manu[2] = "3.라면";
            Manu[3] = "4.라뽁이";

            System.Console.WriteLine("주문하시겠습니까?");
            System.Console.WriteLine($"{Manu[0]}");
            System.Console.WriteLine($"{Manu[1]}");
            System.Console.WriteLine($"{Manu[2]}");
            System.Console.WriteLine($"{Manu[3]}");

            string select0 = System.Console.ReadLine();
            int select = Convert.ToInt32(select0);

            Manu[select - 1] = " ";

            System.Console.WriteLine($"{Manu[0]}");
            System.Console.WriteLine($"{Manu[1]}");
            System.Console.WriteLine($"{Manu[2]}");
            System.Console.WriteLine($"{Manu[3]}");

        }
    }
}
