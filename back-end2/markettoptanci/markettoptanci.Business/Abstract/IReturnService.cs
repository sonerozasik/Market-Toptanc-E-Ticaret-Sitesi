﻿using markettoptanci.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace markettoptanci.Business.Abstract
{
    public interface IReturnService
    {
        List<Return> GetAllReturns();

        Return GetReturnById(int id);

        Return CreateReturn(Return returnItem);

        Return UpdateReturn(Return returnItem);

        Return DeleteReturn(int id);
    }
}
