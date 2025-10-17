using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryAPI.Models;

public class Book
{
    [Key]
    public int id_book { get; set; }
    
    public string bookname { get; set; }
    public string author { get; set; }
    public int cost { get; set; }
    public string description { get; set; }
    
    [Required]
    [ForeignKey("Genre")]
    public int id_genre { get; set; }
    public Genre Genre { get; set; }
}