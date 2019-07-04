using System;

namespace CSharpMemoryTricks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (false)
            {
                MyStack.Run();
            }
            if (false)
            {
                MyHeap.Run();
            }
            if (false)
            {
                MyUnboxing.Run();
            }
            if (false)
            {
                MyBoxing.Run();
            }
            if (false)
            {
                MyStringConcatination.Run();
            }
            if (true)
            {
                MyStruct.Run();
            }
        }


    }    

    public class MyClass
    {
        public void MyMethod()
        {
            int count = 0;
            byte[] buffer = new byte[100];
            DoSomeAction(count, buffer);

            int a = 1234;
            object b = a;
            int c = (int)b;
        }

        private void DoSomeAction(int count, byte[] buffer)
        {
        }
    }
}
