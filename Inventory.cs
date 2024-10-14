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
using System;
namespace DocumentNS;
public class Inventory
{
	public int ID { get; set; }
	public int Quantity { get; set; }
	public double Price { get; set; }
	public string Category { get; set; }
	public double Weight { get; set; }

	public Inventory(int id = 0, int quantity = 0, double price = 0.0, string category = "", double weight = 0.0)
	{
		ID = id;
		Quantity = quantity;
		Price = price;
		Category = category;
		Weight = weight;
	}
}

