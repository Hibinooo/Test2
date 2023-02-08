using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test2.Models;

public partial class Brand
{
   
    public int Id { get; set; }

    public bool Active { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Model> Models { get; } = new List<Model>();
}
