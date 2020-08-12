using System.Collections.Generic;

namespace IDE2019.Model {
    public class Project {
        public string Name { get; set; }
        public string Path { get; set; }
        public List<Cs> CsFile { get; set; } = new List<Cs>();
    }
}