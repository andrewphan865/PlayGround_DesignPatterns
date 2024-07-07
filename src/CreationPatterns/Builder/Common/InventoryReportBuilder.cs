namespace Builder;

public class InventoryReportBuilder : ReportBuilder
{
    public override void SetTitle()
    {
        _report.Title = "Monthly Inventory Report";
    }

    public override void SetHeader()
    {
        _report.Header = "Author: Jane Smith\nDate: " + DateTime.Now.ToString("d");
    }

    public override void SetBody()
    {
        _report.Body = "Total Inventory: 10,000 items\n" +
                       "Top Products in Stock: Product X, Product Y, Product Z\n" +
                       "Inventory by Warehouse: Warehouse 1: 5,000 items, Warehouse 2: 5,000 items";
    }

    public override void SetFooter()
    {
        _report.Footer = "End of Inventory Report\n";
    }
}
