using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Temp.DataAccess.Data
{
    public class Menu
    {
        public int Id { get; set; }

        public int ParentId { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string MenuName { get; set; }

        public string MenuLink { get; set; }

        public int Active { get; set; }
    }
}
