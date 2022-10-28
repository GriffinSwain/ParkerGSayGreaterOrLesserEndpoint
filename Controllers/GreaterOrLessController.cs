//Griffin Parker
//Say Hello - Endpoint
//October 28, 2022
//This program takes two numbers from the user through the URL, inserts them in to an equation and displays the sum of the two numbers 
//Peer Review - nicolas acosta the code works and pretty simple not much to say because this the 3rd time we redoing this
//https://localhost:xxxx/GreaterOrLess/GreaterOrLess/{num1}/{num2}

using Microsoft.AspNetCore.Mvc;

namespace ParkerGSayGreaterOrLesserEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class GreaterOrLessController : ControllerBase
{
    [HttpGet]
    [Route("GreaterOrLess/{num1}/{num2}")]
    public string GreaterLess(int num1, int num2)
    {
    if (num1 > num2) return (num1 + " is greater than "+ num2);
    if (num1 < num2) return (num1 + " is lesser than " + num2);
    if (num1 == num2) return (num1 + " is equal to " + num2);
    return "You should not be able to reach this code -_-";
    }
}
