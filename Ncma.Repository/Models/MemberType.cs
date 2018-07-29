namespace Ncma.Repository.Models
{
    using System.Collections.Generic;

    public class MemberType
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Member> Members { get; set; }

    }
}