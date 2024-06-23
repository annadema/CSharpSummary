namespace MoshExerciseString
{
    public class StringTool
    {
        public  static string  ReverseString(string name)
        {
            var array = new char[name.Length];
            for (int i = name.Length; i > 0; i--)
                array[name.Length - i] = name[i - 1];

            return  new string(array); 
        }
    }
}