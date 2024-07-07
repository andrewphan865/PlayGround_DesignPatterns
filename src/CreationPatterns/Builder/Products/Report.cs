namespace Builder;

public class Report
{
    public string Title { get; set; }
    public string Header { get; set; }
    public string Body { get; set; }
    public string Footer { get; set; }

    public override string ToString()
    {
        return $"Title: {Title}\nHeader: {Header}\nBody: {Body}\nFooter: {Footer}";
    }
}
