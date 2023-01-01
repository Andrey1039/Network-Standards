using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace NewWebService
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class CryptoService : System.Web.Services.WebService
    {
        private static string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        private int n = alphabet.Length;

        // Шифрование строки
        [WebMethod]
        public CryptoStr Encrypt(CryptoStr str)
        {
            CryptoStr EncryptStr = new CryptoStr();
          
            for (int i = 0; i < str.Length; i++)
            {
                if (alphabet.IndexOf(str.SourceString[i]) == -1)
                    EncryptStr.SourceString += str.SourceString[i];
                else
                    EncryptStr.SourceString += alphabet[(alphabet.IndexOf(str.SourceString[i]) + str.SourceString1) % n];
            }

            return EncryptStr;
        }

        // Расшифровка строки
        [WebMethod]
        public CryptoStr Decrypt(CryptoStr str)
        {
            CryptoStr DecryptStr = new CryptoStr();

            for (int i = 0; i < str.Length; i++)
                if (alphabet.IndexOf(str.SourceString[i]) == -1)
                    DecryptStr.SourceString += str.SourceString[i];
                else
                    DecryptStr.SourceString += alphabet[(alphabet.IndexOf(str.SourceString[i]) - str.SourceString1 + n) % n];

            return DecryptStr;
        }

        // Сложение массивов
        [WebMethod]
        public Str256 SumMass(Str256 str)
        {
            Str256 SumMassStr = new Str256();

            string temp = str.SourceString;
            float[] massa = temp.Split(' ').Select(float.Parse).ToArray();

            string temp1 = str.SourceString1;
            float[] massb = temp1.Split(' ').Select(float.Parse).ToArray();

            int max = 0, n = 0;
            if (str.LengthA > str.LengthB)
            {
                max = massa.Length;
                n = massb.Length;
            }
            else
            {
                max = massb.Length;
                n = massa.Length;
            }

            float[] c = new float[max];

            for (int i = 0; i < max; i++)
                if (i < n)
                    c[i] = massa[i] + massb[i];
                else
                    if (max == massb.Length)
                        c[i] = massb[i];
                    else c[i] = massa[i];


            SumMassStr.SourceString = String.Join(" ", c);
           
            return SumMassStr;
        }

        // Удаление дубликатов, сортировка массива, поиск минимума и максимума
        [WebMethod]
        public CheckMass MassCheck(CheckMass str)
        {
            CheckMass MassCheckStr = new CheckMass();

            string temp = str.SourceString;
            float[] massa = temp.Split(' ').Select(float.Parse).ToArray();

            float[] q = massa.Distinct().ToArray();

            float temp1;
            for (int i = 0; i < q.Length - 1; i++)
            {
                for (int j = i + 1; j < q.Length; j++)
                {
                    if (q[i] > q[j])
                    {
                        temp1 = q[i];
                        q[i] = q[j];
                        q[j] = temp1;
                    }
                }
            }

            temp = q[0].ToString() + " / ";
            temp += q[q.Length - 1];

            MassCheckStr.SourceString = String.Join(" ", q);
            MassCheckStr.SourceString1 = temp;

            return MassCheckStr;
        }

        // Определение самого частого слова в строке (+верхний регистр)
        [WebMethod]
        public CheckStr StrCheck(CheckStr str)
        {
            CheckStr StrCheckStr = new CheckStr();

            string temp = str.SourceString;
            string stringInput = new string(temp.Where(c => !char.IsPunctuation(c)).ToArray());

            List<string> lstString = new List<string>();
            string curString = "";
            foreach (var vari in stringInput)
            {
                curString += vari;
                if (vari == ' ')
                {
                    lstString.Add(curString.Trim());
                    curString = "";
                }
            }
            lstString.Add(curString.Trim());

            var result = lstString.GroupBy(x => x)
                .OrderByDescending(g => g.Count())
                .ThenBy(g => g.Key, StringComparer.Ordinal)
                .First().Key;

            StrCheckStr.SourceString = result;

            var countInputs = lstString.FindAll(x => x == result);
            int countInput = countInputs.Count;
            StrCheckStr.SourceString += "   (" + countInput.ToString() + ")";

            StrCheckStr.SourceString1 = temp.ToUpper();

            return StrCheckStr;
        }

        public class CryptoStr
        {
            private string _str;
            private int key;

            public CryptoStr()
            {
                _str = string.Empty;
                key = 0;
            }

            public string SourceString { get { return _str; } set { _str = value; } }
            public int SourceString1 { get { return key; } set { key = value; } }
            public int Length { get { return _str.Length; } }
        }

        public class Str256
        {
            private string _str;
            private string key;

            public Str256()
            {
                _str = string.Empty;
                key = string.Empty;
            }

            public string SourceString { get { return _str; } set { _str = value; } }
            public string SourceString1 { get { return key; } set { key = value; } }
            public int LengthA { get { return _str.Length; } }
            public int LengthB { get { return key.Length; } }
        }

        public class CheckMass
        {
            private string _str;
            private string key;


            public CheckMass()
            {
                _str = string.Empty;
                key = string.Empty;
            }

            public string SourceString { get { return _str; } set { _str = value; } }
            public string SourceString1 { get { return key; } set { key = value; } }
        }

        public class CheckStr
        {
            private string _str;
            private string key;

            public CheckStr()
            {
                _str = string.Empty;
                key = string.Empty;
            }

            public string SourceString { get { return _str; } set { _str = value; } }
            public string SourceString1 { get { return key; } set { key = value; } }
        }
    }
}