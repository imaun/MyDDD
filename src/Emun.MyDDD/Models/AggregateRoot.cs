using System;
using Emun.MyDDD.Contracts;

namespace Emun.MyDDD.Models
{

    public class AggregateRoot<TKey> : Entity<TKey>, IAggregateRoot
    {
        
    }

    public class AggregateRootGuid : AggregateRoot<Guid> {

    }
    
}