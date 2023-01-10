﻿using System;
using System.Collections.Generic;

namespace VisProcess.Models;

public partial class ViewGetInvoiceMasterforDayDiff
{
    public int Id { get; set; }

    public string? InvoiceNo { get; set; }

    public DateTime? InvoiceDate { get; set; }

    public int? DateDifference { get; set; }

    public string ReferenceNo { get; set; } = null!;

    public DateTime ReferenceDate { get; set; }

    public int CustomerId { get; set; }

    public decimal? ProductValue { get; set; }

    public decimal Discount { get; set; }

    public decimal InvoiceValue { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsCancelled { get; set; }

    public bool IsSample { get; set; }

    public DateTime CreatedUtc { get; set; }

    public DateTime? UpdatedUtc { get; set; }

    public int CreatedBy { get; set; }

    public int? UpdatedBy { get; set; }

    public bool IsOutstanding { get; set; }

    public DateTime? PrimaryDateTime { get; set; }

    public int? PrimaryUpdatedBy { get; set; }

    public DateTime? SecondaryDateTime { get; set; }

    public int? SecondaryUpdatedBy { get; set; }

    public int? BillingCycleId { get; set; }

    public decimal? ArtInvoiceAmount { get; set; }

    public decimal? DigiInvoiceAmount { get; set; }

    public decimal? RoundOff { get; set; }

    public decimal? ArtWaiver { get; set; }

    public decimal? DigiWaiver { get; set; }

    public decimal? Waiver { get; set; }

    public decimal? ReceivableValue { get; set; }

    public decimal? TotalInvoiceValue { get; set; }

    public int? TransactionId { get; set; }
}
