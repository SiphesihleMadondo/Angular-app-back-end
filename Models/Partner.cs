using System;
using System.Collections.Generic;

namespace TimesheetAPI.Models;

public partial class Partner
{
    public int PartnerId { get; set; }

    public string? PartnerName { get; set; }

    public int? AuaTranspartnerCheck { get; set; }

    public string? Tier { get; set; }
}
