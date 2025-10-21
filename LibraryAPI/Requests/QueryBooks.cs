namespace LibraryAPI.Requests;

public class QueryBooks
{
    public string bookname { get; set; }
    public string author { get; set; }
    public int cost { get; set; }
    public string description { get; set; }

    public int id_genre { get; set; }
}