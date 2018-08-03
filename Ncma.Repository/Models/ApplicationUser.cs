using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Ncma.Repository.Models
{
  [Table("AspNetUsers")]
    public class ApplicationUser: IdentityUser
    {
    }
}