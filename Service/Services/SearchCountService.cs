using Data.Infrastructure;
using Data.Repositories;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class SearchCountService : ISearchCountService
    {
        private readonly ISearchCountRepository SearchCountRepository;
        private readonly IUnitOfWork unitOfWork;

        public SearchCountService(ISearchCountRepository SearchCountRepository, IUnitOfWork unitOfWork)
        {
            this.SearchCountRepository = SearchCountRepository;
            this.unitOfWork = unitOfWork;
        }

        public List<SearchCount> GetSearchCounts()
        {
            List<SearchCount> SearchCounts = SearchCountRepository.GetAll().ToList();
            return SearchCounts;
        }

        public SearchCount GetSearchCountByID(int ID)
        {
            SearchCount SearchCount = SearchCountRepository.GetByID(ID);
            return SearchCount;
        }

        public void CreateSearchCount(SearchCount SearchCount)
        {
            SearchCountRepository.Add(SearchCount);
            SaveSearchCount();
        }

        public void EditSearchCount(SearchCount SearchCount)
        {
            SearchCountRepository.Edit(SearchCount.SearchCountId, SearchCount);
            SaveSearchCount();
        }

        public void SaveSearchCount()
        {
            unitOfWork.Commit();
        }


    }
}
