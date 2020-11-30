using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
public class Person
{
    public int Id {get;set;}
    [Required(ErrorMessage = "we need first name ")]
    [Display(Name = "First Name")]
    public string FirstName {get;set;}
    [Required(ErrorMessage = "we need last name ")]
    [Display(Name = "Last Name")]
    public string SurName{get;set;}

    public string Address{get;set;}
    public char? Gender{get;set;}='F';
    public double? Salary {get;set;}
     

}