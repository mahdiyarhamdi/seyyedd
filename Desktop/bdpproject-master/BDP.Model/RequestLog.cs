namespace BDP.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("RequestLog")]
    public class RequestLog
    {
        public int ID { get; set; }

        public long ChatID { get; set; }

        [Required]
        public string Request { get; set; }

        public long RequestMessageID { get; set; }

        public string Response { get; set; }

        public DateTime RequestDateTime { get; set; }

        public DateTime CreationDateTime { get; set; }
    }
}
