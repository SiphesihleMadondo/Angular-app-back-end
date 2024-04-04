using System;
using System.Collections.Generic;

namespace TimesheetAPI.Models;

public partial class Datum
{
    public int Id { get; set; }

    public DateTimeOffset Date { get; set; }

    public double Aua { get; set; }
}
