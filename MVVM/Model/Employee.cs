using DocumentFormat.OpenXml.Drawing;
using System.ComponentModel.DataAnnotations.Schema;

public class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Surname {  get; set; }
    public string Phone { get; set; }
    public int PositionID {  get; set; }
    public virtual Position Position { get; set; }

    

    [NotMapped]
    public Position EmployeePosition
    {
        get
        {
            return DataWorker.GetPositionByID(PositionID);
        }
    }


}
