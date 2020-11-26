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
     public static List<Person>GetData()
     {
         //object initializer syntax
    Person emp1 = new Person() { Id=1,FirstName = "Anusha", SurName= "Tandukar", Address="Naikap", Salary= 4000.0 };
    Person emp2 = new Person() {Id= 2,FirstName = "Anisha", SurName= "Tandukar", Address="KTM", Salary= 3000.0 };
    Person emp3 = new Person() {Id= 3,FirstName = "Arisha", SurName= "Tandukar", Address="Japan", Salary= 4000.0 };
    Person emp4 = new Person() {Id= 4,FirstName = "Anu", SurName= "Rai", Address="Naikap", Salary= 8000.0 };
    Person emp5 = new Person() {Id= 5,FirstName = "Anju", SurName= "Rai", Address="Korea", Salary= 9000.0 };
    Person emp6 = new Person() {Id=6,FirstName = "Anna", SurName= "sapkota", Address="Naikap", Salary= 4000.0 };
    List<Person> employees= new List<Person>(){emp1,emp2,emp3,emp4,emp5,emp6};
      return employees;
     }

}