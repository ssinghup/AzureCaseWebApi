using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Repository;
using WebApi.Models;
using System.Web.Http.Description;

namespace WebApi.Controllers
{

    public class CityController : GenericController<CITY>
    {

        private IGenericRepository<CITY> repository = null;

        public CityController()
        {
            this.repository = new GenericRepository<CITY>();
        }
        public CityController(IGenericRepository<CITY> repository) : base(repository)
        {
        }

       
        //[HttpGet]
        //[Route("GetAll")]
        //public IEnumerable<MAS_CITY> GetAll()
        //{
        //    return repository.GetAll();
        //}

        //[HttpGet]
        //[Route("GetByID")]
        //[ResponseType(typeof(MAS_CITY))]
        //public MAS_CITY GetByID(int id)
        //{
        //    return repository.GetByID(id);
        //}

        //[HttpPost]
        //public void Insert(MAS_CITY city)
        //{
        //    repository.Insert(city);
        //}

        //[HttpPut]
        //public void Update(MAS_CITY city)
        //{
        //    repository.Update(city);
        //}

        //[HttpDelete]
        //public void Delete(int id)
        //{
        //    repository.Delete(id);
        //}


    }
}
