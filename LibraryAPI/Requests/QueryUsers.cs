namespace LibraryAPI.Requests;

public class QueryUsers
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
}