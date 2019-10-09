using Estudos.WF.Solid.Core.Entities;
using Estudos.WF.Solid.Core.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Estudos.WF.Solid.Service.WebApi.Controllers
{
    public class ArtesMarciaisController : ApiController
    {
        private readonly IArtesMarciaisRepository _artesMarciaisRepository;

        public ArtesMarciaisController(IArtesMarciaisRepository artesMarciaisRepository)
        {
            _artesMarciaisRepository = artesMarciaisRepository;
        }

        // GET: api/ArtesMarciais
        public IEnumerable<ArtesMarciais> Get()
        {
            return _artesMarciaisRepository.GetAll();
        }

        // GET: api/ArtesMarciais/5
        public ArtesMarciais Get(Guid id)
        {
            return _artesMarciaisRepository.GetById(id);
        }

        // POST: api/ArtesMarciais
        public void Post([FromBody]ArtesMarciais arteMarcial)
        {
            _artesMarciaisRepository.Insert(arteMarcial);
            _artesMarciaisRepository.Save();
        }

        // PUT: api/ArtesMarciais/5
        public void Put(Guid id, [FromBody]ArtesMarciais arteMarcial)
        {
            arteMarcial.Id = id;
            _artesMarciaisRepository.Update(arteMarcial);
            _artesMarciaisRepository.Save();
        }

        // DELETE: api/ArtesMarciais/5
        public void Delete(Guid id)
        {
            _artesMarciaisRepository.Delete(id);
            _artesMarciaisRepository.Save();
        }
    }
}
