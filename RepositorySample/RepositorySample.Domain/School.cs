using System.Collections.Generic;

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


        public List<ClassRoom> ClassRooms { get; protected internal set; }

        public int ID { get { return id; } }
    }
}