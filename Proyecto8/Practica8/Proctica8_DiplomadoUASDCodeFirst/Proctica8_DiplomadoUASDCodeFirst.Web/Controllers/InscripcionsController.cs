using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Practica8_DiplomadoUASDCodeFirst.Model.DAL;
using Practica8_DiplomadoUASDCodeFirst.Model.Models;

namespace Proctica8_DiplomadoUASDCodeFirst.Web.Controllers
{
    public class InscripcionsController : Controller
    {
        private EstudianteContext db = new EstudianteContext();

        // GET: Inscripcions
        public ActionResult Index()
        {
            var inscripciones = db.Inscripciones.Include(i => i.Curso).Include(i => i.Estudiante);
            return View(inscripciones.ToList());
        }

        // GET: Inscripcions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Inscripcion inscripcion = db.Inscripciones.Find(id);
            if (inscripcion == null)
            {
                return HttpNotFound();
            }
            return View(inscripcion);
        }

        // GET: Inscripcions/Create
        public ActionResult Create()
        {
            ViewBag.CursoID = new SelectList(db.Cursoss, "CursoID", "Descripcion");
            ViewBag.EstudianteID = new SelectList(db.Estudiantes, "EstudianteID", "Nombre");
            return View();
        }

        // POST: Inscripcions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "InscripcionID,CursoID,EstudianteID,Semestre")] Inscripcion inscripcion)
        {
            if (ModelState.IsValid)
            {
                db.Inscripciones.Add(inscripcion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CursoID = new SelectList(db.Cursoss, "CursoID", "Descripcion", inscripcion.CursoID);
            ViewBag.EstudianteID = new SelectList(db.Estudiantes, "EstudianteID", "Nombre", inscripcion.EstudianteID);
            return View(inscripcion);
        }

        // GET: Inscripcions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Inscripcion inscripcion = db.Inscripciones.Find(id);
            if (inscripcion == null)
            {
                return HttpNotFound();
            }
            ViewBag.CursoID = new SelectList(db.Cursoss, "CursoID", "Descripcion", inscripcion.CursoID);
            ViewBag.EstudianteID = new SelectList(db.Estudiantes, "EstudianteID", "Nombre", inscripcion.EstudianteID);
            return View(inscripcion);
        }

        // POST: Inscripcions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "InscripcionID,CursoID,EstudianteID,Semestre")] Inscripcion inscripcion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(inscripcion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CursoID = new SelectList(db.Cursoss, "CursoID", "Descripcion", inscripcion.CursoID);
            ViewBag.EstudianteID = new SelectList(db.Estudiantes, "EstudianteID", "Nombre", inscripcion.EstudianteID);
            return View(inscripcion);
        }

        // GET: Inscripcions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Inscripcion inscripcion = db.Inscripciones.Find(id);
            if (inscripcion == null)
            {
                return HttpNotFound();
            }
            return View(inscripcion);
        }

        // POST: Inscripcions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Inscripcion inscripcion = db.Inscripciones.Find(id);
            db.Inscripciones.Remove(inscripcion);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
