using FluentResults;
using MediatR;

namespace ReferenceProject.Application.Books
{
    public class BookListItemDto
    { 
    }

    public class GetListQuery : IRequest<IResult<IEnumerable<BookListItemDto>>>
    {
    }
}
