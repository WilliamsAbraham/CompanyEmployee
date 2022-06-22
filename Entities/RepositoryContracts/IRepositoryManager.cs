﻿

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.RepositoryContracts
{
    public interface IRepositoryManager
    {
        ICompanyRepository CompanyRepository { get; }
        IEmployeeRepository EmployeeRepository { get; }     
        void Save();
    }
}
