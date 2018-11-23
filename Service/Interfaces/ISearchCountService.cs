using Model;
using System;
using System.Collections.Generic;

namespace Service
{
    public interface ISearchCountService
    {
        List<SearchCount> GetSearchCounts();
        SearchCount GetSearchCountByID(int ID);
        void CreateSearchCount(SearchCount SearchCount);
        void EditSearchCount(SearchCount SearchCount);
        void SaveSearchCount();
    }
}
