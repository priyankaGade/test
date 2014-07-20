using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public Profile Login(string username, string password, string deviceToken)
        {
            int isError = 0;
            string errorText = "";
            if (username == null || username.Trim() == "")
            {
                isError = 1;
                errorText = errorText + "Please enter username. ";
            }
            if (password == null || password.Trim() == "")
            {
                isError = 1;
                errorText = errorText + "Please enter password. ";
            }
            if (deviceToken == null || deviceToken.Trim() == "")
            {
                isError = 1;
                errorText = errorText + "Please enter device token. ";
            }

            if (isError == 0 && (username != "SmartWinnerTest" || password != "123456"))
            {
                isError = 1;
                errorText = errorText + "Login details are not valid. ";
            }

            Profile p = new Profile();
            if (isError == 1)
            {
                p.UserId = 0;
                p.Name = "";
                p.LastName = "";
                p.Email = "";
                p.Address = "";
                p.City = "";
                p.Mobile = "";
                p.Passport = "";
                p.Phone = "";

                p.ErrorCode = isError;
                p.ErrorText = errorText;
            }
            else
            {
                p.UserId = 1;
                p.Name = "priyanka";
                p.LastName = "gade";
                p.Email = "priyanka.burujwale@gmail.com";
                p.Address = "2831,rexford lane";
                p.City = "Cary";
                p.Mobile = "123456";
                p.Passport = "MH123DX3";
                p.Phone = "123456";
                p.ErrorCode = 0;
                p.ErrorText = "";
            }

            return p;
        }
        public Profile Login1(string username, string password, string deviceToken)
        {
            int isError = 0;
            string errorText = "";
            if (username == null || username.Trim() == "")
            {
                isError = 1;
                errorText = errorText + "Please enter username. ";
            }
            if (password == null || password.Trim() == "")
            {
                isError = 1;
                errorText = errorText + "Please enter password. ";
            }
            if (deviceToken == null || deviceToken.Trim() == "")
            {
                isError = 1;
                errorText = errorText + "Please enter device token. ";
            }

            if (isError == 0 && (username != "SmartWinnerTest" || password != "123456"))
            {
                isError = 1;
                errorText = errorText + "Login details are not valid. ";
            }

            Profile p = new Profile();
            if (isError == 1)
            {
                p.UserId = 0;
                p.Name = "";
                p.LastName = "";
                p.Email = "";
                p.Address = "";
                p.City = "";
                p.Mobile = "";
                p.Passport = "";
                p.Phone = "";

                p.ErrorCode = isError;
                p.ErrorText = errorText;
            }
            else
            {
                p.UserId = 1;
                p.Name = "priyanka";
                p.LastName = "gade";
                p.Email = "priyanka.burujwale@gmail.com";
                p.Address = "2831,rexford lane";
                p.City = "Cary";
                p.Mobile = "123456";
                p.Passport = "MH123DX3";
                p.Phone = "123456";
                p.ErrorCode = 0;
                p.ErrorText = "";
            }

            return p;
        }
    }
}
