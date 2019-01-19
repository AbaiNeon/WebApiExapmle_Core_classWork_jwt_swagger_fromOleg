using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models
{
    public class Player
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Number { get; set; }
        public virtual Team Team { get; set; }
        //[ForeignKey("Team")]
        public int TeamId { get; set; }
    }
}
