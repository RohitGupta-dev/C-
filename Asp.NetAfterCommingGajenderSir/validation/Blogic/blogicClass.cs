using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dblogic;
using System.Data;
namespace Blogic
{
    public class blogicClass
    {

        Dblogic.insert ins = new Dblogic.insert();
        DataSet ds = new DataSet();
        public DataSet insertDataintoBus(object name, object email, object age, object pwd)
        {
            ds = ins.InsertINtoDb( name,  email,  age,  pwd);
            return ds;

        }
    }
}
