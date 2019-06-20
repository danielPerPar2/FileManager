using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.Common.Models
{
    public class Airport
    {
        public string Name { get; set; }
        public Airport(){}
        public Airport(string name)
        {
            Name = name;           
        }

        public override bool Equals(object obj)
        {
            return obj is Airport airport;
        }

        public override int GetHashCode()
        {
            var hashCode = 1174183988;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            return hashCode;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
