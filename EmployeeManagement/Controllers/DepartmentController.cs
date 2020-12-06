using System.Linq;
using System;
using Microsoft.AspNetCore.Mvc;
 
public class DepartmentController: Controller
{
      private EMSContext db;
        public DepartmentController(EMSContext _db)
        {
            db = _db;
        }
    public ActionResult Index()
    {
      
        //var db = new EMSContext();
        var departments = db.Department.ToList();
        
        return View(departments);
    }
 
       public ActionResult Add()
    {
        return View();
    }
 
        [HttpPost]
    public ActionResult<string> Add([FromForm]Department department)
    {
        db.Department.Add(department);
        db.SaveChanges();
        return RedirectToAction(nameof(Index));
    }
    public ActionResult Edit(int id)
    {
        var department = db.Department.Find(id);
        return View(department);
    }
 
    [HttpPost]
    public ActionResult Edit(Department department)
    {
        db.Department.Attach(department);
        db.Department.Update(department);
        db.SaveChanges();
        return RedirectToAction(nameof(Index));
 
    }
 
     [HttpGet]
 public ActionResult Delete([FromQuery]int id)
    {  
       var  department = db.Department.Find(id);
       return View(department);
        
    }
    [HttpPost]
public ActionResult Delete([FromForm]Department department)
    {  
       db.Department.Attach(department);
       db.Department.Remove(department);
        db.SaveChanges();
        return RedirectToAction(nameof(Index));
 
    
        
    }
}