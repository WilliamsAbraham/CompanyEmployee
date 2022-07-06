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
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        public CompaniesController(IRepositoryManager repository, IMapper mapper, ILoggerManager logger)
        {
          
            _repository = repository;
            _mapper = mapper;
            _logger = logger;
              

        }

        [HttpGet]
        public IActionResult GetCompanies ()
        {
            
            var Companies = _repository.CompanyRepository.GetAllCompanies(trackChanges: false);

            var CompanyResponse = _mapper.Map<IEnumerable<CompanyResponse>>(Companies);

           return Ok(CompanyResponse);

        }
        [HttpGet("{Id}")]
        public IActionResult GetComapnyById ( Guid Id)
        {
            var Company = _repository.CompanyRepository.GetCompany(Id, trackChanges: false);

            if (Company == null)
            {
                _logger.LogInfo($"Company with the company ID: {Id} does not exist");
                return NotFound();
            }
            else
            {
                var CompanyResponse = _mapper.Map<CompanyResponse>(Company);
                return Ok(CompanyResponse);
            }
        }

    }
}
