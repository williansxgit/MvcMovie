using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models;

public class Movie
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Campo com preenchimento obrigatório")]
    public string? Title { get; set; }

    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }
    public string? Generic { get; set; }
    public decimal Price { get; set; }
}