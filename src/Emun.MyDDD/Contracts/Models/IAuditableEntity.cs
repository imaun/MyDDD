using System;

namespace Emun.MyDDD.Contracts {

    /// <summary>
    /// Base interface for entities that has audit properties.
    /// </summary>
    /// <typeparam name="TUserId"></typeparam>
    public interface IAuditableEntity<TUserId>
    {
         
        DateTime CreatedDateTime { get; set; }

        DateTime? ModifiedDateTime { get; set; }

        TUserId? CreatedByUserId { get; set; }

        TUserId? ModifiedByUserId { get; set; }
    }
}