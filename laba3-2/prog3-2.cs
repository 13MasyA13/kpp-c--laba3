using System;

namespace laba3_2
{
    class Person
    {
        protected String aboutMe;
        
        public Person()
        {
            this.aboutMe = "I'm a Person";
        }

        public virtual void whoIsMe()
        {
            Console.WriteLine(aboutMe);
        }
    }

    class Boy : Person
    {
        public Boy()
        {
            this.aboutMe = "I'm a Boy";
        }

        public override void whoIsMe()
        {
            base.whoIsMe();
        }
    }

    class Girl : Person
    {
        public Girl()
        {
            this.aboutMe = "I'm a Girl";
        }

        public override void whoIsMe()
        {
            base.whoIsMe();
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Person boy = new Boy();
            Person girl = new Girl();
            
            Person[] masOfPerson = new Person[3];
            masOfPerson[0] = person;
            masOfPerson[1] = boy;
            masOfPerson[2] = girl;

            for (int i = 0; i < masOfPerson.Length; i++)
            {
                masOfPerson[i].whoIsMe();
            }
        }
    }
}