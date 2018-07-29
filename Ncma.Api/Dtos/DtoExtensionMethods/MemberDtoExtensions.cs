namespace Ncma.Api.Dtos.DtoExtensionMethods
{
    using Core.Members;
    using Omu.ValueInjecter;

    public static class MemberDtoExtensions
    {
        public static MemberServiceModel ToServiceModel(this MemberDto memberDto)
        {
            var serviceModel = new MemberServiceModel();
            serviceModel.InjectFrom(memberDto);
            return serviceModel;
        }
    }
}