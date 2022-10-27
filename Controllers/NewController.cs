/*
ARELY MARTINEZ 
OCT 25, 2022 9:30PM
REVERSE IT END POINT 
THIS PROGRAM WILL MAKE IT SO THAT THE USER 
CAN ENTER A GROUP OF CHARACTER. AND ON POSTMAN 
IT WILL REPSOND WITH THE USERS ORIGINAL INPUT 
AND A NEW OUPUT OF THIER INPUT BUT REVERESED.
PEER REVIEW: NAME -Mark A Ramirez- REVIEW works well you can input waht you want and it will reverse it
*/

using Microsoft.AspNetCore.Mvc;

namespace day2ApiInput.Controllers;

[ApiController]
[Route("[controller]")]
public class NewController : ControllerBase
{
    [HttpGet]
    [Route("Reverse")]
    //localHost9000/Input/Name
    public string Reverse()
    {
        return "ENTER IN SOMETHING AND ILL REVERSE IT!!";
    }

    [HttpGet]
    [Route("Reverse/{orignial}")]
    //localHost9000/Input/Name
    public string ReversIt(string orignial)
    {
        char[] array = orignial.ToCharArray();
        string reverse = String.Empty;
        for (int i = array.Length - 1; i > -1; i--)
        {
            reverse += array[i];
        }
        return $"YOUR ORIGINAL INPUT: {orignial} \nYOUR INPUT BUT REVERESED: {reverse}";
    }

    //return$"This would be my return {var} "
}