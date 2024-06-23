namespace refAndValueDemo1
{
    class Program
    {

        public class Person
        {
            public int age = 10;
        }
        static void Main(string[] args)
        {
            var i = 3;
            var j = i;
            Console.WriteLine(string.Format("i:{0}, j:{1}",i,j));
            
            j = 4;
            Console.WriteLine(string.Format("i:{0}, j:{1}",i,j));

            var num1 = new int[3] {1, 2, 3};
            var num2 = num1;

            num2[0] = 1000;
            Console.WriteLine(num1[0]);
            Incremnet(i);
            Console.WriteLine("i:{0}", i);

            var john=new Person();
            makeOld(john);
            Console.WriteLine("age:{0}", john.age);

        }

        public static void Incremnet(int number)
        {
            number += 10;
            Console.WriteLine("number:{0}",number);
        }

        public static void makeOld(Person person)
        {
            person.age += 10;
            Console.WriteLine("age:{0}", person.age);
        }
    }
}
