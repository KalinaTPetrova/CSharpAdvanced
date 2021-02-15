using System;
using System.Collections.Generic;
using System.Text;

namespace ClassroomProject
{
    class Student

    {
        private string firstName;
        private string lastName;
        private string subject;

        public Student(string first, string last, string subject)
        {
            FirstName = first;
            LastName = last;
            Subject = subject;
        }
        public string FirstName { get=>this.firstName; set=>this.firstName=value; }
        public string LastName { get=>this.lastName; set=>this.lastName=value; }
        public string Subject { get=>this.subject; set=>this.subject=value; }

        public override string ToString()
        {
            return $"Student: First Name = {FirstName}, Last Name = {LastName}, Subject = {Subject}";
        }
    }
}
