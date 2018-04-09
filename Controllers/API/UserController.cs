using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreVueJsPOC.Controllers.API
{
    [Produces("application/json")]
    [Route("api/user")]
    public class UserController : Controller
    {
        // GET: api/User
        [HttpGet]
        public IEnumerable<UserData> Get()
        {
            List<UserData> users = new List<UserData>();
            for (int i = 1; i <= 10; i++)
            {
                users.Add(new UserData
                {
                    Id = i,
                    FirstName = $"First Name {i}",
                    LastName = $"Last Name {i}",
                });
            }

            return users;
        }

        [HttpGet("{id}")]
        // GET: api/User/5
        public UserData GetById(int id)
        {
            return new UserData
            {
                Id = id,
                FirstName = $"First Name {id}",
                LastName = $"Last Name {id}",
            };
        }

        // POST: api/User
        [HttpPost]
        public void Post([FromBody]UserData user)
        {
        }


        public class UserData
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

    }
}
