using FamilyTree.Models;
using FamilyTree.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FamilyTree.Controllers
{
    public class DassauGenOneController : ApiController
    {
        [Route, HttpPost]
        public HttpResponseMessage AddDassauGenOne(DassauGenOneDto dassauGenOne)
        {
            var repository = new DassauGenOneRepository();
            var result = repository.Create(dassauGenOne);
            if (result)
            {
                return Request.CreateResponse(HttpStatusCode.Created);
            }

            return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Could not create Dassau Generation, please try again later");
        }
    }

    
}
