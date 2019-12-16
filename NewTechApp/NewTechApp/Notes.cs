using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTechApp
{
    public class Note : ICloneable
    {
        private string NoteTitle = "Без названия";

        private NoteType NoteType = NoteType.Stuff;

        private string NoteContents = "";

        private DateTime NoteModificationTime = DateTime.Now;

        private DateTime NoteCreationTime = DateTime.Now;
      
        public DateTime ModificationTime
        {
            get
            {
                return NoteModificationTime;
            }
            set
            {
                value = DateTime.Now;
                NoteModificationTime = value;
            }
        }
        public string Title
        {
            get
            {
                return NoteTitle;
            }

            set
            {
                if (Title.Length >= 51)
                {
                    throw new ArgumentException(
                        "Название заметки не должно превышать 50'и символов. \n"
                        + "Количество введённых символов: " + Title.Length);
                }
                else
                {
                    NoteTitle = value;
                    this.NoteModificationTime = DateTime.Now;
                }
            }
        }

        public NoteType Type
        {
            get
            {
                return NoteType;
            }
            set
            {
                NoteType = value;
                this.NoteModificationTime = DateTime.Now;
            }
        }

        public string Contents
        {
            get
            {
                return NoteContents;
            }
            set
            {
                NoteContents = value;
                this.NoteModificationTime = DateTime.Now;
            }
        }

        public DateTime CreationTime
        {
            get
            {
                return NoteCreationTime;
            }
            set
            {
                NoteCreationTime = value;
            }
        }
        public object Clone()
        {
            return new Note
            {
                Title = this.Title,
                Type = this.Type,
                Contents = this.Contents,
                CreationTime = this.CreationTime,
                ModificationTime = this.ModificationTime
            };
        }
    }
}