using System.ComponentModel.DataAnnotations.Schema;

public class Position 
{
    public int ID {  get; set; }
    public string PositionName { get; set; }
    public decimal Salary { get; set; }

    public int MaxCountOfEmployees {  get; set; }
    public List<Employee> Employees { get; set; }
    public int DepartmentID {  get; set; }
    public virtual Department Deparment { get; set; }
    
    
    [NotMapped]
    public Department PositionDepartment
    {
        get
        {
            return DataWorker.GetDepartmentByID(DepartmentID);
        }
    }

    [NotMapped]
    public List<Employee> PositionEmployees
    {
        get
        {
            return DataWorker.GetAllEmployeesByPositionID(ID);
        }
    }

}