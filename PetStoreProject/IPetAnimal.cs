using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStoreProject {
    public interface IPetAnimal { // interface has to have exact same as other classes in order for all classes to be in sync on selected properties

        public int Inventory { get; set; }
        public decimal Price { get; set; }
        public string Sound { get; set; }
    }
}
