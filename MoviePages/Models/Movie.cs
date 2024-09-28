using System.ComponentModel.DataAnnotations;

public class Movie
{
    public int Id { get; set; }


    [MinLength(3, ErrorMessage = "Name is Too short!")]
    [StringLength(10,ErrorMessage ="Name Too long!")]
    public required string Name { get; set; } // reference-type

    [Range(1900, 2025,ErrorMessage = "Year must be between {1} and {2}.")]
    public required int Year { get; set; } // value-type

    public override string ToString()
    {
        return Name + " - " + Year;
    }
}
