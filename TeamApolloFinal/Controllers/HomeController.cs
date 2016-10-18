﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity.Infrastructure;
using System.Data.Entity;
using TeamApolloFinal.Models;

namespace TeamApolloFinal.Controllers
{
    public class HomeController : Controller
    {
        public MotivationaldbEntities dbContext = new MotivationaldbEntities();

        public List<CarouselData> dotnet = new List<CarouselData>()
          { new CarouselData(){linkUrl= "https://social.msdn.microsoft.com/search/en-US", src=@"Content/Images/MSDN.jpg", alt="Owl Image"} ,
            new CarouselData() {  linkUrl= "https://dotnetcademy.net/", src=@"Content\Images\Dotnetcademy.jpg", alt="Owl Image"},
            new CarouselData() { linkUrl= "https://www.reddit.com/r/dot_NET_Development/", src=@"Content\Images\RedditNet.jpg", alt="Owl Image"},
            new CarouselData() { linkUrl= "https://trello.com", src=@"Content\Images\Trello.jpg", alt="Owl Image"},
            new CarouselData() { linkUrl= "http://www.onlineprogrammingbooks.com/visualbasic-net/", src=@"Content\Images\.NetEbook.jpg", alt="Owl Image"},
            new CarouselData() { linkUrl= "http://devproconnections.com/windows-development/learn-net-framework-c-no-prior-coding-experience", src=@"Content\Images\Devproconnect.jpg", alt="Owl Image"},
            new CarouselData() { linkUrl= "https://blog.rackspace.com/how-i-learned-microsoft-net", src=@"Content\Images\.NetBlog.jpg", alt="Owl Image"},
            new CarouselData() { linkUrl= "http://www.memrise.com/course/700708/learn-net-framework/", src=@"Content\Images\Memrise.jpg", alt="Owl Image"},
            new CarouselData() { linkUrl= "http://www.teachertube.com/video/best-way-to-learn-net-framework-423724?utm_source=video-google&utm_medium=video-view&utm_term=video&utm_content=video-page&utm_campaign=video-view-page", src=@"Content\Images\TeacherTube.jpg", alt="Owl Image"},
            new CarouselData() { linkUrl= "https://www.pluralsight.com/blog/software-development/learning-path-understanding-net-framework", src=@"Content\Images\.NetBlog.jpg", alt="Owl Image"}
            };
        public List<CarouselData> java = new List<CarouselData>()
            {new CarouselData() { linkUrl= "https://www.reddit.com/r/java", src=@"/Content/Images/MDSN.jpg", alt="Owl Image"} ,
            new CarouselData() {  linkUrl= "https://go.java/index.html", src=@"/Content/Images/Go.Java.jpg", alt="Owl Image"},
            new CarouselData() { linkUrl= "http://www.learnjavaonline.org/", src=@"/Content/Images/W3Schools.jpg", alt="Owl Image"},
            new CarouselData() { linkUrl= "http://www.oracle.com/technetwork/java/index-jsp-135888.html", src=@"/Content/Images/Oracle.jpg", alt="Owl Image"},
            new CarouselData() {  linkUrl= "https://trello.com/", src=@"/Content/Images/Trello.jpg", alt="Owl Image"},
            new CarouselData() {  linkUrl= "https://www.sololearn.com/Course/Java/", src=@"/Content/Images/SoloLearn.jpg", alt="Owl Image"},
            new CarouselData() {  linkUrl= "http://www.javaworld.com/article/2076075/learn-java/core-java-learn-java-from-the-ground-up.html", src=@"/Content/Images/JavaWorld.jpg", alt="Owl Image"},
            new CarouselData() {  linkUrl= "https://www.codementor.io/learn-java", src=@"/Content/Images/Codementor.jpg", alt="Owl Image"},
            new CarouselData() {  linkUrl= "https://www.simplilearn.com/resources-to-learn-java-programming-article", src=@"/Content/Images/Simplilearn.jpg", alt="Owl Image"},
            new CarouselData() {  linkUrl= "https://www.learneroo.com/modules/11", src=@"/Content/Images/Learneroo.jpg", alt="Owl Image"}
            };

        public List<CarouselData> all = new List<CarouselData>()
            { new CarouselData() {linkUrl = "https://slack.com/", src =@"/Content/Images/Slack.jpg", alt="Owl Image" },
              new CarouselData() {linkUrl = "http://github.com", src =@"/Content/Images/github.jpg", alt="Owl Image" },
              new CarouselData() {linkUrl = "https://www.reddit.com/r/learnprogramming/", src =@"/Content/Images/Reddit.jpg", alt="Owl Image" },
              new CarouselData() {linkUrl = "http://www.w3schools.com/", src =@"/Content/Images/W3Schools.jpg", alt="Owl Image" },
              new CarouselData() {linkUrl = "https://www.khanacademy.org/computing/computer-programming", src =@"/Content/Images/KhanAcademy.jpg", alt="Owl Image" },
              new CarouselData() {linkUrl = "http://stackoverflow.com/", src =@"/Content/Images/StackOverflow.jpg", alt="Owl Image" },
              new CarouselData() {linkUrl = "https://www.codecademy.com/", src =@"/Content/Images/Codeacademy.jpg", alt="Owl Image" },
              new CarouselData() {linkUrl = "https://www.edx.org/course/subject/computer-science", src =@"/Content/Images/EdX.jpg", alt="Owl Image" },
              new CarouselData() {linkUrl = "https://techcrunch.com/", src =@"/Content/Images/TechCrunch.jpg", alt="Owl Image" },
              new CarouselData() {linkUrl = "https://codefights.com/", src =@"/Content/Images/Codefights.jpg", alt="Owl Image" },
              new CarouselData() {linkUrl = "https://www.freecodecamp.com/", src =@"/Content/Images/Freecodecamp.jpg", alt="Owl Image" },
              new CarouselData() {linkUrl = "https://www.udacity.com/nanodegree", src =@"/Content/Images/Udacity.jpg", alt="Owl Image" },
              new CarouselData() {linkUrl = "https://startbootstrap.com/", src =@"/Content/Images/Bootstrap.jpg", alt="Owl Image" },
              new CarouselData() {linkUrl = "https://interfacelift.com/", src =@"/Content/Images/Interfacelift.jpg", alt="Owl Image" },
              new CarouselData() {linkUrl = "https://cordova.apache.org/", src =@"/Content/Images/Cordova.jpg", alt="Owl Image" },
              new CarouselData() {linkUrl = "http://www.codewars.com/", src =@"/Content/Images/Codewars.jpg", alt="Owl Image" },
              new CarouselData() {linkUrl = "https://www.codingame.com/start", src =@"/Content/Images/CodinGame.jpg", alt="Owl Image" },
              new CarouselData() {linkUrl = "http://gizmodo.com/", src =@"/Content/Images/Gizmodo.jpg", alt="Owl Image" },
              new CarouselData() {linkUrl = "http://stackoverflow.com/users/story/join", src =@"/Content/Images/Developer+Story.jpg", alt="Owl Image" },
              new CarouselData() {linkUrl = "http://lifehacker.com/", src =@"/Content/Images/LifeHacker.jpg", alt="Owl Image" },
            };


        public ActionResult Index()
        {
            List<Apollo> dbQuotes = dbContext.Apolloes.ToList();
            //List<Apollo> quoteDisplayed = new List<Apollo>();

            RandomNumberGenerator randNum = new RandomNumberGenerator();
            int randQuoteID = randNum.NumberBetween(1, dbQuotes.Count());

            foreach (Apollo quote in dbQuotes)
            {
                if (quote.QuoteID == randQuoteID)
                {
                    //quoteDisplayed.Add(quote);

                    //return View(quoteDisplayed);
                    ViewBag.Quote = quote.Motivation.ToString();
                }
            }

             List<CarouselData> dotnet = new List<CarouselData>()
          { new CarouselData(){linkUrl= "https://social.msdn.microsoft.com/search/en-US", src=@"Content\Images\MDSN.jpg", alt="Owl Image"} ,
            new CarouselData() {  linkUrl= "https://dotnetcademy.net/", src=@"/Content/Images/Dotnetcademy.jpg", alt="Owl Image"},
            new CarouselData() { linkUrl= "https://www.reddit.com/r/dot_NET_Development/", src=@"/Content/Images/RedditNet.jpg", alt="Owl Image"},
            new CarouselData() { linkUrl= "https://trello.com", src=@"/Content/Images/Trello.jpg", alt="Owl Image"},
            new CarouselData() { linkUrl= "http://www.onlineprogrammingbooks.com/visualbasic-net/", src=@"/Content/Images/.NetEbook.jpg", alt="Owl Image"},
            new CarouselData() { linkUrl= "http://devproconnections.com/windows-development/learn-net-framework-c-no-prior-coding-experience", src=@"/Content/Images/Devproconnect.jpg", alt="Owl Image"},
            new CarouselData() { linkUrl= "https://blog.rackspace.com/how-i-learned-microsoft-net", src=@"/Content/Images/.NetBlog.jpg", alt="Owl Image"},
            new CarouselData() { linkUrl= "http://www.memrise.com/course/700708/learn-net-framework/", src=@"/Content/Images/Memrise.jpg", alt="Owl Image"},
            new CarouselData() { linkUrl= "http://www.teachertube.com/video/best-way-to-learn-net-framework-423724?utm_source=video-google&utm_medium=video-view&utm_term=video&utm_content=video-page&utm_campaign=video-view-page", src=@"/Content/Images/TeacherTube.jpg", alt="Owl Image"},
            new CarouselData() { linkUrl= "https://www.pluralsight.com/blog/software-development/learning-path-understanding-net-framework", src=@"/Content/Images/.NetBlog.jpg", alt="Owl Image"}
            };



            
            List<CarouselData> java = new List<CarouselData>()
            {new CarouselData() { linkUrl= "https://www.reddit.com/r/java", src=@"/Content/Images/MDSN.jpg", alt="Owl Image"} ,
            new CarouselData() {  linkUrl= "https://go.java/index.html", src=@"/Content/Images/Go.Java.jpg", alt="Owl Image"},
            new CarouselData() { linkUrl= "http://www.learnjavaonline.org/", src=@"/Content/Images/W3Schools.jpg", alt="Owl Image"},
            new CarouselData() { linkUrl= "http://www.oracle.com/technetwork/java/index-jsp-135888.html", src=@"/Content/Images/Oracle.jpg", alt="Owl Image"},
            new CarouselData() {  linkUrl= "https://trello.com/", src=@"/Content/Images/Trello.jpg", alt="Owl Image"},
            new CarouselData() {  linkUrl= "https://www.sololearn.com/Course/Java/", src=@"/Content/Images/SoloLearn.jpg", alt="Owl Image"},
            new CarouselData() {  linkUrl= "http://www.javaworld.com/article/2076075/learn-java/core-java-learn-java-from-the-ground-up.html", src=@"/Content/Images/JavaWorld.jpg", alt="Owl Image"},
            new CarouselData() {  linkUrl= "https://www.codementor.io/learn-java", src=@"/Content/Images/Codementor.jpg", alt="Owl Image"},
            new CarouselData() {  linkUrl= "https://www.simplilearn.com/resources-to-learn-java-programming-article", src=@"/Content/Images/Simplilearn.jpg", alt="Owl Image"},
            new CarouselData() {  linkUrl= "https://www.learneroo.com/modules/11", src=@"/Content/Images/Learneroo.jpg", alt="Owl Image"}
            };

         List<CarouselData> all = new List<CarouselData>()
            { new CarouselData() {linkUrl = "https://slack.com/", src =@"/Content/Images/Slack.jpg", alt="Owl Image" },
              new CarouselData() {linkUrl = "http://github.com", src =@"/Content/Images/github.jpg", alt="Owl Image" },
              new CarouselData() {linkUrl = "https://www.reddit.com/r/learnprogramming/", src =@"/Content/Images/Reddit.jpg", alt="Owl Image" },
              new CarouselData() {linkUrl = "http://www.w3schools.com/", src =@"/Content/Images/W3Schools.jpg", alt="Owl Image" },
              new CarouselData() {linkUrl = "https://www.khanacademy.org/computing/computer-programming", src =@"/Content/Images/KhanAcademy.jpg", alt="Owl Image" },
              new CarouselData() {linkUrl = "http://stackoverflow.com/", src =@"/Content/Images/StackOverflow.jpg", alt="Owl Image" },
              new CarouselData() {linkUrl = "https://www.codecademy.com/", src =@"/Content/Images/Codeacademy.jpg", alt="Owl Image" },
              new CarouselData() {linkUrl = "https://www.edx.org/course/subject/computer-science", src =@"/Content/Images/EdX.jpg", alt="Owl Image" },
              new CarouselData() {linkUrl = "https://techcrunch.com/", src =@"/Content/Images/TechCrunch.jpg", alt="Owl Image" },
              new CarouselData() {linkUrl = "https://codefights.com/", src =@"/Content/Images/Codefights.jpg", alt="Owl Image" },
              new CarouselData() {linkUrl = "https://www.freecodecamp.com/", src =@"/Content/Images/Freecodecamp.jpg", alt="Owl Image" },
              new CarouselData() {linkUrl = "https://www.udacity.com/nanodegree", src =@"/Content/Images/Udacity.jpg", alt="Owl Image" },
              new CarouselData() {linkUrl = "https://startbootstrap.com/", src =@"/Content/Images/Bootstrap.jpg", alt="Owl Image" },
              new CarouselData() {linkUrl = "https://interfacelift.com/", src =@"/Content/Images/Interfacelift.jpg", alt="Owl Image" },
              new CarouselData() {linkUrl = "https://cordova.apache.org/", src =@"/Content/Images/Cordova.jpg", alt="Owl Image" },
              new CarouselData() {linkUrl = "http://www.codewars.com/", src =@"/Content/Images/Codewars.jpg", alt="Owl Image" },
              new CarouselData() {linkUrl = "https://www.codingame.com/start", src =@"/Content/Images/CodinGame.jpg", alt="Owl Image" },
              new CarouselData() {linkUrl = "http://gizmodo.com/", src =@"/Content/Images/Gizmodo.jpg", alt="Owl Image" },
              new CarouselData() {linkUrl = "http://stackoverflow.com/users/story/join", src =@"/Content/Images/DeveloperStory.jpg", alt="Owl Image" },
              new CarouselData() {linkUrl = "http://lifehacker.com/", src =@"/Content/Images/LifeHacker.jpg", alt="Owl Image" },
            };

        ViewBag.everything = all;

            return View(dbQuotes);
        }
        [HttpPost]
        public ActionResult Index(FormCollection form)
        {
            List<Apollo> dbQuotes = dbContext.Apolloes.ToList();
            //List<Apollo> quoteDisplayed = new List<Apollo>();

            RandomNumberGenerator randNum = new RandomNumberGenerator();
            int randQuoteID = randNum.NumberBetween(1, dbQuotes.Count());

            foreach (Apollo quote in dbQuotes)
            {
                if (quote.QuoteID == randQuoteID)
                {
                    //quoteDisplayed.Add(quote);

                    //return View(quoteDisplayed);
                    ViewBag.Quote = quote.Motivation.ToString();
                }
            }


            List<CarouselData> everything;
            switch (form["track"])
            {
                case "java":
                    everything = java;
                    break;
                case "net":
                    everything = dotnet;
                    break;
                default:
                    everything = all;
                    break;
            }


            ViewBag.everything = everything;

            return View(dbQuotes);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User admin)
        {
            foreach (User name in dbContext.Users.ToList())
            {
                if ((name.UserName == admin.UserName) && (name.Password == admin.Password))
                {
                    return RedirectToAction("DisplayQuotes");
                }
                else
                {
                    ViewBag.InvalidLogIn = "Your username/password is incorrect";
                    return View();
                }
            }

            return View();
        }

        public ActionResult DisplayQuotes()
        {
            List<Apollo> dbQuotes = dbContext.Apolloes.ToList();

            return View(dbQuotes);
        }

        public ActionResult DeleteQuote(int id)
        {
            Apollo deleteQuote = dbContext.Apolloes.Find(id);

            if(deleteQuote == null)
            {
                ViewBag.EditStatus = "Quote not found";

                return View("DeleteQuote");
            }

            return View(deleteQuote);
        }

        [HttpPost, ActionName("DeleteQuote")]
        public ActionResult DeleteConfirm(int id)
        {
            try
            {
                Apollo deleteQuote = dbContext.Apolloes.Find(id);
                dbContext.Apolloes.Remove(deleteQuote);
                dbContext.SaveChanges();

                return RedirectToAction("DisplayQuotes");
            }
            catch
            {
                ViewBag.DeleteStatus = "Quote not deleted";
                return View();
            }
        }

        [HttpGet]
        public ActionResult AddQuote()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddQuote(FormCollection collection)
        {
            try
            {
                Apollo newQuote = new Apollo();

                newQuote.Motivation = Request.Form["Motivation"];

                dbContext.Apolloes.Add(newQuote);
                dbContext.SaveChanges();

                ViewBag.AddQuoteStatus = "You have added a new quote";

                return View("AddQuote");
            }
            catch
            {
                ViewBag.AddQuoteStatus = "The quote was not added";

                return View("AddQuote");
            }
        }
          [HttpGet]
        public ActionResult Register()
        {
            return View();

        }
        [HttpPost]
        public ActionResult Register(FormCollection Collection)
        {
            try
            {
                Student addStudent = new Student();
                addStudent.FirstName = Request.Form["FirstName"];
                addStudent.LastName = Request.Form["LastName"];
                addStudent.Email = Request.Form["Email"];
                //addStudent.Track = Request.Form["Track"];

                //if ((addStudent.Track.ToLower() == ".net") || (addStudent.Track.ToLower()== "java"))
                if ((Request.Form["Track"].ToLower() == ".net") || (Request.Form["Track"].ToLower() == "java"))
                {
                    addStudent.Track = Request.Form["Track"];


                }
                else
                {
                    ViewBag.StudentStatus = "Please enter .net or java";
                    return View("Register");
                }
                dbContext.Students.Add(addStudent);
                dbContext.SaveChanges();
                return View("ConfirmRegister", addStudent);

            }
            catch
            {
                ViewBag.StudentStatus = "You were not added please try again.";
                return View("Register");
            }
        }
        public ActionResult DisplayStudents()
        {
            List<Student> dbStudents = dbContext.Students.ToList();

            return View(dbStudents);
        }


    }
}
