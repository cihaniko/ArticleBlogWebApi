using ArticleBlogWebApi.Models;
using System.Collections.Generic;

namespace ArticleBlogWebApi.Services
{
    public interface IDBRepository<TModel>
    {
        TModel Create(TModel model);
        List<TModel> Get();
        TModel Get(string id);
        void Remove(TModel modelIn);
        void Remove(string id);
        void Update(string id, TModel model);
    }
}