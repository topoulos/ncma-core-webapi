using System;
using System.Collections.Generic;

namespace Ncma.Repository.Models
{
    public class InstructorType
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Member> Instructors { get; set; }
    }
}
