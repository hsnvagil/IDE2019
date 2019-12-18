using System.Collections.Generic;

namespace IDE2019.Models
{
    public class Project
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public List<CS> csfile { get; set; } = new List<CS>();
    }
}
