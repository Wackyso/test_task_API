using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using Moq;

namespace test_task_API.Models
{
    public class Database :INotesRest
    {
        List<Note> notes;
        public Database()
        {
           

            notes = new List<Note>
            {
                new Note { id=0, text= "first note"},
                new Note { id=1, text= "second note"},
                new Note { id=2, text= "third note"},
                new Note { id=3, text= "fourth note"}
            };

        }

        public IEnumerable<Note> GetAll()
        {
            return notes;
        }

        public Note Get (int id)
        {
            Note not = new Note();
            bool find= false;
            foreach (Note n in notes)
            {
                if (n.id == id) { not = n; find = true; };
            }

            if (find)
            {
                return not;
            }
            else
                throw new Exception("invalid id");

        }

        public void Create(Note note)
        {
            notes.Add(note);
        }

        public void Update (int id, Note note)
        {
            Note not = new Note();
            bool find = false;
            foreach (Note n in notes)
            {
                if (n.id == id) { not = n; find = true; };
            }

            if (find)
            {
                notes[id] = note;
            }
            else
                throw new Exception("invalid id");
                
        }
        public void Delete (int id)
        {
            Note not = new Note();
            bool find = false;
            foreach (Note n in notes)
            {
                if (n.id == id) { not = n; find = true; };
            }

            if (find)
            {
                notes.Remove(not);
            }
            else
                throw new Exception("invalid id");
        }
    }
}