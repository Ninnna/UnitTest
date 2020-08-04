using System;

namespace UnitTest
{
    public interface IClassOne
    {
        int Method();
    }

    public class ClassOne : IClassOne
    {
        public int Method()
        {
            return 0;
        }
    }

    public class Test
    {
        private IClassOne _classOne;
        public Test(IClassOne classOne)
        {
            _classOne = classOne;
        }
        public bool IsPositive(int inputValue)
        {
            return inputValue > _classOne.Method();
        }
    }

    public class MyClass
    {
        public int Add(int value1,int value2)
        {
            return value1 + value2;
        }
    }

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("");
        }
    }
}