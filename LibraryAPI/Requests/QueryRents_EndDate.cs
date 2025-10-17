namespace LibraryAPI.Requests;

public class QueryRents_EndDate
{
    public int id_rent {get; set;}
    public DateOnly date_end { get; set; }
}