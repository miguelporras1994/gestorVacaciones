using System;
using System.Collections.Generic;

namespace DataAcccesLayer.Models;

public partial class Season
{
    public int Id { get; set; }

    public string NameSeason { get; set; } = null!;

    public virtual ICollection<PriceBedroom> PriceBedrooms { get; } = new List<PriceBedroom>();
}
