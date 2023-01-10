﻿using System;
using System.Collections.Generic;

namespace VisProcess.Models;

public partial class Designation
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public DateTime CreatedUtc { get; set; }

    public DateTime? UpdatedUtc { get; set; }

    public int CreatedBy { get; set; }

    public int? UpdatedBy { get; set; }

    public virtual ICollection<Employee> Employees { get; } = new List<Employee>();

    public virtual ICollection<PricingStaffing> PricingStaffings { get; } = new List<PricingStaffing>();
}
