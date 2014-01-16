namespace RepositorySample.Domain
{
    class SchoolRepository
    {
        public School GetSchool(int id)
        {
            var school = new School(id);
           //school.ClassRooms=
            return school;
        }
    }
}