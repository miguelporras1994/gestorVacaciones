using System;
using System.Collections.Generic;

namespace DataAcccesLayer.Models;

public partial class Hotel
{
    public int Id { get; set; }

    public string NameHotel { get; set; } = null!;

    public int? Idcity { get; set; }

    public virtual ICollection<Bedroom> Bedrooms { get; } = new List<Bedroom>();

    public virtual City? IdcityNavigation { get; set; }
}
