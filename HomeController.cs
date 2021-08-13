using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetLearner.SignalRPoll.Hubs;
using TestResultChat;

namespace NetLearner.SignalRPoll
{
    public class HomeController : Controller
    {
        private ChatHub chat;

        public HomeController(ChatHub _chatHub) => this.chat = _chatHub;

        // POST: HomeController/Create
        [HttpPost]
        [Route("Chat2")]
        public async Task<ActionResult> SendMessageAsync([FromBody] MessageContent results)
        {
            try
            {
                var l3 = this.chat.SendMessage2("testMessage", results).Result;
                
                return Content("MessageShown!");
            }
            catch
            {
                return Content("MessageIssue!");
            }
        }

        // GET: HomeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HomeController/Edit/5
        [Route("ChatTest")]
        public ActionResult Edit()
        {
            return Content("TestOk!");
        }

        // GET: HomeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HomeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}