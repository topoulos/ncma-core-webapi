namespace Ncma.Core.Members
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IMemberService
    {
        Task<MemberServiceModel> GetMemberByIdAsync(int id);
        Task<List<MemberServiceModel>> GetActiveMembersAsync();
        Task<List<MemberServiceModel>> GetInactiveMembersAsync();
        Task<List<MemberServiceModel>> GetAllMembers();
        Task<List<MemberServiceModel>> SearchMembers(string searchTerm);
        Task<MemberServiceModel> SaveMemberAsync(MemberServiceModel memberServiceModel);

        Task<MemberServiceModel> DeleteMemberAsync(int id);
    }
}