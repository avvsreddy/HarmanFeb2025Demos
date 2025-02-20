using System;
using System.Collections.Generic;

namespace EFDemoApp.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string Name { get; set; } = null!;

    public decimal? Price { get; set; }

    public string? Brand { get; set; }

    public bool? IsAvailable { get; set; }
}
