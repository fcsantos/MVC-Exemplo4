using System.Web.Mvc;
using CrudMVC_MongoDB.Models;
using MongoDB.Bson;
using MongoDB.Driver.Builders;
using System.Collections.Generic;
using System;

namespace CrudMVC_MongoDB.Controllers
{
    public class HomeController : Controller
    {
        private readonly AlunoDB context = new AlunoDB();

        // GET: Home
        public ActionResult Index()
        {
            var Alunos = context.Alunos.FindAll().SetSortOrder(SortBy<Aluno>.Ascending(a => a.Curso));
            return View(Alunos);
        }

        public ActionResult Create()
        {
            var model = new Aluno();
            if (model.Gender == null)
            {
                model.Gender = new SelectList(new List<SelectListItem>()
                {
                    new SelectListItem() { Text= "Masculino", Value = "Masculino" },
                    new SelectListItem() { Text= "Feminino", Value = "Masculino"}
                }, "Value", "Text");
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult Create(Aluno _aluno)
        {
            if (ModelState.IsValid)
            {                
                context.Alunos.Insert(_aluno);
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Edit(string Id)
        {
            var aluno = context.Alunos.FindOneById(new ObjectId(Id));
            if (aluno.Gender == null)
            {
                aluno.Gender = new SelectList(new List<SelectListItem>()
                    {
                        new SelectListItem() { Text= "Masculino", Value = "Masculino" },
                        new SelectListItem() { Text= "Feminino", Value = "Feminino"}
                    }, "Value", "Text");
            }
            return View(aluno);
        }
        [HttpPost]
        public ActionResult Edit(Aluno _aluno)
        {
            if (ModelState.IsValid)
            {
                context.Alunos.Save(_aluno);
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public ActionResult Delete(string Id)
        {
            var del = context.Alunos.FindOneById(new ObjectId(Id));
            return View(del);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(string Id)
        {
            var del = context.Alunos.Remove(Query.EQ("_id", new ObjectId(Id)));
            return RedirectToAction("Index");
        }
    }
}