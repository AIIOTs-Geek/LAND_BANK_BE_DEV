﻿using Common.Helper;
using Common.ViewModels;
using DataContext.DataClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.IRepository
{
    public interface IAssetRepository
    {        
        Task<List<GetStatusResult>> GetStatus(string statusType);
        
    }
}
