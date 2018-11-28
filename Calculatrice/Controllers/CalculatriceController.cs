using Calculatrice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Calculatrice.Controllers
{
    public class CalculatriceController : Controller
    {
        // GET: Calculatrice
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(CalculatriceViewModel model, string command)
        {
            if (command == "addition")
            {
                model.Resultat = model.premierChiffre + model.deuxiemeChiffre;
            }
            if (command == "soustraction")
            {
                model.Resultat = model.premierChiffre - model.deuxiemeChiffre;
            }
            if (command == "multiplication")
            {
                model.Resultat = model.premierChiffre * model.deuxiemeChiffre;
            }
            if (command == "division")
            {
                model.Resultat = model.premierChiffre / model.deuxiemeChiffre;
            }
            if (command == "exposant")
            {
                model.Resultat = Math.Pow(model.premierChiffre, model.deuxiemeChiffre);
            }
            if (command == "moyenne")
            {
                model.Resultat = ((model.premierChiffre + model.deuxiemeChiffre) / 2);
            }
            if (command == "modulo")
            {
                model.Resultat = model.premierChiffre % model.deuxiemeChiffre;
            }
            return View(model);
        }
    }
}