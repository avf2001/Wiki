using ReferenceProject.Domain.Abstractions;
using ReferenceProject.Domain.Enums;

namespace ReferenceProject.Domain.Entities
{
    public class Book : EntityBase
    {
        #region Свойства

        /// <summary>
        /// Авторы
        /// </summary>
        public ICollection<Author> Authors = [];

        /// <summary>
        /// Издательство
        /// </summary>
        public Publisher? Publisher { get; set; }

        public BookRating? Rating { get; set; }

        #endregion
    }
}
