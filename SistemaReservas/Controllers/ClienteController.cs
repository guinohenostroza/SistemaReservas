﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SistemaReservas.LogicaNegocio.Interfaces;
using SistemaReservas.LogicaNegocio;
using SistemaReservas.Entidades;

namespace SistemaReservas.Controllers
{
    public class ClienteController : Controller
    {
        IClienteLN clienteLN;

        // GET: /Cliente/
        public ClienteController()
        {
            clienteLN = new ClienteLN();
        }
        public ClienteController(IClienteLN logica)
        {
            clienteLN = logica;
        }

        public ActionResult Index()
        {
            var clientes = clienteLN.LeerTodos();
            return View(clientes);
        }

        //
        // GET: /Cliente/Details/5

        public ActionResult Details(int? id)
        {
            var cliente = clienteLN.LeerCliente(
                new Cliente { ID = id.Value });
            return View(cliente);
        }

        //
        // GET: /Cliente/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Cliente/Create

        [HttpPost]
        public ActionResult Create(Cliente cliente)
        {
            if (!ModelState.IsValid)
                return View(cliente);
            clienteLN.Insertar(cliente);
            return RedirectToAction("Index");
        }

        //
        // GET: /Cliente/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Cliente/Edit/5

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

        //
        // GET: /Cliente/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Cliente/Delete/5

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
