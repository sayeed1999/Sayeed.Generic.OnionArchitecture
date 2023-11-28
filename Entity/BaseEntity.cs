using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sayeed.Generic.OnionArchitecture.Entity;

public abstract class BaseEntity
{
    protected BaseEntity()
    {
        Id = 0;
        CreatedDateUtc = DateTime.UtcNow;
        UpdatedDateUtc = DateTime.UtcNow;
        DeletedDateUtc = null;
        Status = Status.Active;
    }

    public long Id { get; protected set; }
    public DateTime CreatedDateUtc { get; protected set; }
    public DateTime? UpdatedDateUtc { get; protected set; }
    public DateTime? DeletedDateUtc { get; protected set; }
    public Status Status { get; protected set; }
}
