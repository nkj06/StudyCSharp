using System;

namespace EnumApp
{
    class Program
    {
        enum DialogResult // 열거형은 정수값을 담고 있음 0~4
        {
            YES = 10,
            NO = 20,
            CANCEL = 30,
            CONFIRM = 40,
            OK // 41이 들어감
        }
        static void Main(string[] args)
        {
            //Console.WriteLine(DialogResult.OK);
            //Console.WriteLine((int)DialogResult.OK);
            DialogResult result = DialogResult.YES;
            if(result == DialogResult.YES)
            {
                Console.WriteLine("YES를 선택했습니다.");
            }
        }
    }
}
