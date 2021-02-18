using Elsayed_Mohammed_Leilla.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace Elsayed_Mohammed_Leilla.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public HomeController()
        {

            this._dbContext = new ApplicationDbContext();
        }

        public ActionResult Index(SendMessageViewModel sendMessageViewModel)
        {
            var mobileNumbers = this._dbContext.MobileNumbers
                .Where(x => x.Sent == false).Take(10).ToList();

            ViewBag.PhoneList = mobileNumbers;

            //var sendMessageViewModel = new SendMessageViewModel()
            //{
            //    MessageText = "",
            //    MobileNumberIds = new System.Collections.Generic.List<int>()
            //};

            return View(sendMessageViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SendMessage(SendMessageViewModel sendMessageViewModel)
        {
            if (ModelState.IsValid)
            {

                var message = new Message()
                {

                    MessageText = sendMessageViewModel.MessageText
                };

                _dbContext.Messages.Add(message);
                _dbContext.SaveChanges();

                foreach (var item in sendMessageViewModel.MobileNumberIds)
                {
                    var mobileNumber = _dbContext.MobileNumbers.Find(item);

                    if (mobileNumber != null)
                    {
                        mobileNumber.Sent = true;

                        _dbContext.Entry(mobileNumber).State = EntityState.Modified;

                        var messageLog = new MessageLog()
                        {

                            ActionDate = DateTime.Now,
                            MessageId = message.Id,
                            MobileNumberId = item
                        };

                        _dbContext.MessageLogs.Add(messageLog);
                    }
                }
                _dbContext.SaveChanges();


            }

            return RedirectToAction("Index", sendMessageViewModel);


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
    }
}