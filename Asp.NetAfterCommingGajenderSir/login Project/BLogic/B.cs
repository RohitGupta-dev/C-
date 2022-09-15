using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dlogic;

namespace BLogic
{
    public class Insert
    {
        DataSet ds;
        public DataSet InsertBs(object name, object email, object password, object status)
        {
            ds = new DataSet();
            Dlogic.Insert ins = new Dlogic.Insert();
          ds=  ins.InsertDb(name, email, password, status);
            return ds;
        }
    }

    public class update
    {
        DataSet ds ;
        Dlogic.update up = new Dlogic.update();

        public DataSet updatebs( object Dob, object Age, object Qualification, object State, object City, object Address, object Photo, object Profile, object Email)
        {
            ds = new DataSet();
            ds =up.updateDb(Dob, Age, Qualification, State, City, Address, Photo, Profile, Email);

            return ds;
        }
    }
    public class login
    {
        DataSet ds;
        Connection conn = new Connection();
        public DataSet Loginbs(object username, object password)
        {
            ds = new DataSet();
            Dlogic.login log = new Dlogic.login();
            ds = log.LoginDb(username, password);
            return ds;
        }


        public DataSet userCheck(object username, object password, object profile)
        {
            ds = new DataSet();
            Dlogic.login log = new Dlogic.login();
            ds = log.User_CheckDb(username, password, profile);
            return ds;
        }
    }

    public class ShowData
    {
        DataSet ds;
        Dlogic.ShowData sh = new Dlogic.ShowData();
        public DataSet ShowBS()
        {
            ds = new DataSet();
            ds = sh.ShowDb();
            return ds;

        }

        public DataSet ShowUserDb(object email, object pwd)
        {
            ds = new DataSet();
            ds = sh.ShowUserDb(email, pwd);
            return ds;
        }

    }
}
