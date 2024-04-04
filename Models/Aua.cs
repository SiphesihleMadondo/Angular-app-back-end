using System;
using System.Collections.Generic;

namespace TimesheetAPI.Models;

public partial class Aua
{
    public string? Partner { get; set; }

    public int? Xpusercode { get; set; }

    public string? Entitystatusaua { get; set; }

    public int? SqlPartnerCheck { get; set; }

    public string? Awxclient { get; set; }

    public string? Entityid { get; set; }

    public string? Product { get; set; }

    public string? Fund { get; set; }

    public string? Enhancedmappingaua { get; set; }

    public decimal? Assetvalue { get; set; }

    public string? Productprovider { get; set; }

    public string? Policynumber { get; set; }

    public DateOnly? Datemonthsql { get; set; }

    public string? Cashprovider { get; set; }
}
