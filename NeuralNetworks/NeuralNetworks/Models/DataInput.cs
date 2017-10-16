using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NeuralNetworks.Models
{
    public class DataInput
    {
        public int Id { get; set; }
        public double Carbon { get; set; }
        public double Oxygen { get; set; }
        public double Nitrogen { get; set; }
        public double Hydrogen { get; set; }
        public double Sulfur { get; set; }
        public int Type { get; set; }
    }
}