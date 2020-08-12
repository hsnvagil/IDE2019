using System;

namespace IDE2019.Model {
    public class Cs {
        public string Name { get; set; }
        public string Path { get; set; }

        [NonSerialized]
        public string Text;
    }
}