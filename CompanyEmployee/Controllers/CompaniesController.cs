using Contracts;
using Entities.DataTransfereObjects;
using Entities.RepositoryInterfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using AutoMapper;

using System.Collections.Generic;

namespace CompanyEmployee.Controllers
{
    [Route("api/Companies")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        //private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        public CompaniesController(IRepositoryManager repository, IMapper mapper)
        {
          
            _repository = repository;
            _mapper = mapper;
              

        }

        [HttpGet]
        public IActionResult GetCompanies ()
        {
            

            var Companies = _repository.CompanyRepository.GetAllCompanies(trackChanges: false);




            var CompanyResponse = _mapper.Map<IEnumerable<CompanyResponse>>(Companies);


            throw new Exception("something went wrong");
           

           // return Ok(CompanyResponse);


        }

    }
}
