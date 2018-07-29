namespace Ncma.Repository.EFCore
{
    using Models;

    public class CertificateRepository : BaseRepository<Certificate>
    {
        public CertificateRepository(NcmaContext context) : base(context)
        {
        }
    }
}