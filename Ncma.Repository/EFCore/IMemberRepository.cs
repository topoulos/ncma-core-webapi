namespace Ncma.Repository.EFCore
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Models;

    public interface IMemberRepository: IRepository<Member>
    {
        Task<List<Member>> GetActiveMembersAsync();
        Task<List<Member>> GetInactiveMembersAsync();
        Task<List<Member>> SearchAsync(string searchTerm);
    }
}