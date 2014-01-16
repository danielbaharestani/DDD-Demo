using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RepositorySample
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class School
    {
        private readonly List<ClassRoom> classRooms = new List<ClassRoom>();

        public void AddClassroom(string name)
        {
            classRooms.Add(new ClassRoom(this, name));
        }
    }

    class ClassRoom
    {
        private readonly School school;
        private readonly string name;

        public ClassRoom(School school, string name)
        {
            this.school = school;
            this.name = name;
        }

        public string Name
        {
            get { return name; }
        }

        public School School
        {
            get { return school; }
        }

        public IEnumerable<Studnet> Studnets
        {
            get; set;
        }
    }


    class RegistrationService
    {
        public void RegisterStudent(ClassRoom classRoom, Studnet studnet)
        {
            
        }
    }

    class SchoolRepository
    {
        public School FindSchool(string name)
        {
            
        }
    }
}
