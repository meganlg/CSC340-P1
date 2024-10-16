using DocumentNS;
using System.Globalization;
using CsvHelper;

class ParseExample{

    static void parseTest(string passinfilepath)
    {
        List<Inventory> inventoryList = new List<Inventory>();
        InventoryParse inventoryParse = new InventoryParse(inventoryList){
            FilePath = passinfilepath
        };
        inventoryParse.parseCsvFile();

        // now the list will be populated
        foreach (Inventory inv in inventoryList){
            Console.WriteLine(inv.ID);
            Console.WriteLine(inv.Category);
            
        }

    }
}
    