using Faturamento.API.Business.Models;
using System;
using System.Collections.Generic;

public class Billing
{
    public string InvoiceNumber { get; set; }
    public Customers Customer { get; set; }
    public DateTime Date { get; set; }
    public DateTime DueDate { get; set; }
    public decimal TotalAmount { get; set; }
    public string Currency { get; set; }
    public List<BillingLines> BillingLines { get; set; }
}
