using System;
using System.Text;

namespace APINetFramework.Helper
{
    public class TokenHelper
    {
        private static readonly byte[] publicRijndaelKey = Encoding.UTF8.GetBytes("_mU')$u_Zy^JszBC");
        private static readonly byte[] privateRijndaelKey = Encoding.UTF8.GetBytes("YErhYI3=hi3go';g");
        public string Token { get; set; }
        public DateTime ExpirationDate { get; set; }

        public static TokenHelper GetNewToken(Guid uid)
        {
            TokenHelper tk = new TokenHelper();
            tk.ExpirationDate = DateTime.Now;
            string tokenCripted = new CryptingManager().EncryptRijndael(uid.ToString().PadLeft(10, '0') + "|" + tk.ExpirationDate.Year.ToString() + "-" + tk.ExpirationDate.Month.ToString().PadLeft(2, '0') + "-" + tk.ExpirationDate.Day.ToString().PadLeft(2, '0') + " " + tk.ExpirationDate.Hour.ToString().PadLeft(2, '0') + ":" + tk.ExpirationDate.Minute.ToString().PadLeft(2, '0'), publicRijndaelKey, privateRijndaelKey);
            var bytes = Encoding.UTF8.GetBytes(tokenCripted);
            var base64 = Convert.ToBase64String(bytes);
            tk.Token = base64;
            return tk;
        }

        public static Guid? GetUserFromToken(string token, int durationMinutes)
        {
            Guid? userid = default(Guid?);

            try
            {
                var data = Convert.FromBase64String(token);
                var str = Encoding.UTF8.GetString(data);
                string[] parsedtoken = new CryptingManager().DecryptRijndael(str, publicRijndaelKey, privateRijndaelKey).Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

                if (parsedtoken.Length > 1)
                {
                    DateTime dtToken = Convert.ToDateTime(parsedtoken[1] + ":00");

                    if (dtToken > DateTime.Now.AddMinutes(-durationMinutes))
                        userid = new Guid(parsedtoken[0]);
                }
            }
            catch
            {
                userid = default(Guid?);
            }

            return userid;
        }
    }
}