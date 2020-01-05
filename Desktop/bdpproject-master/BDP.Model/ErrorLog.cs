namespace BDP.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ErrorLog")]
    public class ErrorLog
    {
        public int ID { get; set; }

        [Required]
        public string ErrorToString { get; set; }

        public DateTime CreationDateTime { get; set; }

        public int? PersonID { get; set; }
    }
}
