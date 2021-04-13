using ChatWS.Models.ViewModel;
using ChatWS.Models.WS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ChatWS.Controllers
{
    public class UserController : ApiController
    {
        [HttpGet]
        public Reply Get()
        {
            Reply oReply = new Reply();
            using (Models.practicantesEntities db = new Models.practicantesEntities())
            {
                List<UserviewModel> lst = (from d in db.Persona_Jorge
                                           select new UserviewModel
                                           {
                                               Nombres = d.Nombres,
                                               ApellidoP = d.ApellidoP,
                                               ApellidoM = d.ApellidoM,
                                               Direccion = d.Direccion

                                           }).ToList();

                oReply.result = 1;
                oReply.data = lst;
            }
            return oReply;
        }

        [HttpPost]
        public Reply Register([FromBody] Models.Solicitudes.User model)
        {
            Reply oReply = new Reply();
            using (Models.practicantesEntities db = new Models.practicantesEntities())
            {
                Models.Persona_Jorge oUser = new Models.Persona_Jorge();
                oUser.Nombres = model.Nombres;
                oUser.ApellidoP = model.ApellidoP;
                oUser.ApellidoM = model.ApellidoM;
                oUser.Direccion = model.Direccion;
                oUser.Telefono = model.Telefono;

                oUser.Fecha = DateTime.Now; 
                oUser.Estatus = 1;

                db.Persona_Jorge.Add(oUser);
                db.SaveChanges();
            }
            return oReply;
        }
    }
}
