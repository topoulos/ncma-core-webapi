namespace Ncma.Repository.Models.SeedData
{
    public static class InstructorTypeSeedData
    {
        public static InstructorType[] SeedData => new[] {
            new InstructorType { Id = 1, Name = "Instructor" },
            new InstructorType { Id = 2, Name = "Chief Instructor" }
        };
    }
}
