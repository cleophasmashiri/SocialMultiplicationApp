using System;
using Calculator.Services;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace CalculatorApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MultiplicationController : ControllerBase
    {
        private IMultiplicationService multiplicationService;

        public MultiplicationController(IMultiplicationService multiplicationService)
        {
            this.multiplicationService = multiplicationService;
        }


        [HttpGet("random")]
        public ActionResult<Multiplication> GetRandomMultiplication()
        {
            return this.multiplicationService.GetMultiplicationResult();
        }
    }
}