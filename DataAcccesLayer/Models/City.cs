using System;
using System.Collections.Generic;

namespace DataAcccesLayer.Models;

public partial class City
{
    public int Id { get; set; }

    public string NameCity { get; set; } = null!;

    public virtual ICollection<Hotel> Hotels { get; } = new List<Hotel>();
}
