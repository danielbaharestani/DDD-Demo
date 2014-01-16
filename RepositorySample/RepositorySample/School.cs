using System.Collections.Generic;

namespace RepositorySample
{
    class School
    {
        private readonly List<ClassRoom> classRooms = new List<ClassRoom>();

        public void AddClassroom(string name)
        {
            classRooms.Add(new ClassRoom(this, name));
        }
    }
}