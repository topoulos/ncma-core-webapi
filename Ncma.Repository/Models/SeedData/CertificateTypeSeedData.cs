namespace Ncma.Repository.Models.SeedData
{
    public static class CertificateTypeSeedData
    {
        public static CertificateType[] SeedData => new[] {
            new CertificateType {  Id = 1, Name = "Rank", Description = "Rank Certificate", ValidationDurationInDays=365 },
            new CertificateType {  Id = 2, Name = "School Charter", Description = "School Charter Certificate", ValidationDurationInDays=365 },
            new CertificateType {  Id = 3, Name = "Instructor", Description = "Instructor Certificate", ValidationDurationInDays=365 },
            new CertificateType {  Id = 4, Name = "Membership", Description = "Member Certificate", ValidationDurationInDays=365 },
            new CertificateType {  Id = 5, Name = "Tenshi Rank", Description = "Tenshi Rank Certificate", ValidationDurationInDays=365 },
            new CertificateType {  Id = 6, Name = "Chief Instructor", Description = "Chief Instructor Certificate", ValidationDurationInDays=365 },
            new CertificateType {  Id = 7, Name = "Tenshi Membership", Description = "Tenshi Membership Certificate", ValidationDurationInDays=365 },
            new CertificateType {  Id = 8, Name = "Tenshi School Charter", Description = "Tenshi School Charter Certificate", ValidationDurationInDays=365 },
            new CertificateType {  Id = 9, Name = "Tenshi Instructor", Description = "Tenshi Instructor Certificate", ValidationDurationInDays=365 },
            new CertificateType {  Id = 10, Name = "Hanshi Seminar", Description = "Hanshi Seminar Certificate", ValidationDurationInDays=365 },
        };
    }
}
