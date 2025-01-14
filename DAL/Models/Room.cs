﻿using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DAL.Models;

public partial class Room
{
    public int Id { get; set; }

    public int HotelId { get; set; }

    public int RoomNumber { get; set; }

    public string RoomType { get; set; } = null!;

    public int RoomPrice { get; set; }

    public int RoomCapacity { get; set; }


    public virtual Hotel Hotel { get; set; } = null!;
   // [JsonIgnore]
    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
}
