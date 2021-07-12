using System;
using System.ComponentModel.DataAnnotations.Schema;

public class Device
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int DeviceID { get; set; }
    public string Name { get; set; }
    public string Model { get; set; }
    public DateTime Purchase_Date { get; set; }
    public string Price { get; set; }
    public string Office { get; set; }

    public string Type { get; set; }
}


