using System;
using System.Collections.Generic;

namespace TimesheetAPI.Models;

public partial class ComplianceTable
{
    public int Id { get; set; }

    public DateTime DateMonth { get; set; }

    public string? Partner { get; set; }

    public string? MastheadNewBusiness { get; set; }

    public string? Iar { get; set; }

    public string? MastheadReviews { get; set; }

    public string? TotalAuditScoreAsAt { get; set; }

    public int XpUserCode { get; set; }
}
