using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using TimesheetAPI.Models;

namespace TimesheetAPI.Data;

public partial class TimesheetSystemDbContext : DbContext
{
    public TimesheetSystemDbContext()
    {
    }

    public TimesheetSystemDbContext(DbContextOptions<TimesheetSystemDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Aua> Auas { get; set; }

    public virtual DbSet<AuaTranstion> AuaTranstions { get; set; }

    public virtual DbSet<ComplianceTable> ComplianceTables { get; set; }

    public virtual DbSet<Datum> Data { get; set; }

    public virtual DbSet<Goal> Goals { get; set; }

    public virtual DbSet<IntegrationStat> IntegrationStats { get; set; }

    public virtual DbSet<Intergration> Intergrations { get; set; }

    public virtual DbSet<Logdement> Logdements { get; set; }

    public virtual DbSet<Partner> Partners { get; set; }

    public virtual DbSet<TestImport> TestImports { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=ConnectionStrings:connectionString");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Aua>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AUA");

            entity.Property(e => e.Assetvalue)
                .HasColumnType("decimal(29, 17)")
                .HasColumnName("ASSETVALUE");
            entity.Property(e => e.Awxclient).HasColumnName("AWXCLIENT");
            entity.Property(e => e.Cashprovider).HasColumnName("CASHPROVIDER");
            entity.Property(e => e.Datemonthsql).HasColumnName("DATEMONTHSQL");
            entity.Property(e => e.Enhancedmappingaua).HasColumnName("ENHANCEDMAPPINGAUA");
            entity.Property(e => e.Entityid).HasColumnName("ENTITYID");
            entity.Property(e => e.Entitystatusaua).HasColumnName("ENTITYSTATUSAUA");
            entity.Property(e => e.Fund).HasColumnName("FUND");
            entity.Property(e => e.Partner).HasColumnName("PARTNER");
            entity.Property(e => e.Policynumber).HasColumnName("POLICYNUMBER");
            entity.Property(e => e.Product).HasColumnName("PRODUCT");
            entity.Property(e => e.Productprovider).HasColumnName("PRODUCTPROVIDER");
            entity.Property(e => e.SqlPartnerCheck).HasColumnName("SQL_PARTNER_CHECK");
            entity.Property(e => e.Xpusercode).HasColumnName("XPUSERCODE");
        });

        modelBuilder.Entity<AuaTranstion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AUA_Transtions");

            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.ExclCash).HasColumnName("exclCash");
            entity.Property(e => e.InclCash).HasColumnName("inclCash");
            entity.Property(e => e.Partner).HasColumnName("partner");
            entity.Property(e => e.SqlpartnerCheck).HasColumnName("sqlpartner_check");
            entity.Property(e => e.TransctId).HasColumnName("transct_id");
        });

        modelBuilder.Entity<ComplianceTable>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Compliance_table");

            entity.Property(e => e.DateMonth).HasColumnName("Date_Month");
            entity.Property(e => e.Iar).HasColumnName("IAR");
            entity.Property(e => e.MastheadNewBusiness).HasColumnName("Masthead_New_Business");
            entity.Property(e => e.MastheadReviews).HasColumnName("Masthead_Reviews");
            entity.Property(e => e.TotalAuditScoreAsAt).HasColumnName("Total_Audit_Score_as_at");
            entity.Property(e => e.XpUserCode).HasColumnName("XP_User_Code");
        });

        modelBuilder.Entity<Datum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("data");

            entity.Property(e => e.Aua).HasColumnName("aua");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.Id).HasColumnName("id");
        });

        modelBuilder.Entity<Goal>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("goals");

            entity.Property(e => e.Goal1).HasColumnName("goal");
            entity.Property(e => e.Percentage).HasColumnName("percentage");
            entity.Property(e => e.Xpusercode).HasColumnName("xpusercode");
        });

        modelBuilder.Entity<IntegrationStat>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("INTEGRATION_STATS");

            entity.Property(e => e.Datedatemonth).HasColumnName("DATEDATEMONTH");
            entity.Property(e => e.Integrationsentityid).HasColumnName("INTEGRATIONSENTITYID");
            entity.Property(e => e.Integrationsstrategy).HasColumnName("INTEGRATIONSSTRATEGY");
            entity.Property(e => e.NameAndSurname).HasColumnName("NAME_AND_SURNAME");
            entity.Property(e => e.PgpUsage).HasColumnName("PGP_Usage");
            entity.Property(e => e.SqlPartnerCheck).HasColumnName("SQL_PARTNER_CHECK");
            entity.Property(e => e.WiUsage7).HasColumnName("WI_USAGE7");
            entity.Property(e => e.XPlanImportsUsage).HasColumnName("xPlan_Imports_Usage");
            entity.Property(e => e.Xpusercode).HasColumnName("XPUSERCODE");
        });

        modelBuilder.Entity<Intergration>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("intergrations");

            entity.Property(e => e.Datedatemonth).HasColumnName("DATEDATEMONTH");
            entity.Property(e => e.Integrationsentityid).HasColumnName("INTEGRATIONSENTITYID");
            entity.Property(e => e.Integrationsstrategy).HasColumnName("INTEGRATIONSSTRATEGY");
            entity.Property(e => e.PgpUsage).HasColumnName("PGP_Usage");
            entity.Property(e => e.SqlPartnerCheck).HasColumnName("SQL_PARTNER_CHECK");
            entity.Property(e => e.WiUsage7).HasColumnName("WI_USAGE7");
            entity.Property(e => e.XPlanImportsUsage).HasColumnName("xPlan_Imports_Usage");
            entity.Property(e => e.Xpusercode).HasColumnName("XPUSERCODE");
        });

        modelBuilder.Entity<Logdement>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("logdements");

            entity.Property(e => e.ClientName).HasColumnName("client_name");
            entity.Property(e => e.DateMonth).HasColumnName("date_month");
            entity.Property(e => e.EnhancedCount).HasColumnName("enhanced_count");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.OptimizedCount).HasColumnName("optimized_count");
            entity.Property(e => e.Partner).HasColumnName("partner");
            entity.Property(e => e.PartnerDirectedAdviceCount).HasColumnName("partner_directed_advice_count");
            entity.Property(e => e.SqlPartnerCheck).HasColumnName("sql_partner_check");
            entity.Property(e => e.StandardizedCount).HasColumnName("standardized_count");
        });

        modelBuilder.Entity<Partner>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("partners");

            entity.Property(e => e.AuaTranspartnerCheck).HasColumnName("AUA_Transpartner_check");
            entity.Property(e => e.PartnerId).HasColumnName("partnerId");
            entity.Property(e => e.PartnerName).HasColumnName("partnerName");
            entity.Property(e => e.Tier).HasColumnName("tier");
        });

        modelBuilder.Entity<TestImport>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Test_Import");

            entity.Property(e => e.Aua)
                .HasColumnType("money")
                .HasColumnName("aua");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.Id).HasColumnName("id");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Email);

            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .HasColumnName("password");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
