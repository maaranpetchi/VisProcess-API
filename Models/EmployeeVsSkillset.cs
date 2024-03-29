﻿using System;
using System.Collections.Generic;

namespace VisProcess.Models;

public partial class EmployeeVsSkillset
{
    public int Id { get; set; }

    public int EmployeeId { get; set; }

    public string EmployeeCode { get; set; } = null!;

    public string EmployeeName { get; set; } = null!;

    public int DivisionId { get; set; }

    public string WorkingStatus { get; set; } = null!;

    public int SkillsetId { get; set; }

    public string ProficiencyLevel { get; set; } = null!;

    public bool? IsDeleted { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedUtc { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedUtc { get; set; }

    public virtual Skillset Skillset { get; set; } = null!;
}
