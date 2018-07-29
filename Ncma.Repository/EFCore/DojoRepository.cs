namespace Ncma.Repository.EFCore
{
    using Models;

    public class DojoRepository : BaseRepository<Dojo>
    {
        public DojoRepository(NcmaContext context) : base(context)
        {
        }
    }
}