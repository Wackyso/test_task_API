using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test_task_API.Models
{
    interface INotesRest
    {
        IEnumerable<Note> GetAll();
        Note Get(int id);
        void Create(Note note);
        void Update(int id, Note note);
        void Delete(int id);

    }
}