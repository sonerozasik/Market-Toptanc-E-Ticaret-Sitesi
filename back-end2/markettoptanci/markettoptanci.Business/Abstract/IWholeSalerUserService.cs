using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using markettoptanci.Entities;

namespace markettoptanci.Business.Abstract
{
    public interface IWholeSalerUserService
    {
        List<WholeSalerUser> GetAllWholeSalerUsers();

        WholeSalerUser GetWholeSalerUserById(int id);

        WholeSalerUser CreateWholeSalerUser(WholeSalerUser wholeSalerUser);

        WholeSalerUser UpdateWholeSalerUser(WholeSalerUser wholeSalerUser);

        WholeSalerUser DeleteWholeSalerUser(int id);
    }
}
