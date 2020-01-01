using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LSS.UI.ViewModels
{
    public class AdministratorViewModel
    {

        [Required, MaxLength(20)]
        public string username { get; set; }

        [Required, MaxLength(16)]
        public string password { get; set; }
    }

    public class ReferSeatViewModel { 
        
        [Required]
        public string libraryname { get; set; }

        [Required]
        public int floor { get; set; }

    }

    public class BatchSeatStateViewModel { 
    
        public List<string> list { get; set; }

        public int operation { get; set; }

    }

}
