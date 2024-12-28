using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ticketing_project
{
    internal class TotalStocBilete
    {
        private readonly User user;
        public TotalStocBilete()
        {
            user = new User();
        }
        public List<StocBilete> BileteToate() {
            return  user.Extrage();
        }
    }
}
