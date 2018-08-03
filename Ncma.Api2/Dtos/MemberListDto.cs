namespace Ncma.Api2.Dtos
{
    using System;
    using Core.Members;
    using Omu.ValueInjecter;

    public class MemberListDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string DojoName { get; set; }
        public string StateAbbrev { get; set; }
        public string CountryName { get; set; }
        public string MemberTypeName { get; set; }
        public DateTime? DateJoined { get; set; }
        public DateTime? DateOfRank { get; set; }
        public string RankText { get; set; }
        public bool IsActive { get; set; }

        public MemberListDto()
        {
        }

        public MemberListDto(MemberServiceModel memberServiceModel)
        {
            this.InjectFrom(memberServiceModel);
            FullName = memberServiceModel.FirstName + " " + memberServiceModel.LastName;
            DojoName = memberServiceModel.DojoName;
        }
    }
}