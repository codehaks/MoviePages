public class Movie
{
    public required string Name { get; set; } // reference-type
    public required int Year { get; set; } // value-type

    public override string ToString()
    {
        return Name + " - " + Year;
    }
}
