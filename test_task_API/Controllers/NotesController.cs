using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using test_task_API.Models;
using Moq;

namespace test_task_API.Controllers
{
    public class NotesController : ApiController
    {
        static INotesRest db = new Database();
        

        //INotesRest commands = new INotesRest();
        // GET: api/Notes
        public IEnumerable<Note> Get()
        {
            
            return db.GetAll();
        }

        // GET: api/Notes/5
        public Note Get(int id)
        {
            return db.Get(id);
        }

        // POST: api/Notes
        public void Post([FromBody]Note note)
        {
            db.Create(note);
        }

        // PUT: api/Notes/5
        public void Put(int id, [FromBody]Note note)
        {
            db.Update(id, note);
        }

        // DELETE: api/Notes/5
        public void Delete(int id)
        {
            db.Delete(id);
        }
    }
}
