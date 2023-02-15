using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace clms.Models;

public class User
{
    [Key]
    public int Id { get; set; }
    [Required]
    [DisplayName("User Name")]
    public string Uid { get; set; }
    [Required]
    public string Password { get; set; }
    [Required]
    [DisplayName("User Type")]
    public string UserType { get; set; }
    public string Email { get; set; }

}
