using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace markettoptanci.DataAccess.Abstract
{
    public interface IReturnRepository
    {
        List<Return> GetAllReturn();

        Return GetReturnById(int id);

        Return CreateReturn(Return returnItem);

        Return UpdateReturn(Return returnItem);

        Return DeleteReturn(int id);
    }
}
