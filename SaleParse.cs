using System;
namespace DocumentNS;

public class SaleParse : Parse<Sale>
{
    public override List<Sale> Data { get; set; } = new List<Sale>();

    public SaleParse(List<Sale> data) {
        Data = data;
    }

    public override void parseData(string path) {
        // do something
    }


}