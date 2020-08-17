using PersonelMVC.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonelMVC.Models.ViewModels
{
    public class PersonelFormViewModel
    {
        public IEnumerable<Departman> departmanlar { get; set; }
        public Personel Personel { get; set; }

    }
}