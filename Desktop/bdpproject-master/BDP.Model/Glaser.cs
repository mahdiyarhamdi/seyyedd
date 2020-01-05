namespace BDP.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Glaser")]
    public class Glaser
    {
        public int ID { get; set; }

        public int PersonID { get; set; }

        public int? Q35 { get; set; }

        public int? Q34 { get; set; }

        public int? Q33 { get; set; }

        public int? Q32 { get; set; }

        public int? Q31 { get; set; }

        public int? Q30 { get; set; }

        public int? Q29 { get; set; }

        public int? Q28 { get; set; }

        public int? Q27 { get; set; }

        public int? Q26 { get; set; }

        public int? Q25 { get; set; }

        public int? Q24 { get; set; }

        public int? Q23 { get; set; }

        public int? Q22 { get; set; }

        public int? Q21 { get; set; }

        public int? Q20 { get; set; }

        public int? Q19 { get; set; }

        public int? Q18 { get; set; }

        public int? Q17 { get; set; }

        public int? Q16 { get; set; }

        public int? Q15 { get; set; }

        public int? Q14 { get; set; }

        public int? Q13 { get; set; }

        public int? Q12 { get; set; }

        public int? Q11 { get; set; }

        public int? Q10 { get; set; }

        public int? Q9 { get; set; }

        public int? Q8 { get; set; }

        public int? Q7 { get; set; }

        public int? Q6 { get; set; }

        public int? Q5 { get; set; }

        public int? Q4 { get; set; }

        public int? Q3 { get; set; }

        public int? Q2 { get; set; }

        public int? Q1 { get; set; }

        public int? Survive { get; set; }

        public int? Power { get; set; }

        public int? Freedom { get; set; }

        public int? Love { get; set; }

        public int? Fun { get; set; }

        public DateTime CreationDateTime { get; set; }

        public DateTime LastModificationDateTime { get; set; }
    }
}
