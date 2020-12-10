using System;
using System.Collections.Generic;

namespace CollectionDemoConApp
{
    public class Employee
    {
        public Employee(int id, string name)
        {
            EmpId = id;
            EmpName = name;
        }

        private int _EmpId;

        public int EmpId
        {
            get { return _EmpId; }
            set { _EmpId = value; }
        }

        private string _EmpName;

        public string EmpName
        {
            get { return _EmpName; }
            set { _EmpName = value; }
        }

     
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Employee> employeeDic = new Dictionary<int, Employee>();
        
            employeeDic.Add(1, new Employee(11, "Bruce"));
            employeeDic.Add(2, new Employee(12, "jack"));
            employeeDic.Add(3, new Employee(13, "Crystal" ));
            employeeDic.Add(4, new Employee(14, "Shannnon" ));
            employeeDic.Add(5, new Employee(15, "John" ));

        
            foreach (KeyValuePair<int, Employee> item in employeeDic)
            {
                Console.WriteLine("{0} : {1}, {2}",
                    item.Key,
                    item.Value.EmpId,
                    item.Value.EmpName);
            }
        }
    }

   
}
