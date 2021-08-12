using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetLearner.SignalRPoll.Hubs;

namespace NetLearner.SignalRPoll
{
    public class HomeController : Controller
    {
        private ChatHub chat;

        public HomeController(ChatHub _chatHub)
        {
            this.chat = _chatHub;
            var l = _chatHub.SendMessage("IncomingPowerShellUser", "connecting").Result;
        }

        // POST: HomeController/Create
        [HttpPost]
        [Route("Chat2")]
        public async Task<ActionResult> SendMessageAsync([FromBody] TestResults results)
        {
            try
            {
                //using (var chat = new ChatHub())
                //{
                //    var l = chat.SendMessage("PowerShell", msg).Result;
                //}                
                var l3 = this.chat.SendMessage("testMessage", results.msg).Result;
                var l4 = this.chat.SendMessage("testInt", $"#{results.testint}").Result;

                return Content("OK!");
            }
            catch
            {
                return Content("FAIL!");
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

        public class TestResults
        {
            public string msg { get; set; }
            public int testint { get; set; }
        }
    }
}