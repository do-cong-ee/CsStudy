using System;

namespace Property
{
    class BirthdayInfo
    {
        private string name;
        private DateTime birthday;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public DateTime BirthDay
        {
            get
            {
                return this.birthday;
            }
            set
            {
                this.birthday = value;
            }
        }

        public int Age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(birthday).Ticks).Year;
            }
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            BirthdayInfo birth = new BirthdayInfo();
            birth.Name = "쿠우";
            birth.BirthDay = new DateTime(2009, 12, 04);

            Console.WriteLine($"Name : {birth.Name}");
            Console.WriteLine($"Birth day : {birth.BirthDay.ToShortDateString()}");
            Console.WriteLine($"Age : {birth.Age}");

            return;
        }
    }
}