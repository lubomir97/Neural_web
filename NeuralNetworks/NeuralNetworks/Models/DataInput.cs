using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NeuralNetworks.Models
{
    public class DataInput
    {
        public int Id { get; set; }
        public int Carbon { get; set; }
        public int Oxygen { get; set; }
        public int Nitrogen { get; set; }
        public int Hydrogen { get; set; }
        public int Sulfur { get; set; }
        public int Type { get; set; }
    }
}