namespace Builder;

public class ReportDirector
{
    private readonly ReportBuilder _reportBuilder;

    public ReportDirector(ReportBuilder reportBuilder)
    {
        _reportBuilder = reportBuilder;
    }

    public void ConstructReport()
    {
        _reportBuilder.SetTitle();
        _reportBuilder.SetHeader();
        _reportBuilder.SetBody();
        _reportBuilder.SetFooter();
    }
}
