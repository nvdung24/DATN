using System;
using System.Collections.Generic;
using System.Text;
using Temp.DataAccess.Data;
using Temp.Service.DTO;
using AutoMapper;

namespace Temp.Service.Mapper
{
    public class MenuMapping : Profile
    {
        public MenuMapping()
        {
            CreateMap<Menu, MenuDTO>();

            CreateMap<MenuDTO, Menu>();
        }
    }
}
