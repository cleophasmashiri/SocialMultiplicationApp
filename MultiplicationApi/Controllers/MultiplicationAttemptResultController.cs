using System;
using Calculator.Services;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace CalculatorApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MultiplicationAttemptResultController : ControllerBase
    {
        private IMultiplicationService multiplicationService;

        public MultiplicationAttemptResultController(IMultiplicationService multiplicationService)
        {
            this.multiplicationService = multiplicationService;
        }


        [HttpPost("results")]
        public void GetMultiplicationResult(MultiplicationResultAttempt attempt)
        {
            this.multiplicationService.CheckAttempt(attempt);
        }
    }
}