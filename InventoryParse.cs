using System;
namespace DocumentNS;

public class InventoryParse : Parse<Inventory>
{
    public override List<Inventory> Data { get; set; } = new List<Inventory>();

    public InventoryParse(List<Inventory> data) {
        Data = data;
    }

    public override void parseData(string path) {
        // do something
    }
}