/********************************************************************
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


// List<Employee> employeeList = new List<Employee>();

// EmployeeParse employeeParser = new EmployeeParse(employeeList)
// {
//     FilePath = "Employee.csv"
// };

// employeeParser.parseCsvFile();
// employeeList = employeeParser.Data;

List<Employee> employeeList = new List<Employee>
{
    new Employee("Bob", "Johnson", 000, 15.6, "Ops Manager", "555-012-3456"),
    new Employee("John", "Smith", 001, 20.5, "Manager", "555-045-6789"),
    new Employee("Emily", "Johnson", 002, 18.75, "Developer", "555-078-9123"),
    new Employee("Michael", "Brown", 003, 22.0, "Designer", "555-111-2345"),
    new Employee("Sarah", "Davis", 004, 19.0, "Analyst", "555-131-5678"),
    new Employee("David", "Wilson", 005, 25.0, "Engineer", "555-151-8901"),
    new Employee("Jessica", "Taylor", 006, 17.5, "Marketer", "555-171-2345"),
    new Employee("Daniel", "Martinez", 007, 21.0, "Sales Rep", "555-192-6789"),
    new Employee("Ashley", "Anderson", 008, 20.0, "HR Officer", "555-212-3456"),
    new Employee("Robert", "Thomas", 009, 24.0, "Proj Lead", "555-232-6789"),
    new Employee("Lauren", "Jackson", 010, 19.5, "Researcher", "555-252-9012"),
    new Employee("James", "White", 011, 18.0, "Help Desk", "555-272-3456"),
    new Employee("Olivia", "Harris", 012, 22.5, "Accountant", "555-292-6789"),
    new Employee("William", "Martin", 013, 16.75, "IT Support", "555-303-7890"),
    new Employee("Sophia", "Thompson", 014, 23.0, "Ops Lead", "555-313-4567"),
    new Employee("Benjamin", "Garcia", 015, 20.25, "Data Spec", "555-323-8901"),
    new Employee("Mia", "Martinez", 016, 19.25, "Admin Asst", "555-333-4567"),
    new Employee("Ethan", "Robinson", 017, 21.5, "Web Dev", "555-343-6789"),
    new Employee("Isabella", "Clark", 018, 18.9, "Copywriter", "555-353-7890"),
    new Employee("Alexander", "Rodriguez", 019, 22.75, "Sys Admin", "555-363-8901"),
    new Employee("Charlotte", "Lewis", 020, 20.0, "QA Tester", "555-373-4567"),
    new Employee("Noah", "Lee", 021, 19.8, "Graphics", "555-383-6789"),
    new Employee("Amelia", "Walker", 022, 23.5, "Test Engr", "555-393-8901"),
    new Employee("Jacob", "Hall", 023, 21.25, "Prod Lead", "555-404-5678"),
    new Employee("Evelyn", "Allen", 024, 20.75, "Media Lead", "555-414-6789"),
    new Employee("Lucas", "Young", 025, 17.0, "Lab Asst", "555-4141-0830")
};

EmployeeGen employeeGen = new EmployeeGen(employeeList);
employeeGen.Start();

List<Inventory> inventoryList = new List<Inventory>
{
    new Inventory(1000047, 50, 25.99, "Books", 5.34),
    new Inventory(1142789, 29, 45.32, "Garden & Outdoor", 1.89),
    new Inventory(1097234, 47, 16.84, "Health & Household", 12.45),
    new Inventory(1204567, 12, 3.79, "Toys & Games", 3.67),
    new Inventory(1127890, 63, 29.58, "Books", 0.75),
    new Inventory(1034812, 18, 61.27, "Beauty", 9.12),
    new Inventory(1418965, 50, 12.5, "Automotive", 14.88),
    new Inventory(1259843, 36, 8.14, "Computers", 2.56),
    new Inventory(1102345, 71, 47.95, "Garden & Outdoor", 6.44),
    new Inventory(1301567, 22, 24.63, "Video Games", 11.73),
    new Inventory(1468234, 58, 33.11, "Watches", 7.29),
    new Inventory(1198765, 11, 56.78, "Sports & Outdoor", 0.5),
    new Inventory(1364890, 33, 7.02, "Musical Instruments", 4.81),
    new Inventory(1087432, 65, 39.87, "Garden & Outdoor", 10.05),
    new Inventory(1250678, 45, 1.9, "Watches", 8.23),
    new Inventory(1149876, 27, 66.24, "Computers", 13.67),
    new Inventory(1301239, 39, 14.75, "Movies & TV", 0.3),
    new Inventory(1416543, 70, 21.48, "Sports & Outdoors", 15.0),
    new Inventory(1075910, 15, 54.62, "Baby Products", 7.88),
    new Inventory(1235678, 55, 4.36, "Sports & Outdoors", 2.1),
    new Inventory(1482123, 31, 19.99, "Tools", 3.95),
    new Inventory(1108964, 44, 30.12, "Garden & Outdoor", 1.5),
    new Inventory(1399888, 68, 62.5, "Grocery", 6.78),
    new Inventory(1050321, 23, 11.11, "Video Games", 12.0),
    new Inventory(1456789, 60, 35.67, "Clothing", 8.66)
};
InventoryGen inventoryGen = new InventoryGen(inventoryList);
inventoryGen.Start();

List<Sale> saleList = new List<Sale>
{
    new Sale("New York", 95795, 84118, -11677),
    new Sale("Los Angeles", 130860, 165773, 34913),
    new Sale("Chicago", 138158, 138810, 652),
    new Sale("Houston", 101284, 76899, -24385),
    new Sale("Phoenix", 116265, 151886, 35621),
    new Sale("Dallas", 136850, 116267, -20583),
    new Sale("San Antonio", 142194, 121551, -20643),
    new Sale("San Diego", 136962, 160680, 23718),
    new Sale("San Francisco", 141023, 131394, -9629),
    new Sale("Seattle", 136685, 123556, -13129),
    new Sale("Denver", 140769, 128890, -11879),
    new Sale("Boston", 112433, 146606, 34173),
    new Sale("Las Vegas", 110311, 120740, 10429),
    new Sale("Miami", 127819, 99502, -28317),
    new Sale("Atlanta", 124188, 101777, -22411),
    new Sale("Washington", 97568, 85627, -11941),
    new Sale("Detroit", 114769, 88792, -25977),
    new Sale("Philadelphia", 158693, 153323, -5370),
    new Sale("Minneapolis", 106396, 138021, 31625),
    new Sale("Orlando", 132480, 108433, -24047),
    new Sale("Charlotte", 135658, 148001, 12343),
    new Sale("Portland", 133942, 111016, -22926),
    new Sale("Austin", 138431, 138897, 466),
    new Sale("Jacksonville", 127747, 122612, -5135),
    new Sale("Indianapolis", 130189, 166193, 36004)
};
SalesGen saleGen = new SalesGen(saleList);
saleGen.Start();