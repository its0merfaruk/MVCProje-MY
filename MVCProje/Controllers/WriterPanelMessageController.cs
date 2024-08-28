﻿using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProje.Controllers
{
    public class WriterPanelMessageController : Controller
    {
        // GET: WriterPanelMessage
        MessageManager mm = new MessageManager(new EfMessageDal());
        MessageValidator messagevalidator = new MessageValidator();
        public ActionResult Inbox()
        {
            var messagelist = mm.GetListInbox();
            return View(messagelist);
        }
        public ActionResult Sendbox()
        {
            var messagelist = mm.GetListSendbox();
            return View(messagelist);
        }

        //public ActionResult GetInboxMessageDetails(int id)
        //{
        //    var values = mm.GetById(id);
        //    return View(values);
        //}
        //public ActionResult GetSendboxMessageDetails(int id)
        //{
        //    var values = mm.GetById(id);
        //    return View(values);
        //}

        //[HttpGet]
        //public ActionResult NewMessage()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public ActionResult NewMessage(Message p)
        //{

        //    ValidationResult results = messagevalidator.Validate(p);
        //    if (results.IsValid)
        //    {
        //        p.MessageDate = DateTime.Parse(DateTime.Now.ToShortDateString());
        //        mm.MessageAdd(p);
        //        return RedirectToAction("Sendbox");
        //    }
        //    else
        //    {
        //        foreach (var item in results.Errors)
        //        {
        //            ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
        //        }
        //    }

        //    return View();
        //}

        public PartialViewResult MessageListMenu()
        {
            return PartialView();
        }
    }
}