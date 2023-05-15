using AutoMapper;
using BusinessLayer.InterfacesOfManagers;
using DataLayer.InterfacesOfRepo;
using EntityLayer.ResultModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ImplementationsOfManagers
{
    public class Manager<TViewModel, TModel, Id> : IManager<TViewModel, Id>
      where TViewModel : class, new()
      where TModel : class, new()
    {
        protected readonly IRepository<TModel, Id> _repo;
        protected readonly IMapper _mapper;
        protected readonly string _includeRelationalTables;

        public Manager(IRepository<TModel, Id> repo, IMapper mapper, string includeRelationalTables)
        {
            _repo = repo;
            _mapper = mapper;
            _includeRelationalTables = includeRelationalTables;
        }

        public IDataResult<TViewModel> Add(TViewModel model)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(TViewModel model)
        {
            throw new NotImplementedException();
        }

        public IDataResult<ICollection<TViewModel>> GetAll(Expression<Func<TViewModel, bool>>? filter = null)
        {
            throw new NotImplementedException();
        }

        public IDataResult<TViewModel> GetByConditions(Expression<Func<TViewModel, bool>>? filter = null)
        {
            throw new NotImplementedException();
        }

        public IDataResult<TViewModel> GetById(Id id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(TViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
