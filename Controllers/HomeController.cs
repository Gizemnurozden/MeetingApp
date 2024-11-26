using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MeetingApp.Models;

namespace MeetingApp.Controllers;

public class HomeController : Controller
{
    
   
    public IActionResult Index()
    {
       int time =DateTime.Now.Hour;

       ViewBag.Selamlama= time > 12 ? "İyi Günler":"Günaydın";
        int UserCount = Repository.Users.Where(i => i.WillAttend == true).Count();

       //ViewData["Selamlama"] = time > 12 ? "İyi Günler":"Günaydın";
       var meetingInfo = new MeetingInfo(){
            Id = 1, 
            Location = "İstanbul, Abc Kongre Merkezi",
            Date = new DateTime(2024,12,12,20,0,0),
            NumberOfPeople= UserCount
       };
        return View(meetingInfo);
    }


}
