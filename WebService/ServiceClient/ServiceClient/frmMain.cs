using System;
using System.Windows.Forms;

namespace ServiceClient
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        // Шифрование строки
        private void EncryptBtn_Click(object sender, EventArgs e)
        {
            if (EncryptStrTB.Text == null || String.IsNullOrEmpty(EncryptStrTB.Text) || EncryptKeyTB.Text == null || String.IsNullOrEmpty(EncryptKeyTB.Text))
            {
                MessageBox.Show("Не введена строка для шифрования или ключ");
                return;
            }

            CryptoServiceReference.CryptoStr str = new CryptoServiceReference.CryptoStr();
            str.SourceString = EncryptStrTB.Text;
            str.SourceString1 = EncryptKeyTB.Text;

            CryptoServiceReference.CryptoServiceSoapClient service = new CryptoServiceReference.CryptoServiceSoapClient();

            MessageBox.Show(service.Encrypt(str).SourceString);
        }

        // Расшифровка строки
        private void DecryptBtn_Click(object sender, EventArgs e)
        {
            if (DecryptStrTB.Text == null || String.IsNullOrEmpty(DecryptStrTB.Text) || DecryptKeyTB.Text == null || String.IsNullOrEmpty(DecryptKeyTB.Text))
            {
                MessageBox.Show("Не введена строка для дешифрования");
                return;
            }

            CryptoServiceReference.CryptoStr str = new CryptoServiceReference.CryptoStr();
            str.SourceString = DecryptStrTB.Text;
            str.SourceString1 = DecryptKeyTB.Text;

            CryptoServiceReference.CryptoServiceSoapClient service = new CryptoServiceReference.CryptoServiceSoapClient();

            MessageBox.Show(service.Decrypt(str).SourceString);
        }

        // Сложение массивов
        private void SumArrayBtn_Click(object sender, EventArgs e)
        {
            if (ArrayBTB.Text.Equals(string.Empty) || ArrayATB.Text.Equals(string.Empty))
            {
                MessageBox.Show("Не введен один или оба массива");
                return;
            }

            ArrayCTB.Text = string.Empty;

            CryptoServiceReference1.Str256 str = new CryptoServiceReference1.Str256();
            str.SourceString = ArrayATB.Text;
            str.SourceString1 = ArrayBTB.Text;

            CryptoServiceReference1.CryptoServiceSoapClient service = new CryptoServiceReference1.CryptoServiceSoapClient();

            ArrayCTB.Text = service.SumMass(str).SourceString;
        }

        // Удаление дубликатов, сортировка, минимум и максимум в массиве
        private void DelDuplsBtn_Click(object sender, EventArgs e)
        {
            if (ArrayTB.Text.Equals(string.Empty))
            {
                MessageBox.Show("Не введен массив");
                return;
            }

            ArrayResultTB.Text = string.Empty;
            ResultParamsTB.Text = string.Empty;

            CryptoServiceReference2.CheckMass str = new CryptoServiceReference2.CheckMass();
            str.SourceString = ArrayTB.Text;

            CryptoServiceReference2.CryptoServiceSoapClient service = new CryptoServiceReference2.CryptoServiceSoapClient();

            ArrayResultTB.Text = service.MassCheck(str).SourceString;
            ResultParamsTB.Text = service.MassCheck(str).SourceString1;
        }

        // Определение самого частого слова в строке и перед в верхний регистр
        private void FindWordBtn_Click(object sender, EventArgs e)
        {
            if (InitStringTB.Text.Equals(string.Empty))
            {
                MessageBox.Show("Не введена строка");
                return;
            }

            FrequentWordTB.Text = string.Empty;
            UppercaseStrTB.Text = string.Empty;

            CryptoServiceReference3.CheckStr str = new CryptoServiceReference3.CheckStr();
            str.SourceString = InitStringTB.Text;

            CryptoServiceReference3.CryptoServiceSoapClient service = new CryptoServiceReference3.CryptoServiceSoapClient();

            FrequentWordTB.Text = service.StrCheck(str).SourceString;
            UppercaseStrTB.Text = service.StrCheck(str).SourceString1;
        }
    }
}