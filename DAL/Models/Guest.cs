using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DAL.Models;

public partial class Guest
{
    public int Id { get; set; }

    public string GuestName { get; set; } = null!;

    public string GuestEmail { get; set; } = null!;

    public string GuestPhone { get; set; } = null!;

    [JsonIgnore]
    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
}
