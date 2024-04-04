using System;
using System.Collections.Generic;

namespace TimesheetAPI.Models;

public partial class Logdement
{
    public int Id { get; set; }

    public int SqlPartnerCheck { get; set; }

    public string Partner { get; set; } = null!;

    public int EnhancedCount { get; set; }

    public int OptimizedCount { get; set; }

    public int PartnerDirectedAdviceCount { get; set; }

    public int StandardizedCount { get; set; }

    public DateTime DateMonth { get; set; }

    public string? ClientName { get; set; }
}
