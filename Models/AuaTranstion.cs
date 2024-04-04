using System;
using System.Collections.Generic;

namespace TimesheetAPI.Models;

public partial class AuaTranstion
{
    public int TransctId { get; set; }

    public int SqlpartnerCheck { get; set; }

    public DateTimeOffset Date { get; set; }

    public double ExclCash { get; set; }

    public double InclCash { get; set; }

    public string? Partner { get; set; }
}
