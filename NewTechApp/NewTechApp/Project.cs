using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTechApp
{
    public class Project
    {
        private List<Note> NotesList = new List<Note>();

        public List<Note> Notes
        {
            get
            {
                return NotesList;
            }
            set
            {
                NotesList = value;
            }
        }
    }
}
