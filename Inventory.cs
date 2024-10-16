/********************************************************************
*** NAME : Group 4	                                              ***
*** CLASS : SE 340                                                ***
*** ASSIGNMENT : Project 1                                        ***
*** DUE DATE : 10-16-24                                           ***
*** INSTRUCTOR : GAMRADT                                          ***
*********************************************************************
*** DESCRIPTION : Inventory is an abstract datatype that contains ***
***				  an ID, quantity, price, category, and weight	  ***
***				  property to store information regarding a 	  ***
***			      single item. All attributes are public.		  ***
***															      ***
********************************************************************/
using System;
namespace DocumentNS;
public class Inventory
{
	public int ID { get; set; }
	public int Quantity { get; set; }
	public double Price { get; set; }
	public string? Category { get; set; }
	public double Weight { get; set; }

}

