using System;
using System.Collections.Generic;

namespace TimesheetAPI.Models;

public partial class Goal
{
    public int Id { get; set; }

    public int Xpusercode { get; set; }

    public double Goal1 { get; set; }

    public int Percentage { get; set; }
}
