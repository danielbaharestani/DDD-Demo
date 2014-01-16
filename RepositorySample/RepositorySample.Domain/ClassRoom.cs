using System.Collections.Generic;

namespace RepositorySample.Domain
{
   public  class ClassRoom
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
}