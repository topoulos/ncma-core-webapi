namespace Ncma.Repository.Models.SeedData
{
    public static class MemberTypeSeedData
    {
        public static MemberType[] SeedData => new[] {
            new MemberType { Id = 1, Name = "SCHOOL CHARTER MEMBER" },
            new MemberType { Id = 2, Name = "INDIVIDUAL" },
            new MemberType { Id = 3, Name = "INSTRUCTOR" },
            new MemberType { Id = 4, Name = "SCHOOL CHARTER HOLDER" },
        };
    }
}
