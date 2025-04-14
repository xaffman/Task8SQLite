using System.ComponentModel.DataAnnotations.Schema;

public class Department
{
    public int ID { get; set; }
    public string DepartmentName { get; set; }
    public List<Position> Positions { get; set; }

    [NotMapped]
    public List<Position> DepartmentPositions
    {
        get
        {
            return DataWorker.GetAllPositionsByDepartmentID(ID);
        }
    }
}