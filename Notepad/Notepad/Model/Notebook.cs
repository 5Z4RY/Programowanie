using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Notepad.Model
{
    public class Notebook
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [Indexed]
        public string Name { get; set; }
    }
}
