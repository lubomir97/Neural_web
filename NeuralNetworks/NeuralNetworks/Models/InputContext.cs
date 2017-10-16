using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NeuralNetworks.Models
{
    public class InputContext : DbContext
    {
        public DbSet<DataInput> DataInputs { get; set; }
    }
}