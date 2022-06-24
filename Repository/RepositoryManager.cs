using Contracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;
using Entities.RepositoryInterfaces;

namespace Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private Lazy<ICompanyRepository> _lazycompanyRepository;
        private Lazy<IEmployeeRepository> _employeeRepository;
        private RepositoryContext _repositoryContext;

        public RepositoryManager (RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
            _lazycompanyRepository = new Lazy<ICompanyRepository> (() => new CompanyRepository(_repositoryContext));
            _employeeRepository = new Lazy<IEmployeeRepository> (() => new EmployeeRepository(_repositoryContext));
        }


        public ICompanyRepository CompanyRepository => _lazycompanyRepository.Value;
                

        public IEmployeeRepository EmployeeRepository => _employeeRepository.Value;

        public void Save()
        {
            _repositoryContext.SaveChanges();
        }
    }
}
