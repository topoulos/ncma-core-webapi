using System;
using System.Collections.Generic;

namespace Ncma.Repository.Models
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Microsoft.EntityFrameworkCore.Metadata.Internal;

    public class Certificate: IDataModel
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public int? MemberId { get; set; }

        [ForeignKey("MemberId")]
        public Member Member { get; set; }
        public int? DojoId { get; set; }

        [ForeignKey("DojoId")]
        public Dojo Dojo { get; set; }
        public int? CertificateTypeId { get; set; }

        [ForeignKey("CertificateTypeId")]
        public CertificateType CertificateType { get; set; }
        public string RankText { get; set; }
        public int? InstructorId { get; set; }

        [ForeignKey("InstructorId")]
        public Member Instructor { get; set; }
        public int? InstructorTypeId { get; set; }
        [ForeignKey("InstructorTypeId")]
        public InstructorType InstructorType { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ThruDate { get; set; }
        public bool Completed { get; set; }
        public string BatchId { get; set; }
    }
}
