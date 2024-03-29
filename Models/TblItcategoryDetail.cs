﻿using System;
using System.Collections.Generic;

namespace VisProcess.Models;

public partial class TblItcategoryDetail
{
    public int Id { get; set; }

    public int CategoryId { get; set; }

    public string Description { get; set; } = null!;

    public int DescriptionCount { get; set; }

    public int? ComplianceCount { get; set; }

    public int? NonComplianceCount { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreatedDate { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int? UpdatedBy { get; set; }
}
