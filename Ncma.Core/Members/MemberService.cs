namespace Ncma.Core.Members {
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Repository.EFCore;
    using Repository.Models;

    public class MemberService : IMemberService {
        private readonly IMemberRepository memberRepository;

        public MemberService (IMemberRepository memberRepository) {
            this.memberRepository = memberRepository;
        }

        public async Task<MemberServiceModel> GetMemberByIdAsync (int id) {
            Member member = await memberRepository.GetAsync (id);
            return new MemberServiceModel (member);
        }

        public async Task<List<MemberServiceModel>> GetActiveMembersAsync () {
            List<Member> members = await memberRepository.GetActiveMembersAsync ();
            return members
                .Select (m => new MemberServiceModel (m))
                .ToList ();
        }
        public async Task<List<MemberServiceModel>> GetInactiveMembersAsync () {
            List<Member> members = await memberRepository.GetInactiveMembersAsync ();
            return members
                .Select (m => new MemberServiceModel (m))
                .ToList ();
        }
        public async Task<List<MemberServiceModel>> GetAllMembers () {
            List<Member> members = await memberRepository.GetMemberListAsync();

            return members
                .Select (m => new MemberServiceModel (m))
                .ToList ();
        }

        public async Task<List<MemberServiceModel>> SearchMembers (string searchTerm) {
            List<Member> members = await memberRepository.SearchAsync (searchTerm);
            return members
                .Select (m => new MemberServiceModel (m))
                .ToList ();
        }

        public async Task<MemberServiceModel> SaveMemberAsync (MemberServiceModel memberServiceModel) {
            Member member = await memberRepository
                .SaveAsync (memberServiceModel.Id, memberServiceModel.ToMember ());

            return new MemberServiceModel (member);
        }

        public async Task<MemberServiceModel> DeleteMemberAsync (int id) {
            Member member = await memberRepository.DeleteAsync (id);
            return new MemberServiceModel (member);
        }
    }
}