namespace Ncma.Repository.Models
{
    using System.ComponentModel.DataAnnotations.Schema;

    public class DojoInstructor : IDataModel
    {
        public int DojoId { get; set; }
        public Dojo Dojo { get; set; }

        public int? InstructorId { get; set; }

        [ForeignKey("InstructorId")]

        public Member Instructor { get; set; }

        public int? InstructorTypeId { get; set; }
        public InstructorType InstructorType { get; set; }
        public int Id { get; set; }
        public bool IsActive { get; set; }
    }
}