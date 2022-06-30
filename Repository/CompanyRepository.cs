
using Entities;
using Entities.Models;
using Entities.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CompanyRepository : RepositoryBase<Company>, ICompanyRepository
    {
        public CompanyRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {

        }

        public IEnumerable<Company> GetAllCompanies(bool trackChanges) 
        {
            //throw new Exception("Something went wrong");
            return
            FindAll(trackChanges).OrderBy(c => c.Name).ToList();

        }
    }
}
