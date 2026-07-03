namespace Lesson_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            string str = Console.ReadLine();
            MyClass cls = new MyClass(str);
            Func funcDell = new Func(cls.Space);
            funcDell += cls.Reverse;
Run run = new Run();
            run.runFunc(funcDell, str); 

        }
    }
}
