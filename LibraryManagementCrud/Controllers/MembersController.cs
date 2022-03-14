using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagementCrud.CrudOpeartion.LibraryMembers;
using LibraryManagementCrud.Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LibraryManagementCrud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembersController : ControllerBase
    {

        LibraryMemberOperation libraryMemberOperation = new LibraryMemberOperation();
        // GET: api/<MembersController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<MembersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MembersController>
        [HttpPost]
        public void Post([FromBody] LibraryMembers memberOperation)  
        {
            libraryMemberOperation.LibraryMemberInsert(memberOperation);
        }

        // PUT api/<MembersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MembersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
