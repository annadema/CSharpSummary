namespace GenericsDemo
{
    public class NumberList
    {
        public void Add(int number)
        {
            
        }
        public int this[int index]
        {
            get { throw new NotImplementedException();}
        }
    }



    public class ObjectList
    {
        public void Add(Object value)
        {

        }
        public Object this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }


}