using Estudos.WF.Solid.Core.Entities;
using Estudos.WF.Solid.Core.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace Estudos.WF.Solid.Service.WebApi.Controllers
{
    public class AtletaController : ApiController
    {
        private readonly IAtletaRepository _atletaRepository;

        public AtletaController(IAtletaRepository atletaRepository)
        {
            _atletaRepository = atletaRepository;
        }

        // GET: api/Lutador
        public IEnumerable<Atleta> Get()
        {
            return _atletaRepository.GetAll();
        }

        // GET: api/Lutador/5
        public Atleta Get(Guid id)
        {
            return _atletaRepository.GetById(id);
        }

        // POST: api/Lutador
        public void Post([FromBody]Atleta atleta)
        {
            _atletaRepository.Insert(atleta);
            _atletaRepository.Save();
        }

        // PUT: api/Lutador/5
        public void Put(Guid id, [FromBody]Atleta atleta)
        {
            atleta.Id = id;
            _atletaRepository.Update(atleta);
            _atletaRepository.Save();
        }

        // DELETE: api/Lutador/5
        public void Delete(Guid id)
        {
            _atletaRepository.Delete(id);
            _atletaRepository.Save();
        }
    }
}
