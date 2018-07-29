namespace Ncma.Core.Members
{
    using Omu.ValueInjecter;
    using Repository.Models;

    public static class MemberServiceModelExtensions
    {
        public static Member ToMember(this MemberServiceModel serviceModel)
        {
            var member = new Member();
            member.InjectFrom(serviceModel);
            return member;
        }
    }
}