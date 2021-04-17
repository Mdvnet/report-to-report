using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ReportToReport.Models
{
    public class User
    {
        [Key, MaxLength(12)]
        public string Login { get; set; }

        [MaxLength(8), MinLength(5)]
        public string Password { get; set; }

        [MaxLength(20)]
        public string Name { get; set; }

        [MaxLength(20)]
        public string Surname { get; set; }

        [MaxLength(20)]
        public string Patronymic { get; set; }

        [MaxLength(12), MinLength(9)]
        public string Number { get; set; }

        public bool IsAdmin { get; set; }

        public virtual Department Department { get; set; }

    }
}
