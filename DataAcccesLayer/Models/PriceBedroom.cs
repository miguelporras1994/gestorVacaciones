using System;
using System.Collections.Generic;

namespace DataAcccesLayer.Models;

public partial class PriceBedroom
{
    public int Id { get; set; }

    public int? IdBedrooms { get; set; }

    public int? IdSeason { get; set; }

    public double? Price { get; set; }

    public virtual Bedroom? IdBedroomsNavigation { get; set; }

    public virtual Season? IdSeasonNavigation { get; set; }
}
