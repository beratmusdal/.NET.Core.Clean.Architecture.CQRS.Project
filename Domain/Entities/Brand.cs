using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Domain.Entities;

public class Brand : Entity<Guid>
{
    public string Name { get; set; }

    public Brand()
    {
        CreatedDate = DateTime.UtcNow;
        UpdatedDate = DateTime.UtcNow;
        DeletedDate = DateTime.UtcNow;
    }

    public Brand(Guid id, string name) : base(id)
    {
        Name = name;
        CreatedDate = DateTime.UtcNow;
        UpdatedDate = DateTime.UtcNow;
        DeletedDate = DateTime.UtcNow;
    }
    //public string Name { get; set; }
    //public Brand()
    //{

    //}
    //public Brand(Guid id, string name)
    //{
    //    Id = id;
    //    Name = name;
    //}
}

