using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStoreProject {

    public interface IPrint { // defines something that is common in all classes

        public int Inventory { get; set; }
    }
}
