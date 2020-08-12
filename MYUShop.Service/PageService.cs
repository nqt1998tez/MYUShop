using MYUShop.Data.Infrastructure;
using MYUShop.Data.Repositories;
using MYUShop.Model.Models;

namespace MYUShop.Service
{
    public interface IPageService
    {
        Page GetByAlias(string alias);
    }

    public class PageService : IPageService
    {
        private IPageRepository _pageRepository;
        private IUnitOfWork _unitOfWork;

        public PageService(IPageRepository pageRepository, IUnitOfWork unitOfWork)
        {
            this._pageRepository = pageRepository;
            this._unitOfWork = unitOfWork;
        }

        public Page GetByAlias(string alias)
        {
            return _pageRepository.GetSingleByCondition(x => x.Alias == alias);
        }
    }
}