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
        private readonly IloggerManager _logger;
        private readonly IMapper _mapper;
        public CompaniesController(IRepositoryManager repository, IloggerManager logger, IMapper mapper)
        {
            _logger =  logger;
            _repository = repository;
            _mapper = mapper;

        }

        [HttpGet]
        public IActionResult GetCompanies ()
        {
            try
            {
                var Companies = _repository.CompanyRepository.GetAllCompanies(trackChanges: false);

                var CompanyResponse = _mapper.Map<IEnumerable<CompanyResponse>>(Companies);
                

                return Ok(CompanyResponse);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(GetCompanies)} action {ex}");
                return StatusCode(500, "Internal Server Error");
            }

        }

    }
}
