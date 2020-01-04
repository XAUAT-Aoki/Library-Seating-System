using LSS.Data;
using LSS.Infrastructure.Utility;
using LSS.Mapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace LSS.Service
{
    public class LibraryImplement
    {
       /// <summary>
       /// 获取所有的图书馆名和对应的开始，结束楼层
       /// </summary>
       /// <returns></returns>
        public List<LibraryToShow> GetAllLibraryToShows()
        {
            List<LibraryToShow> libraryToShows=new List<LibraryToShow>();
            AdministratorMapper administratorMapper = new AdministratorMapper();
            AdministratorImplement administrator = new AdministratorImplement();
            List<string> library = administratorMapper.GetAllLibraryName();
            foreach(var tmp in library)
            {
                LibraryToShow libraryToShow = new LibraryToShow();
                List<int> floor = administrator.GetFloor(tmp);
                libraryToShow.libraryName = tmp;
                libraryToShow.startFloor = floor[0];
                libraryToShow.endFloor = floor[1];
                libraryToShows.Add(libraryToShow);
            }
            return libraryToShows;
        }
    }
}
