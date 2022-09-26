using Microsoft.AspNetCore.Mvc;
using MadLib.Models;

namespace MadLib.Controllers
{
  public class HomeController : Controller
  {
    [Route("/hello")]
    public string Hello() { return "My name is Inigo Montoya. You killed my father, prepare to die."; }

    [Route("/goodbye")]
    public string Goodbye() { return "Stop saying that!"; }

    [Route("/")]
    public ActionResult Form() { return View(); }
    
    [Route("/MadLib")]
    public ActionResult MadLib(string verbOne, string adjOne, string adjTwo, string verbTwo, string verbThree, string nounOne, string nounTwo, string verbFour)
    {
      MadLibVariable myMadLibVariable = new MadLibVariable();
      myMadLibVariable.VerbOne = verbOne;
      myMadLibVariable.AdjOne = adjOne;
      myMadLibVariable.AdjTwo = adjTwo;
      myMadLibVariable.VerbTwo = verbTwo;
      myMadLibVariable.VerbThree = verbThree;
      myMadLibVariable.NounOne = nounOne;
      myMadLibVariable.NounTwo = nounTwo;
      myMadLibVariable.VerbFour = verbFour;
      return View(myMadLibVariable);
    }
  }
}