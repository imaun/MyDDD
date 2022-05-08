namespace Emun.MyDDD.Contracts
{

    /// <summary>
    /// Contracts for the Domain Events
    /// </summary>
    /// <typeparam name="TEvent">A domain event type</typeparam>
    public interface IDomainEventHandler<in TEvent> where TEvent : IDomainEvent
    {
        
        /// <summary>
        /// Implement domain event handling logic.
        /// </summary>
        /// <param name="domainEvent"></param>
        void Handle(TEvent domainEvent);    
    }
    
}