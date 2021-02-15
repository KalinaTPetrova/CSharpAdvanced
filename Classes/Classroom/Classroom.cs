using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ClassroomProject
{
    class Classroom
    {

        private List<Student> collection;

        public Classroom(int capacity)
        {
            Capacity = capacity;
            collection = new List<Student>();
        }
        public int Capacity { get; set; }

        public int Count { get { return collection.Count; } }

        public string RegisterStudent(Student student)
        {
            if (Count < Capacity)
            {
                collection.Add(student);
                return $"Added student {student.FirstName} {student.LastName}";
            }
            else
            {
                return $"No seats in the classroom";
            }


        }
        public string DismissStudent(string firstName, string lastName)
        {
            Student student = collection.FirstOrDefault(s => s.FirstName == firstName&&s.LastName==lastName);
            
            if (student==null)
            {
                return $"Student not found";
            }

            collection.Remove(student);
            return $"Dismissed student {student.FirstName} {student.LastName}";            


        }

        public string GetSubjectInfo(string subject)
        {
            if (!collection.Any(s => s.Subject == subject))
            {
                return $"No students enrolled for the subject";
            }

            else
            {
                    StringBuilder result = new StringBuilder();
                    result.AppendLine($"Subject: {subject}");
                    result.AppendLine($"Students:");
                foreach (var student in collection.Where(s=>s.Subject==subject))
                {

                    result.AppendLine($"{student.FirstName} {student.LastName}");

                }

                return result.ToString().Trim();
            }
        }

        public int GetStudentsCount()
        {
            return this.Count;
        }

        public Student GetStudent(string firstName, string lastName)
        {
            Student student = collection.FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName);

            return student;
        }

    }
}
