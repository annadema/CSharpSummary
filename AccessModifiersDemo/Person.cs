using System;

namespace AccessModifiersDemo
{
    public class Person
    {
        //first way: private member and created method for get and set 
        private DateTime _birthDate;
        private string _name;


        public void SetBirthDate(DateTime data)
        {
            this._birthDate = data;
        }
        public DateTime GetBirthDate()
        {
            return this._birthDate;
        }

        //second way: property and get set
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        //third way: auto-property

        public int Id { get; set; }

        //

        
    }
}