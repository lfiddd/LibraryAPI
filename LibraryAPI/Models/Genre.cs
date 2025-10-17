using System.ComponentModel.DataAnnotations;

namespace LibraryAPI.Models;

public class Genre
{
    [Key]
    public int id_genre { get; set; }
    
    public string name { get; set; }
}