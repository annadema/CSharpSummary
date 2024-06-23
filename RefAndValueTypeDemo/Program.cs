namespace refAndValueTypeDemo
{
    public class Person
    {
        public int Age;
    }
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine(string.Format("a: {0}, b: {1}",a,b));
            var numbers1 = new int[3] {1,2,3};
            var numbers2 = numbers1;
            numbers2[0] = 0;
            Console.WriteLine(string.Format("numbers1[0]: {0}\nnumbers2[0]: {0}", numbers1[0],numbers2[0]));


            var number = 1;
            Increment(number);
            Console.WriteLine(number);  //1

            var person = new Person() {Age = 20};
            MakeOld(person);
            Console.WriteLine(person.Age); //30
        }
         
        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
}
