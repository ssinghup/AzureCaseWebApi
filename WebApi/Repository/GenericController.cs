using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;
using WebApi.Repository;

namespace WebApi.Controllers
{


    [RoutePrefix("api/[Controller]")]
    public class GenericController<T> : ApiController where T :class 
    {
        private IGenericRepository<T> _genericRepository;

        public GenericController() {


            this._genericRepository = new GenericRepository<T>();
        }
        public GenericController(IGenericRepository<T> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        [HttpGet]
        [Route("GetAll")]
        public IEnumerable<T> GetAll()
        {
            return _genericRepository.GetAll();
        }

        [HttpGet]
        [Route("GetByID")]
        public T GetByID(int id)
        {
            return _genericRepository.GetByID(id);
        }

        [HttpPost]        
        public void Insert(T city)
        {
            _genericRepository.Insert(city);
        }

        [HttpPut]
        public void Update(T city)
        {
            _genericRepository.Update(city);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            _genericRepository.Delete(id);
        }
    }

   
}
