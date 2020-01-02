using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LSS.UI.ViewModels
{
    public class LibraryViewModel
    {
        [Required,MaxLength(30)]
        public string libraryname { get; set; }


        [Required,MinLength(1)]
        public int StartFloor { get; set; }

        [Required,MaxLength(20)]
        public int EndFloor { get; set; }

        //经度
        [Required, MaxLength(10)]
        public string longititude { get; set; }

        [Required, MaxLength(10)]
        public string latitude { get; set; }

        [Required, MaxLength(5)]
        public string Error { get; set; }

    }

    public class AddFloorViewModel { 
    
        [Required]
        public string libraryname { get; set; }

        [Required]
        public int startfloor { get; set; }

        [Required]
        public int endfloor { get; set; }

    }
}
