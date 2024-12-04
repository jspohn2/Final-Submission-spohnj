using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace BasicMVC.Models
{
    public class MVCUser : IdentityUser
    {
        [Key]
        public override string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName() => FirstName + " " + LastName;

        public int GetNumericID() => int.Parse(Id);
    }
}