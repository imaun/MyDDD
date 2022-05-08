using System;

namespace Emun.MyDDD.Contracts {

    /// <summary>
    /// Simple Interface for marking Aggregates
    /// </summary>
    public interface IAggregate {


    }

    /// <summary>
    /// Generic Interface for Aggregates that has an Id.
    /// </summary>
    /// <typeparam name="TId"></typeparam>
    public interface IAggregate<TId> {

        TId Id { get; set; }
    }

    /// <summary>
    /// Generic interface for Aggeregates that has audit properties as well.
    /// </summary>
    /// <typeparam name="TId">The type of primary key</typeparam>
    /// <typeparam name="TUserId">The type of User entity primary key.</typeparam>
    public interface IAuditableAggregate<TId, TUserId> : IAuditableEntity<TUserId> {

        TId Id { get; set; }
    }
}