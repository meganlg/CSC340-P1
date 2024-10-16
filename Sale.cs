/********************************************************************
*** NAME : Group 4	                                              ***
*** CLASS : SE 340                                                ***
*** ASSIGNMENT : Project 1                                        ***
*** DUE DATE : 10-16-24                                           ***
*** INSTRUCTOR : GAMRADT                                          ***
*********************************************************************
*** DESCRIPTION : Sale is an abstract datatype that contains a    ***
***				  a location, target sales, actual sales, and  	  ***
***				  difference property to store information  	  ***
***			      regarding a single sale. All attributes are 	  ***
***				  public.										  ***
***															      ***
********************************************************************/
using System;
namespace DocumentNS;
public class Sale
{
	public string? Location { get; set; }
	public double TargetSales { get; set; }
	public double ActualSales { get; set; }
	public double Difference { get; set; }
}

