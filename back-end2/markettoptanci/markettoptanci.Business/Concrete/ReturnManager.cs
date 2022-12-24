using markettoptanci.Business.Abstract;
using markettoptanci.DataAccess.Abstract;
using markettoptanci.DataAccess.Concrete;
using markettoptanci.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace markettoptanci.Business.Concrete
{
    public class ReturnManager : IReturnService
    {
        private IReturnRepository _returnItemRepository;

        public ReturnManager()
        {
            _returnItemRepository = new ReturnRepository();
        }
        public Return CreateReturn(Return returnItem)
        {
            return _returnItemRepository.CreateReturn(returnItem);
        }

        public Return DeleteReturn(int id)
        {
            return _returnItemRepository.DeleteReturn(id);
        }

        public List<Return> GetAllReturns()
        {
            return _returnItemRepository.GetAllReturns();
        }

        public Return GetReturnById(int id)
        {
            if (id > 0)
            {
                return _returnItemRepository.GetReturnById(id);
            }

            throw new Exception("Id can not be less than 1!");


        }

        public Return UpdateReturn(Return returnItem)
        {
            return _returnItemRepository.UpdateReturn(returnItem);
        }
    }
}
