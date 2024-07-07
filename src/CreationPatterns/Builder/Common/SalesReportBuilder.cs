namespace Builder;

public class SalesReportBuilder : ReportBuilder
{
    public override void SetTitle()
    {
        _report.Title = "Monthly Sales Report";
    }

    public override void SetHeader()
    {
        _report.Header = "Author: John Doe\nDate: " + DateTime.Now.ToString("d");
    }

    public override void SetBody()
    {
        _report.Body = "Total Sales: $500,000\n" +
                       "Top Products: Product A, Product B, Product C\n" +
                       "Sales by Region: Region 1: $200,000, Region 2: $300,000";
    }

    public override void SetFooter()
    {
        _report.Footer = "End of Sales Report\n";
    }
}

