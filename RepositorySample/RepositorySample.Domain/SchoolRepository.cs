using System.Collections.Generic;

namespace RepositorySample.Domain
{
    class SchoolRepository
    {
        public School GetSchool(int id)
        {
            var school = new School(id);

           school.ClassRooms=new List<ClassRoom>();

            return school;
        }
    }
}