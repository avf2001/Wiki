using ReferenceProject.Domain.Abstractions;

namespace ReferenceProject.Domain.Entities
{
    public class Publisher : EntityBase
    {
        #region Свойства

        public ICollection<Book> Books = [];

        #endregion
    }
}
