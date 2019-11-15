using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL;
using MODELS;
using System.Collections;
using System.Web.Http.Results;

namespace RestApi.Controllers
{

    public class ClienteController : ApiController
    {
        // GET: api/Cliente
        public IEnumerable Get()
        {
            ClassCliente Lg = new ClassCliente();
            var info = (from r in (IEnumerable<Cliente>)Lg.ListarClientes()
                        select new
                        {
                            codigo = r.ClienteID,
                            nombre = r.Nombre,
                            apellido = r.Apellido,
                            nit =r.NIT,
                            direccion = r.Direccion,
                            telefono1 = r.Telefono1,
                            telefono2 = r.Telefono2
                        }
                        ).ToList();

            return info.ToArray();
        }
        // POST: api/Persona
        [HttpGet]

        public JsonResult<Models.ClienteApi> Get(int id)
        {
            ClassCliente Lg = new ClassCliente();
            Models.ClienteApi personaJson = new Models.ClienteApi();
            var info = (from r in (IEnumerable<Cliente>)Lg.ListarClientes()
                        select new
                        {
                            codigo = r.ClienteID,
                            nombre = r.Nombre,
                            apellido = r.Apellido,
                            nit = r.NIT,
                            direccion = r.Direccion,
                            telefono1 = r.Telefono1,
                            telefono2 = r.Telefono2
                        }
                        ).Where(s => s.codigo == id).ToList();
            foreach (var item in info)
            {
                personaJson.codigo = item.codigo;
                personaJson.nombre = item.nombre;
                personaJson.apellido = item.apellido;
                personaJson.nit = item.nit;
                personaJson.direccion = item.direccion;
                personaJson.telefono1 = item.telefono1;
                personaJson.telefono2 = item.telefono2;
            }
            return Json<Models.ClienteApi>(personaJson);
        }


        // PUT: api/Persona/5
        [HttpPut]
        public bool UpdatePersona(Models.ClienteApi _persona)
        {
            ClassCliente Logica = new ClassCliente();
            Cliente personaModificada = new Cliente();
            personaModificada = Logica.ListarClientes().Cast<Cliente>().Where(s => s.ClienteID == _persona.codigo)
                                                        .FirstOrDefault<Cliente>();
            if (personaModificada != null)
            {
                personaModificada.Nombre = _persona.nombre;
                personaModificada.Apellido = _persona.apellido;
                personaModificada.NIT = _persona.nit;
                personaModificada.Direccion = _persona.direccion;
                personaModificada.Telefono1 = _persona.telefono1;
                personaModificada.Telefono2 = _persona.telefono2;
                Logica.ActualizarCliente(personaModificada);
            }
            else
            {
                return false;
            }
            return true;

        }



        // POST: api/Cliente
        public Cliente Post(Cliente _cliente)
        {
            ClassCliente Logica = new ClassCliente();
            string resp = Logica.NuevoCliente(_cliente.Nombre, _cliente.Apellido, _cliente.NIT, _cliente.Direccion,_cliente.Telefono1, _cliente.Telefono2);
            return _cliente;

        }
        // DELETE: api/Cliente/5
        public void Delete(int id)
        {
        }
    }
}
