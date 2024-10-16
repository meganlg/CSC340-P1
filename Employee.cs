﻿/********************************************************************
*** NAME : Group 4	                                              ***
*** CLASS : SE 340                                                ***
*** ASSIGNMENT : Project 1                                        ***
*** DUE DATE : 10-16-24                                           ***
*** INSTRUCTOR : GAMRADT                                          ***
*********************************************************************
*** DESCRIPTION : Employee is an abstract datatype that contains  ***
***				  a first name, last name, ID, pay, position, and ***
***				  property to store information regarding a 	  ***
***			      single employee. All attributes are public.	  ***
***															      ***
********************************************************************/
using System;
namespace DocumentNS;
public class Employee
{
	public string? FirstName { get; set; }
	public string? LastName { get; set; }
	public int ID { get; set; }
	public double Pay { get; set; }
	public string? Position { get; set; }
	public string? PhoneNumber { get; set; }

}

