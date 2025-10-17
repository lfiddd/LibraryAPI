using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LibraryAPI.Models;

[Index(nameof(id_book), nameof(id_user), IsUnique = true)]
public class BookRent
{
    [Key]
    public int id_rent { get; set; }
    public DateOnly date_start { get; set; }
    public DateOnly? date_end { get; set; }
    
    [Required]
    [ForeignKey("Book")]
    public int id_book { get; set; }
    public Book Book { get; set; }
    
    [Required]
    [ForeignKey("User")]
    public int id_user { get; set; }
    public User User { get; set; }
}