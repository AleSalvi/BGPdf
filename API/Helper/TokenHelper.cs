using dto;
using System.Text;

namespace API.Helper
{
    public class TokenHelper
    {
        private static readonly byte[] publicRijndaelKey = Encoding.UTF8.GetBytes("_mU')$u_Zy^JszBC");

        private static readonly byte[] privateRijndaelKey = Encoding.UTF8.GetBytes("YErhYI3=hi3go';g");


        //public string Token { get; set; }

        //public DateTime ExpirationDate { get; set; }
        public bool IsWindowsAuth { get { return false; } }

        public HeaderToken GetNewToken(Guid accountUid)
        {
            HeaderToken tk = new HeaderToken
            {
                ExpirationDate = DateTime.Now
            };

            string tokenCripted = new Crypto().EncryptRijndael(accountUid.ToString().PadLeft(10, '0') + "|" + tk.ExpirationDate.Year.ToString() + "-" + tk.ExpirationDate.Month.ToString().PadLeft(2, '0') + "-" + tk.ExpirationDate.Day.ToString().PadLeft(2, '0') + " " + tk.ExpirationDate.Hour.ToString().PadLeft(2, '0') + ":" + tk.ExpirationDate.Minute.ToString().PadLeft(2, '0'), publicRijndaelKey, privateRijndaelKey);
            byte[] bytes = Encoding.UTF8.GetBytes(tokenCripted);
            string base64 = Convert.ToBase64String(bytes);

            tk.Token = base64;
            return tk;
        }

        public Guid? GetAccountUidFromToken(string token, int durationMinutes)
        {
            Guid? userid = null;
            try
            {
                byte[] data = Convert.FromBase64String(token);
                string str = Encoding.UTF8.GetString(data);

                string[] parsedtoken = new Crypto().DecryptRijndael(str, publicRijndaelKey, privateRijndaelKey).Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

                if (parsedtoken.Length > 1)
                {
                    DateTime dtToken = Convert.ToDateTime(parsedtoken[1] + ":00");

                    if (dtToken > DateTime.Now.AddMinutes(-durationMinutes))
                    {
                        userid = new Guid(parsedtoken[0]);
                    }
                }
            }
            catch
            {
                userid = null;
            }

            return userid;
        }

        public Guid? GetAccountUidFromName(string name)
        {
            return null;
        }
    }
}