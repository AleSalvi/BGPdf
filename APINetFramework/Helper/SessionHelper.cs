using System;
using System.Web;

namespace APINetFramework.Helper
{
    public class SessionHelper
    {
        public Guid AccountUid
        {
            set
            {
                HttpContext.Current.Items["tk"] = value.ToString();
            }
            get
            {
                Guid _accountUid = Guid.Empty;

                try
                {
                    _accountUid = new Guid(HttpContext.Current.Items["tk"].ToString());
                }
                catch
                {
                }

                return _accountUid;
            }
        }

        public string AccountName
        {
            set
            {
                HttpContext.Current.Items["tkname"] = value.ToString();
            }
            get
            {
                string _accountName = string.Empty;

                try
                {
                    _accountName = HttpContext.Current.Items["tkname"].ToString();
                }
                catch
                {
                }

                return _accountName;
            }
        }

        private SessionHelper()
        {
        }

        private static SessionHelper _thisObject = null;

        public static SessionHelper Get()
        {
            if (_thisObject == null)
                _thisObject = new SessionHelper();

            return _thisObject;
        }
    }

}