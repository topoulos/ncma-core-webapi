using System;
using System.Collections.Generic;

namespace Ncma.Repository.Models
{
    public class Dojo : IDataModel
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public string Name { get; set; }
        public string Style { get; set; }
        
        public List<DojoInstructor> DojoInstructors { get; set; }
        public List<Certificate> Certificates { get; set; }
    }
}
