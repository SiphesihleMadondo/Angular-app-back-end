using System;
using System.Collections.Generic;

namespace TimesheetAPI.Models;

public partial class TestImport
{
    public long Id { get; set; }

    public DateOnly? Date { get; set; }

    public decimal? Aua { get; set; }
}
