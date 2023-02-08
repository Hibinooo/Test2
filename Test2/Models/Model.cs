using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Test2.Models
{

public partial class Model
{
    public int Id { get; set; }

    public int? BrandId { get; set; }

    
    public string? Name { get; set; }

    public bool Active { get; set; }

    public virtual Brand? Brand { get; set; }
}
}
