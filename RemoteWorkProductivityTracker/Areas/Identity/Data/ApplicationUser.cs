using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace RemoteWorkProductivityTracker.Areas.Identity.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    public int Id {  get; set; }
    [Required, EmailAddress]
    private string Email {  get; set; }
    [Required, PasswordPropertyText]
    private string Password { get; set; }
}

