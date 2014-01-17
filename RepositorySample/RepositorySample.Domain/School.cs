using System.Collections.Generic;
using System.Linq;

namespace RepositorySample.Domain
{
    public class School
    {
        private readonly int id;

        public School(int id)
        {
            this.id = id;
            ClassRooms = new List<ClassRoom>();
        }

        public void AssignClassroom(string name)
        {
            ClassRooms.Add(new ClassRoom(this, name));
        }

        public List<ClassRoom> ClassRooms { get; set; }

        public int ID { get { return id; } }
    }
}