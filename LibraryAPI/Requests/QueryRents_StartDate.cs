namespace LibraryAPI.Requests;

public class QueryRents_StartDate
{ 
    public int id_book {get; set;}
    public int id_user {get; set;}
    public DateOnly date_start {get; set;}
}