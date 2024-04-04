using System;
using System.Collections.Generic;

namespace TimesheetAPI.Models;

public partial class IntegrationStat
{
    public DateOnly? Datedatemonth { get; set; }

    public int? Xpusercode { get; set; }

    public int? SqlPartnerCheck { get; set; }

    public string? NameAndSurname { get; set; }

    public string? Integrationsstrategy { get; set; }

    public string? Integrationsentityid { get; set; }

    public int? WiUsage7 { get; set; }

    public int? XPlanImportsUsage { get; set; }

    public int? PgpUsage { get; set; }
}
