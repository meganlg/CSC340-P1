using System;
using CsvHelper;

namespace DocumentNS;

public class EmployeeParse : Parse<Employee>
{
    public override List<Employee> Data { get; set; } = new List<Employee>();

    public EmployeeParse(List<Employee> data) {
        Data = data;
    }

    public override void parseData(string path) {
        // do something
    }
}