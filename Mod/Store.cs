﻿using System;
using System.Collections.Generic;

namespace McDonaldsAPI.Mod;

public partial class Store
{
    public int Id { get; set; }

    public string Localization { get; set; } = null!;

    public virtual ICollection<ClientOrder> ClientOrders { get; set; } = new List<ClientOrder>();

    public virtual ICollection<MenuItem> MenuItems { get; set; } = new List<MenuItem>();
}
