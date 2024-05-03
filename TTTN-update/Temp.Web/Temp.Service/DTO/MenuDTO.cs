using System;
using System.Collections.Generic;
using System.Text;

namespace Temp.Service.DTO
{
    public class MenuDTO
    {
        public int Id { get; set; }

        public int ParentId { get; set; }

        public string MenuName { get; set; }

        public string MenuLink { get; set; }

        public int Active { get; set; }
    }
}
