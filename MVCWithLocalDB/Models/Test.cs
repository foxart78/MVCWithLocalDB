using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCWithLocalDB.Models
{
    [Table("Test")]
    public class Test
    {

        public int Id { get; set; }
        [MaxLength(100)]
        public string Nome { get; set; }
        [MaxLength(100)]
        [MinLength(2)]
        public string Cognome { get; set; }


    }
}