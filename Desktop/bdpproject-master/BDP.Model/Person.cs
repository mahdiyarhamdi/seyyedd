namespace BDP.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Person")]
    public class Person
    {
        public int ID { get; set; }

        public long ChatID { get; set; }

        [StringLength(50)]
        public string TelegramFirstName { get; set; }

        [StringLength(50)]
        public string TelegramLastName { get; set; }

        [StringLength(50)]
        public string TelegramUserName { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(50)]
        public string PhoneNumber { get; set; }

        public bool? Gender { get; set; }

        public int StateID { get; set; }

        public int RoleID { get; set; }

        public int? Age { get; set; }

        [StringLength(50)]
        public string Degree { get; set; }

        public bool? IsMarried { get; set; }

        [StringLength(100)]
        public string Job { get; set; }

        public bool IsForbiden { get; set; }

        public bool IsBlocked { get; set; }

        public DateTime CreationDateTime { get; set; }

        public DateTime LastModificationDateTime { get; set; }

        public virtual Role Role { get; set; }

        public virtual State State { get; set; }
    }
}
