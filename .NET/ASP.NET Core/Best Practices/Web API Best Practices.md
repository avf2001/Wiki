* [.NET 8](#net-8)
  * [Return Result](#return-result)
~~~csharp
// https://github.com/KevinDockx/AspNetCoreAsyncBestPracticesJetBrainsWebinar/blob/master/Books.Api/Controllers/BooksController.cs
using AutoMapper;
using Books.Api.Models;
using Books.Api.Services;
using Books.Legacy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Books.Api.Controllers
{
    [Route("api/books")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBooksRepository _booksRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<BooksController> _logger;
        private readonly ComplicatedPageCalculator _complicatedPageCalculator;

        public BooksController(IBooksRepository booksRepository,
            IMapper mapper, ILogger<BooksController> logger,
            ComplicatedPageCalculator complicatedPageCalculator)
        {
            _booksRepository = booksRepository
                               ?? throw new ArgumentNullException(nameof(booksRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _complicatedPageCalculator = complicatedPageCalculator ??
                                         throw new ArgumentNullException(nameof(complicatedPageCalculator));
        }
    
        [HttpGet("{id}", Name = "GetBook")]
        // Therefore, the MVC framework provides the ProducesResponseType attribute so
        // that we can declare a possible return type – a status code pair.
        // It is enough to decorate each action method with as many ProducesResponseType attributes
        // as there are possible types, that is, possible status code pairs, as shown in the following code:
        [ProducesResponseType(typeof(MyReturnType), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(MyErrorReturnType), StatusCodes.Status404NotFound)]
        // If no object is returned along a path, we can just declare the status code, as follows:
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> GetBookWithBookCovers(Guid id)
        {
            var bookEntity = await _booksRepository.GetBookAsync(id);

            if (bookEntity == null)
            {
                return NotFound();
            }

            // get bookcovers
            var bookCovers = await _booksRepository.GetBookCoversAsync(id);

            // map book & covers into one BookWithCovers
            var mappedBook = _mapper.Map<BookWithCovers>(bookEntity);
            return Ok(_mapper.Map(bookCovers, mappedBook));
        }

        
        [HttpPost]
        public async Task<IActionResult> CreateBook([FromBody] BookForCreation book)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
        
            var bookEntity = _mapper.Map<Entities.Book>(book);
            _booksRepository.AddBook(bookEntity);

            await _booksRepository.SaveChangesAsync();

            // Fetch (refetch) the book from the data store, including the author
            await _booksRepository.GetBookAsync(bookEntity.Id);

            return CreatedAtRoute("GetBook",
                new {id = bookEntity.Id},
                _mapper.Map<Models.Book>(bookEntity));
        } 
 
        #region Additional sample: GetBook with GetBookPages (code smell sample)

        // sample of bad code - don't await CPU-bound calls in ASP.NET Core, 
        // call them in sync instead
        //[HttpGet("{id}", Name = "GetBook")]
        //public async Task<IActionResult> GetBook(Guid id)
        //{
        //    var bookEntity = await _booksRepository.GetBookAsync(id);
        //        
        //    if (bookEntity == null)
        //    {
        //        return NotFound();
        //    }
        //
        //    _logger.LogInformation($"ThreadId when entering GetBook: " +
        //  $"{System.Threading.Thread.CurrentThread.ManagedThreadId}");

        //    var pages = await GetBookPages(id);

        //    return Ok(_mapper.Map<Book>(bookEntity));
        //}
        
//        private async Task<int> GetBookPages(Guid id)
//        {
//            return await Task.Run(() =>
//            {
//                _logger.LogInformation($"ThreadId when calculating the amount of pages: " +
//                                       $"{System.Threading.Thread.CurrentThread.ManagedThreadId}");
//
//                return _complicatedPageCalculator.CalculateBookPages(id);
//            });
//        }

        #endregion

        #region Additional sample: call legacy CPU-bound code (GetBook with direct call into CalculateBookPages)

//        [HttpGet("{id}", Name = "GetBook")]
//        public async Task<IActionResult> GetBook(Guid id)
//        {
//            var bookEntity = await _booksRepository.GetBookAsync(id);
//                
//            if (bookEntity == null)
//            {
//                return NotFound();
//            }
//        
//            var pages = _complicatedPageCalculator.CalculateBookPages(id);
//        
//            return Ok(_mapper.Map<Book>(bookEntity));
//        }

        #endregion
         
    }
}
~~~

# .NET 8
## Return Result
Use Microsoft.AspNetCore.Http.TypedResults to return reults of Web API. [Reference](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.http.typedresults?view=aspnetcore-8.0).
