using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
public class EmployeeController: Controller
{
  public ActionResult Index()
  {

    var employees = Person.GetData();
      return View(employees);
  }
  public ActionResult Detail([FromQuery] int id)
  {
    var employees = Person.GetData();
    Person employee = employees.FirstOrDefault(x=> x.Id == id);
    return View(employee);
  }
  

  public ActionResult Add()
  {
    return View();
  }

  [HttpPost]

  public ActionResult<string> Add([FromForm] Person person)
  {
    return "Record saved";
  }
}
