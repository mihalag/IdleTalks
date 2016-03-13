using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using IdleTalks.Repository;
using IdleTalks.Repository.DTO;

namespace IdleTalks.WebApiNoAuth.Controllers
{
    public class ValuesController : ApiController
    {
        private readonly IUserRepository _userRepository;

        public ValuesController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public IHttpActionResult Get(int id)
        {
            var user = _userRepository.GetUser(id);
            return Ok(user);

        }

        // POST api/values
        public IHttpActionResult AddUser(User user)
        {
            var id = _userRepository.AddUser(user);
            return Ok(id);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
