﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WestWindSystem.Entities;

public partial class Shipper
{
    [Key]
    [Column("ShipperID")]
    public int ShipperId { get; set; }

    [Required]
    [StringLength(40)]
    public string CompanyName { get; set; }

    [Required]
    [StringLength(24)]
    public string Phone { get; set; }

    [InverseProperty("ShipViaNavigation")]
    public virtual ICollection<Shipment> Shipments { get; set; } = new List<Shipment>();
}