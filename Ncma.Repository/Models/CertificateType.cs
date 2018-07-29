using System;
using System.Collections.Generic;

namespace Ncma.Repository.Models
{
    public class CertificateType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? ValidationDurationInDays { get; set; }

        public List<Certificate> Certificates { get; set; }
    }
}
