using System;

namespace IDE2019.Models
{
    public class CS
    {
        public string Name { get; set; }
        public string Path { get; set; }
        [NonSerialized]
        public string Text;
    }
}
