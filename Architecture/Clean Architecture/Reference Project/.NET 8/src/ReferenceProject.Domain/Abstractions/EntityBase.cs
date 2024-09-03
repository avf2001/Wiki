namespace ReferenceProject.Domain.Abstractions
{
    public abstract class EntityBase
    {
        #region Свойства

        public int Id { get; init; }

        #endregion

        #region Конструкторы

        // For EntityFramework
        protected EntityBase() { }

        protected EntityBase(int id) => Id = id;

        #endregion

        #region Domain Events

        private readonly List<IDomainEvent> _domainEvents = [];

        public IReadOnlyList<IDomainEvent> GetDomainEvents()
        {
            return _domainEvents.ToList();
        }

        public void ClearDomainEvents()
        {
            _domainEvents.Clear();
        }

        protected void RaiseDomainEvent(IDomainEvent domainEvent)
        {
            _domainEvents.Add(domainEvent);
        }

        #endregion        
    }
}
