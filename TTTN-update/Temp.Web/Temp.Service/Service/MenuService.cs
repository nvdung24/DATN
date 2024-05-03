using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Temp.DataAccess.Data;
using Temp.Service.BaseService;
using Temp.Service.DTO;

namespace Temp.Service.Service
{
    public class MenuService : IMenuService
    {
        private readonly IUnitofWork _unitofWork;
        private readonly IMapper _mapper;
        public void Delete(int id)
        {
            var menu = _unitofWork.MenuBaseService.GetById(id);
            _unitofWork.MenuBaseService.Delete(menu);
            _unitofWork.Save();
        }

        public IEnumerable<MenuDTO> GetAll()
        {
            var menu = _unitofWork.MenuBaseService.GetAll();
            return _mapper.Map<IEnumerable<Menu>, IEnumerable<MenuDTO>>(menu);
        }

        public List<Menu> GetAllMenus()
        {
            return _unitofWork.MenuBaseService.ObjectContext.ToList();
        }

        public MenuDTO GetById(int id)
        {
            var menu = _unitofWork.MenuBaseService.GetById(id);
            return _mapper.Map<Menu, MenuDTO>(menu);
        }

        public void Save(MenuDTO menuDto)
        {
            if (menuDto.Id <= 0)
            {
                var menu = _mapper.Map<MenuDTO, Menu>(menuDto);
                _unitofWork.MenuBaseService.Add(menu);
                _unitofWork.Save();
            }
            else
            {
                var menu = _mapper.Map<MenuDTO, Menu>(menuDto);
                _unitofWork.MenuBaseService.Update(menu);
                _unitofWork.Save();
            }
        }
    }
}
