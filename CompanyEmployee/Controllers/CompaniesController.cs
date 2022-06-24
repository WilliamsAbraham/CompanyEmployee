using Contracts;
using Entities.DataTransfereObjects;
using Entities.RepositoryInterfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace CompanyEmployee.Controllers
{
    [Route("api/Companies")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly IloggerManager _logger;
        public CompaniesController(IRepositoryManager repository, IloggerManager logger)
        {
            _logger =  logger;
            _repository = repository;

        }

        [HttpGet]
        public IActionResult GetCompanies ()
        {
            try
            {
                var Companies = _repository.CompanyRepository.GetAllCompanies(trackChanges: false);

                var CompanyResponse = Companies.Select(c => new CompanyResponse()
                {
                    Id = c.Id,
                    Name = c.Name,
                    FullAdress = string.Join(' ', c.Address, c.Country)


                }).ToList();

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
