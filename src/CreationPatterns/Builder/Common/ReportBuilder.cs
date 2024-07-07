namespace Builder;

public abstract class ReportBuilder
{
    protected Report _report = new Report();

    public abstract void SetTitle();
    public abstract void SetHeader();
    public abstract void SetBody();
    public abstract void SetFooter();

    public Report Build()
    {
        return _report;
    }
}
