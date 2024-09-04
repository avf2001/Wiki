using MediatR;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ReferenceProject.Presentation.Razor.Pages
{
    public class IndexModel : PageModel
    {
        #region Поля

        private readonly ILogger<IndexModel> _logger;
        private readonly IMediator _mediator;

        #endregion

        #region Конструктор

        public IndexModel(ILogger<IndexModel> logger, IMediator mediator)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        #endregion

        public void OnGet()
        {

        }
    }
}
