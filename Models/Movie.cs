using System.ComponentModel.DataAnnotations;

namespace Mission_6_Nelson.Models;

public class Movie
{
    [Key]
    public int MovieId { get; set; }
    public string Category { get; set; }
    public string Title { get; set; }
    public string Year { get; set; }
    public string Director { get; set; }
    public string Rating { get; set; }
    
    public bool? Edited { get; set; } // Not required
    public string? LentTo { get; set; } // Not required
    public string? Notes { get; set; } // Not required
}