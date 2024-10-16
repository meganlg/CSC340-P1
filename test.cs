﻿/********************************************************************
*** NAME : Group 4	                                              ***
*** CLASS : SE 340                                                ***
*** ASSIGNMENT : Project 1                                        ***
*** DUE DATE : 10-16-24                                           ***
*** INSTRUCTOR : GAMRADT                                          ***
*********************************************************************
*** DESCRIPTION :											      ***
***															      ***
********************************************************************/
using DocumentNS;


List<Employee> employeeList = new List<Employee>();
EmployeeParse employeeParse = new EmployeeParse(employeeList)
{
    FilePath = "Employee.csv"
};
employeeParse.parseCsvFile();

EmployeeGen employeeGen = new EmployeeGen(employeeList);
employeeGen.Start();


List<Inventory> inventoryList = new List<Inventory>();
InventoryParse inventoryParse = new InventoryParse(inventoryList){
    FilePath = "Inventory.csv"
};
inventoryParse.parseCsvFile();

InventoryGen inventoryGen = new InventoryGen(inventoryList);
inventoryGen.Start();


List<Sale> saleList = new List<Sale>();
SaleParse saleParse= new SaleParse(saleList){
    FilePath = "Sale.csv"
};
saleParse.parseCsvFile();

SalesGen saleGen = new SalesGen(saleList);
saleGen.Start();