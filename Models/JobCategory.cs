﻿using System;
using System.Collections.Generic;

namespace VisProcess.Models;

public partial class JobCategory
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public int EstimatedTime { get; set; }

    public int? CategoryTime { get; set; }

    public DateTime CreatedUtc { get; set; }

    public DateTime? UpdatedUtc { get; set; }

    public int CreatedBy { get; set; }

    public int? UpdatedBy { get; set; }

    public virtual ICollection<ProcessWorkFlowMaster> ProcessWorkFlowMasters { get; } = new List<ProcessWorkFlowMaster>();
}
