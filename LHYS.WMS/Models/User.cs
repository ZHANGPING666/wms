using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LHYS.WMS.Models
{
    public class User
    {
        private string _userCode;
        public string UserCode
        {
            get
            {
                return _userCode;
            }

            set
            {
                _userCode = value;
            }
        }
        private string _userName;
        public string UserName
        {
            get
            {
                return _userName;
            }

            set
            {
                _userName = value;
            }
        }


    }
}