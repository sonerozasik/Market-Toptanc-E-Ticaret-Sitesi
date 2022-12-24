using markettoptanci.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace markettoptanci.DataAccess.Abstract
{
    public interface IWholeSalerUserRepository
    {
        List<WholeSalerUser> GetAllWholeSalerUsers();

        WholeSalerUser GetWholeSalerUserById(int id);

        WholeSalerUser CreateWholeSalerUser(WholeSalerUser wholeSalerUser);

        WholeSalerUser UpdateWholeSalerUser(WholeSalerUser wholeSalerUser);

        WholeSalerUser DeleteWholeSalerUser(int id);
    }
}
