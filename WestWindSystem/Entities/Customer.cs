﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WestWindSystem.Entities;

[Index("CompanyName", Name = "CompanyName")]
[Index("AddressId", Name = "UX_Customers_AddressID", IsUnique = true)]
public partial class Customer
{
    [Key]
    [Column("CustomerID")]
    [StringLength(5)]
    public string CustomerId { get; set; }

    [Required]
    [StringLength(40)]    
    public string CompanyName { get; set; }

    [Required]
    [StringLength(30)]
    public string ContactName { get; set; }

    [StringLength(30)]
    public string ContactTitle { get; set; }

    [Required]
    [StringLength(50)]
    public string ContactEmail { get; set; }

    [Column("AddressID")]
    public int AddressId { get; set; }

    [Required]
    [StringLength(24)]
    public string Phone { get; set; }

    [StringLength(24)]
    public string Fax { get; set; }

    [ForeignKey("AddressId")]
    [InverseProperty("Customer")]
    public virtual Address Address { get; set; }

    [InverseProperty("Customer")]
    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}