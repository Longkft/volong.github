using System;
using System.Collections.Generic;

namespace QLSanPham.Models;

public partial class Dmsanpham
{
    public int Masanpham { get; set; }

    public string? Tensanpham { get; set; }

    public int? Soluong { get; set; }

    public double? Dongia { get; set; }

    public int? Maloai { get; set; }
}
