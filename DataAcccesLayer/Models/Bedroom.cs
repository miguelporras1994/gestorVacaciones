using System;
using System.Collections.Generic;

namespace DataAcccesLayer.Models;

public partial class Bedroom
{
    public int Id { get; set; }

    public int? Type { get; set; }

    public int? IdHotel { get; set; }

    public int? NumberRooms { get; set; }

    public int? NumberPerson { get; set; }

    public virtual Hotel? IdHotelNavigation { get; set; }

    public virtual ICollection<PriceBedroom> PriceBedrooms { get; } = new List<PriceBedroom>();

    public virtual TypeBedroom? TypeNavigation { get; set; }
}
