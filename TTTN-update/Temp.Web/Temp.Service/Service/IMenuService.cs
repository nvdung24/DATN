using System;
using System.Collections.Generic;
using System.Text;
using Temp.DataAccess.Data;
using Temp.Service.DTO;

namespace Temp.Service.Service
{
    public interface IMenuService
    {

        /// <summary>
        /// get all category
        /// </summary>
        /// <returns></returns>
        IEnumerable<MenuDTO> GetAll();

        /// <summary>
        /// create or edit category
        /// </summary>
        /// <param name="categoryDto"></param>
        void Save(MenuDTO menuDto);

        /// <summary>
        /// delete category
        /// </summary>
        /// <param name="id"></param>
        void Delete(int id);

        /// <summary>
        /// get category by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        MenuDTO GetById(int id);

        List<Menu> GetAllMenus();
    }
}
