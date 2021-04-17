using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReportToReport.Models
{
    public class Report
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        public string UserLogin { get; set; }

        public DateTime Date { get; set; }

        public byte[] File { get; set; }

        public string Name { get; set; }

        public string Reason { get; set; }

        public virtual User User { get; set; }

    }
}
