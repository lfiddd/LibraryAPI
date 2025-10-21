using System.ComponentModel.DataAnnotations;

namespace LibraryAPI.Models;

public class User
{
    [Key]
    public int id_user { get; set; }
    
    public string name { get; set; }
    public string description { get; set; } 
}