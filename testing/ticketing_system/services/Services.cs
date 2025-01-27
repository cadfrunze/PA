using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ticketing_system.data_base;
using ticketing_system.modell;

namespace ticketing_system.services
{
    internal class Services
    {
        private DataBase _dataBase;
        private NewUser _newUser;
        private UserInfo _userInfo;

        public Services()
        {
            _dataBase = new DataBase();

        }
        public Services(DataBase _dataBase)
        {
            this._dataBase = _dataBase;
        }

        public List<string> CnpList()
        {
            return this._dataBase.ExtractCnp();
        }










    }
}
