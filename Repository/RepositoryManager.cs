﻿using Contracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    internal class RepositoryManager : IRepositoryManager
    {
        private ICompanyRepository _companyRepository;
        private IEmployeeRepository _employeeRepository;
        private RepositoryContext _repositoryContext;

        public RepositoryManager (RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }
        public ICompanyRepository CompanyRepository 
                {  get
                    {
                        if (_companyRepository == null)
                            _companyRepository = new CompanyRepository(_repositoryContext);
                        return _companyRepository;
                    }

                }

        public IEmployeeRepository EmployeeRepository 
        { get 
            { if(_employeeRepository == null) 
                    _employeeRepository = new EmployeeRepository(_repositoryContext);
                return _employeeRepository; 
              }
        }

        public void Save()
        {
            _repositoryContext.SaveChanges();
        }
    }
}
