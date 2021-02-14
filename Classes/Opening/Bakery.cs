using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BakeryOpenning
{
    class Bakery
    {

        private List<Employee> data;
        public Bakery(string bakeryName, int capacity)
        {
            BakeryName = bakeryName;
            Capacity = capacity;
            data = new List<Employee>();
        }

        public string BakeryName { get; set; }
        public int Capacity { get; set; }

        public int Count { get { return data.Count; } }


        public void Add(Employee employee)
        {
            if (Count < Capacity)
            {
                data.Add(employee);
            }
        }
        public bool Remove (string name)
        {
            Employee employee = data.FirstOrDefault(e => e.Name == name);
            if (employee == null)
            {
                return false;
            }

            data.Remove(employee);
            return true;
        }
        public Employee GetOldestEmployee()
        {
            return data.OrderByDescending(e => e.Age).FirstOrDefault();
        }

        public Employee GetEmployee(string name)
        {
            Employee employee = data.FirstOrDefault(e => e.Name == name);

            return employee;
        }

        public string Report()
        {
            StringBuilder report = new StringBuilder();

            report.AppendLine($"Employees working at Bakery {BakeryName}:");

            foreach (var item in data)
            {

                report.AppendLine(item.ToString());

            }

            return report.ToString();
        }
    }
}
