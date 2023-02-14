using System;
using System.Collections.Generic;

namespace DataAcccesLayer.Models;

public partial class TypeBedroom
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Bedroom> Bedrooms { get; } = new List<Bedroom>();
}
