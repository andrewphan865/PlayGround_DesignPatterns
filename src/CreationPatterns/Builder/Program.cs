namespace Builder;

public class Program
{
    public static void Main()
    {
        // Construct a sales report
        var salesReportBuilder = new SalesReportBuilder();
        var reportDirector = new ReportDirector(salesReportBuilder);
        reportDirector.ConstructReport();
        var salesReport = salesReportBuilder.Build();

        Console.WriteLine("Sales Report:");
        Console.WriteLine(salesReport);
        Console.WriteLine();

        // Construct an inventory report
        var inventoryReportBuilder = new InventoryReportBuilder();
        var inventoryReportDirector = new ReportDirector(inventoryReportBuilder);
        inventoryReportDirector.ConstructReport();
        var inventoryReport = inventoryReportBuilder.Build();

        Console.WriteLine("Inventory Report:");
        Console.WriteLine(inventoryReport);
    }
}
