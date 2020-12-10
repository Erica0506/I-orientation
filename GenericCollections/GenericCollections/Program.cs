using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> pList = new List<Person>();
            pList.Add(new Person(1, "John", "", "Shields", 29, 'M'));
            pList.Add(new Person(2, "Mary", "Matthew", "Jacobs", 35, 'F'));
            pList.Add(new Person(3, "Amber", "Carl", "Agar", 25, 'M'));
            pList.Add(new Person(4, "Kathy", "", "Berry", 21, 'F'));
            pList.Add(new Person(5, "Lena", "Ashco", "Bilton", 33, 'F'));
            pList.Add(new Person(6, "Susanne", "", "Buck", 45, 'F'));
            pList.Add(new Person(7, "Jim", "", "Brown", 38, 'M'));
            pList.Add(new Person(8, "Jane", "G", "Hooks", 32, 'F'));
            pList.Add(new Person(9, "Robert", "", "", 31, 'M'));
            pList.Add(new Person(10, "Cindy", "Preston", "Fox", 25, 'F'));
            pList.Add(new Person(11, "Gina", "", "Austin", 27, 'F'));
            pList.Add(new Person(12, "Joel", "David", "Benson", 33, 'M'));
            pList.Add(new Person(13, "George", "R", "Douglas", 55, 'M'));
            pList.Add(new Person(14, "Richard", "", "Banks", 22, 'M'));
            pList.Add(new Person(15, "Mary", "C", "Shaw", 39, 'F'));

            //1. -- - Looping through all items in the List<T>
            PrintOnConsole(pList, "1. --- Looping through all items in the List<T> ---");

            //2. -- - Filtering List<T> on single condition(Age > 35)
            List<Person> filterOne = pList.FindAll(delegate (Person p) { return p.Age > 35; });
            PrintOnConsole(filterOne, "2. --- Filtering List<T> on single condition (Age > 35) ---");

            //3. -- - Sort List<T>(Sort on FirstName)--
            List<Person> sortFName = pList;
            sortFName.Sort(delegate (Person p1, Person p2)
            {
                return p1.FirstName.CompareTo(p2.FirstName);
            });
            PrintOnConsole(sortFName, "3. --- Sort List<T> (Sort on FirstName) ---");

            //4. -- - Add new List<T> to existing List <> -
            List<Person> newList = new List<Person>();
            newList.Add(new Person(16, "Geoff", "", "Fisher", 29, 'M'));
            newList.Add(new Person(17, "Samantha", "Carl", "Baxer", 32, 'F'));
            pList.AddRange(newList);
            PrintOnConsole(pList, "4. --- Add new List<T> to existing List<> ---");

            //5. -- - Remove male employees from the List(T)
            List<Person> removeList = pList;
            removeList.RemoveAll(delegate (Person p) { return p.Sex == 'M'; });
            PrintOnConsole(removeList, "5. --- Remove male employees from the List(T) ---");


        }

        static void PrintOnConsole(List<Person> pList, string info)
        {
            Console.WriteLine(info);
            Console.WriteLine("\n{0,2} {1,7}    {2,8}      {3,8}      {4,2} {5,3}",
                "ID", "FName", "MName", "LName", "Age", "Sex");
            pList.ForEach(delegate (Person per)
            {
                Console.WriteLine("{0,2} {1,7}    {2,8}      {3,8}      {4,2} {5,3}",
                    per.ID, per.FirstName, per.MiddleName, per.LastName, per.Age, per.Sex);
            });

            Console.ReadLine();

        }

    }

    public class Person
    {
        public Person()
        {

        }

        public Person(int id, string first_name, string mid_name, string last_name, short age, char sex)
        {
            this.p_id = id;
            this.first_name = first_name;
            this.mid_name = mid_name;
            this.last_name = last_name;
            this.p_age = age;
            this.p_sex = sex;
        }

        private int p_id = -1;
        private string first_name = String.Empty;
        private string mid_name = String.Empty;
        private string last_name = String.Empty;
        private short p_age = 0;
        private char? p_sex = null;


        public int ID
        {
            get
            { return p_id;}
            set
            { p_id = value;}
        }

        public string FirstName
        {
            get
            { return first_name;}
            set
            {first_name = value;}

        }

        public string MiddleName
        {
            get
            { return mid_name;}
            set
            { mid_name = value;}
        }

        public string LastName
        {
            get
            { return last_name; }
            set
            { last_name = value; }
        }

        public short Age
        {
            get
            {return p_age; }
            set
            { p_age = value; }
        }

        public char? Sex
        {
            get
            { return p_sex;}
            set
            { p_sex = value;}
        }

     


    }
}
