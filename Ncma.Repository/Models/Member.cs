namespace Ncma.Repository.Models
{
    using System;

    public class Member : IDataModel
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Suffix { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public int? StateId { get; set; }
        public State State { get; set; }
        public int? CountryId { get; set; }
        public Country Country { get; set; }
        public string PostalCode { get; set; }
        public string HomePhone { get; set; }
        public string CellPhone { get; set; }
        public string Email { get; set; }
        public DateTime? Dob { get; set; }
        public int? DojoId { get; set; }
        public Dojo Dojo { get; set; }
        public int? MemberTypeId { get; set; }
        public MemberType MemberType { get; set; }
        public DateTime? DateJoined { get; set; }
        public DateTime? DateOfRank { get; set; }
        public string RankText { get; set; }
        public bool IsActive { get; set; }
        public DateTime? DateInactive { get; set; }
        public DateTime? DateLastPaid { get; set; }
        public string Comments { get; set; }
    }
}