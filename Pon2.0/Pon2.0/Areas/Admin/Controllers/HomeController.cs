using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pon2._0.DataModels;
using Pon2._0.Models;
using System.IO;

namespace Pon2._0.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        // GET: Admin/Home
        public ActionResult Index()
        {
            using (var ctx = new LinkEntity())
            {
                var model = new List<LinkViewModel>();

                ctx.Links.ToList().ForEach(x => model.Add(
                    new LinkViewModel {
                        Id = x.Id,
                        Description = x.Description,
                        ImgSrc = x.ImgSrc,
                        LinkAdress = x.LinkAdress,
                        Title = x.Title
                    }
                    ));
                return View(model);
            }
        }

        // GET: Admin/Home/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Home/Create
        [HttpPost]
        public ActionResult Create(LinkViewModel model, HttpPostedFileBase photoUpload)
        {
            try
            {
                using (var ctx = new LinkEntity())
                {
                    ctx.Links.Add(new LinkDataModel {
                        Id = model.Id,
                        Description = model.Description,
                        LinkAdress = model.LinkAdress,
                        Title = model.Title,
                        ImgSrc = $" /Photos/{photoUpload.FileName}"
                    });
                    ctx.SaveChanges();
                }

                photoUpload.SaveAs(Path.Combine(Server.MapPath("~/Photos"), photoUpload.FileName));

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Home/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/Home/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Home/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/Home/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
