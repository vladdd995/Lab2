using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        private bool binButton, hexButton, decButton;
        public Form1()
        {
            InitializeComponent();
            binButton = true;
            BinButton1.Checked = true;
            encoding.Text = "Введіть значення";
            encoding.ForeColor = Color.Gray;
            key_encoding.Text = "Введіть ключ";
            key_encoding.ForeColor = Color.Gray;
            decoding.Text = "Введіть значення";
            decoding.ForeColor = Color.Gray;
            key_decoding.Text = "Введіть ключ";
            key_decoding.ForeColor = Color.Gray;

            DecEN.Visible = false; HexEN.Visible = false; BinEN.Visible = false; DecKey.Visible = false; HexKey.Visible = false; BinKey.Visible = false; DecRes.Visible = false; HexRes.Visible = false; BinRes.Visible = false;
            DecDe.Visible = false; HexDe.Visible = false; BinDe.Visible = false; DecKeyD.Visible = false; HexKeyD.Visible = false; BinKeyD.Visible = false; DecResD.Visible = false; HexResD.Visible = false; BinResD.Visible = false;
        }

        private void XOR_Click(object sender, EventArgs e)
        {
            try
            {
                if (binButton == true)
                {
                    if (encoding.Text != "" && key_encoding.Text != "")
                    {
                        string strP = encoding.Text;
                        int intP = Convert.ToInt32(strP, 2);
                        string strKey = key_encoding.Text;
                        int intKey = Convert.ToInt32(strKey, 2);
                        int intC = intP ^ intKey;
                        string strC = Convert.ToString(intC, 2);
                        encoding_result.Text = strC;

                        DecEN.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(encoding.Text, 2), 10);
                        HexEN.Text = "Hex = " + Convert.ToString(Convert.ToInt32(encoding.Text, 2), 16);
                        BinEN.Text = "Binary = " + Convert.ToString(Convert.ToInt32(encoding.Text, 2), 2);

                        DecKey.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(key_encoding.Text, 2), 10);
                        HexKey.Text = "Hex = " + Convert.ToString(Convert.ToInt32(key_encoding.Text, 2), 16);
                        BinKey.Text = "Binary = " + Convert.ToString(Convert.ToInt32(key_encoding.Text, 2), 2);

                        DecRes.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(encoding_result.Text, 2), 10);
                        HexRes.Text = "Hex = " + Convert.ToString(Convert.ToInt32(encoding_result.Text, 2), 16);
                        BinRes.Text = "Binary = " + Convert.ToString(Convert.ToInt32(encoding_result.Text, 2), 2);

                        DecEN.Visible = true; HexEN.Visible = true; BinEN.Visible = true; DecKey.Visible = true; HexKey.Visible = true; BinKey.Visible = true; DecRes.Visible = true; HexRes.Visible = true; BinRes.Visible = true;

                        MessageBox.Show("Шифрування виконано");
                    }
                    else if (encoding.Text == "" || encoding.Text == "Введіть значення")
                    {
                        MessageBox.Show("Введіть значення");
                    }
                    else if (key_encoding.Text == "" || key_encoding.Text == "Введіть ключ")
                    {
                        MessageBox.Show("Введіть Ключ");
                    }
                    else
                    {
                        MessageBox.Show("Невірне значення або ключ");
                        encoding.Text = "";
                        key_encoding.Text = "";
                    }
                }
                if (hexButton == true)
                {
                    if (encoding.Text != "" && key_encoding.Text != "")
                    {
                        string strP = encoding.Text;
                        int intP = Convert.ToInt32(strP, 16);
                        string strKey = key_encoding.Text;
                        int intKey = Convert.ToInt32(strKey, 16);
                        int intC = intP ^ intKey;
                        string strC = Convert.ToString(intC, 16);
                        encoding_result.Text = strC;

                        DecEN.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(encoding.Text, 16), 10);
                        HexEN.Text = "Hex = " + Convert.ToString(Convert.ToInt32(encoding.Text, 16), 16);
                        BinEN.Text = "Binary = " + Convert.ToString(Convert.ToInt32(encoding.Text, 16), 2);

                        DecKey.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(key_encoding.Text, 16), 10);
                        HexKey.Text = "Hex = " + Convert.ToString(Convert.ToInt32(key_encoding.Text, 16), 16);
                        BinKey.Text = "Binary = " + Convert.ToString(Convert.ToInt32(key_encoding.Text, 16), 2);

                        DecRes.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(encoding_result.Text, 16), 10);
                        HexRes.Text = "Hex = " + Convert.ToString(Convert.ToInt32(encoding_result.Text, 16), 16);
                        BinRes.Text = "Binary = " + Convert.ToString(Convert.ToInt32(encoding_result.Text, 16), 2);

                        DecEN.Visible = true; HexEN.Visible = true; BinEN.Visible = true; DecKey.Visible = true; HexKey.Visible = true; BinKey.Visible = true; DecRes.Visible = true; HexRes.Visible = true; BinRes.Visible = true;

                        MessageBox.Show("Шифрування виконано");
                    }
                    else if (encoding.Text == "" || encoding.Text == "Введіть значення")
                    {
                        MessageBox.Show("Введіть значення");
                    }
                    else if (key_encoding.Text == "" || key_encoding.Text == "Введіть ключ")
                    {
                        MessageBox.Show("Введіть Ключ");
                    }
                    else
                    {
                        MessageBox.Show("Невірне значення або ключ");
                        encoding.Text = "";
                        key_encoding.Text = "";
                    }
                }
                if (decButton == true)
                {
                    if (encoding.Text != "" && key_encoding.Text != "")
                    {
                        string strP = encoding.Text;
                        int intP = Convert.ToInt32(strP, 10);
                        string strKey = key_encoding.Text;
                        int intKey = Convert.ToInt32(strKey, 10);
                        int intC = intP ^ intKey;
                        string strC = Convert.ToString(intC, 10);
                        encoding_result.Text = strC;

                        DecEN.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(encoding.Text, 10), 10);
                        HexEN.Text = "Hex = " + Convert.ToString(Convert.ToInt32(encoding.Text, 10), 16);
                        BinEN.Text = "Binary = " + Convert.ToString(Convert.ToInt32(encoding.Text, 10), 2);

                        DecKey.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(key_encoding.Text, 10), 10);
                        HexKey.Text = "Hex = " + Convert.ToString(Convert.ToInt32(key_encoding.Text, 10), 16);
                        BinKey.Text = "Binary = " + Convert.ToString(Convert.ToInt32(key_encoding.Text, 10), 2);

                        DecRes.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(encoding_result.Text, 10), 10);
                        HexRes.Text = "Hex = " + Convert.ToString(Convert.ToInt32(encoding_result.Text, 10), 16);
                        BinRes.Text = "Binary = " + Convert.ToString(Convert.ToInt32(encoding_result.Text, 10), 2);

                        DecEN.Visible = true; HexEN.Visible = true; BinEN.Visible = true; DecKey.Visible = true; HexKey.Visible = true; BinKey.Visible = true; DecRes.Visible = true; HexRes.Visible = true; BinRes.Visible = true;

                        MessageBox.Show("Шифрування виконано");
                    }
                    else if (encoding.Text == "" || encoding.Text == "Введіть значення")
                    {
                        MessageBox.Show("Введіть значення");
                    }
                    else if (key_encoding.Text == "" || key_encoding.Text == "Введіть ключ")
                    {
                        MessageBox.Show("Введіть Ключ");
                    }
                    else
                    {
                        MessageBox.Show("Невірне значення або ключ");
                        encoding.Text = "";
                        key_encoding.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            encoding.Text = "Введіть значення";
            key_encoding.Text = "Введіть ключ";
            encoding_result.Text = "";
            encoding.ForeColor = Color.Gray;
            key_encoding.ForeColor = Color.Gray;
            DecEN.Visible = false; HexEN.Visible = false; BinEN.Visible = false; DecKey.Visible = false; HexKey.Visible = false; BinKey.Visible = false; DecRes.Visible = false; HexRes.Visible = false; BinRes.Visible = false;
        }

        private void encoding_Enter(object sender, EventArgs e)
        {

            if (encoding.Text == "Введіть значення")
            {
                encoding.Text = "";
                encoding.ForeColor = Color.Black;
            }
        }
        private void encoding_Leave(object sender, EventArgs e)
        {

            if (encoding.Text == "")
            {
                encoding.Text = "Введіть значення";
                encoding.ForeColor = Color.Gray;
            }
        }
        private void key_encoding_Enter(object sender, EventArgs e)
        {

            if (key_encoding.Text == "Введіть ключ")
            {
                key_encoding.Text = "";
                key_encoding.ForeColor = Color.Black;
            }
        }
        private void key_encoding_Leave(object sender, EventArgs e)
        {

            if (key_encoding.Text == "")
            {
                key_encoding.UseSystemPasswordChar = false;
                key_encoding.Text = "Введіть ключ";
                key_encoding.ForeColor = Color.Gray;
            }
        }

        private void BinButton_CheckedChanged(object sender, EventArgs e)
        {
            binButton = true;
            hexButton = false;
            decButton = false;
        }

        private void XOR2_Click(object sender, EventArgs e)
        {
            try
            {
                if (binButton == true)
                {
                    if (decoding.Text != "" && key_decoding.Text != "")
                    {
                        string strP = decoding.Text;
                        int intP = Convert.ToInt32(strP, 2);
                        string strKey = key_decoding.Text;
                        int intKey = Convert.ToInt32(strKey, 2);
                        int intC = intP ^ intKey;
                        string strC = Convert.ToString(intC, 2);
                        decoding_result.Text = strC;

                        DecDe.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(decoding.Text, 2), 10);
                        HexDe.Text = "Hex = " + Convert.ToString(Convert.ToInt32(decoding.Text, 2), 16);
                        BinDe.Text = "Binary = " + Convert.ToString(Convert.ToInt32(decoding.Text, 2), 2);

                        DecKeyD.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(key_decoding.Text, 2), 10);
                        HexKeyD.Text = "Hex = " + Convert.ToString(Convert.ToInt32(key_decoding.Text, 2), 16);
                        BinKeyD.Text = "Binary = " + Convert.ToString(Convert.ToInt32(key_decoding.Text, 2), 2);

                        DecResD.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(decoding_result.Text, 2), 10);
                        HexResD.Text = "Hex = " + Convert.ToString(Convert.ToInt32(decoding_result.Text, 2), 16);
                        BinResD.Text = "Binary = " + Convert.ToString(Convert.ToInt32(decoding_result.Text, 2), 2);

                        DecDe.Visible = true; HexDe.Visible = true; BinDe.Visible = true; DecKeyD.Visible = true; HexKeyD.Visible = true; BinKeyD.Visible = true; DecResD.Visible = true; HexResD.Visible = true; BinResD.Visible = true;

                        MessageBox.Show("Дешифрування виконано");
                    }
                    else if (decoding.Text == "" || decoding.Text == "Введіть значення")
                    {
                        MessageBox.Show("Введіть значення");
                    }
                    else if (key_decoding.Text == "" || key_decoding.Text == "Введіть ключ")
                    {
                        MessageBox.Show("Введіть Ключ");
                    }
                    else
                    {
                        MessageBox.Show("Невірне значення або ключ");
                        decoding.Text = "";
                        key_decoding.Text = "";
                    }
                }
                if (hexButton == true)
                {
                    if (decoding.Text != "" && key_decoding.Text != "")
                    {
                        string strP = decoding.Text;
                        int intP = Convert.ToInt32(strP, 16);
                        string strKey = key_decoding.Text;
                        int intKey = Convert.ToInt32(strKey, 16);
                        int intC = intP ^ intKey;
                        string strC = Convert.ToString(intC, 16);
                        decoding_result.Text = strC;

                        DecDe.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(decoding.Text, 16), 10);
                        HexDe.Text = "Hex = " + Convert.ToString(Convert.ToInt32(decoding.Text, 16), 16);
                        BinDe.Text = "Binary = " + Convert.ToString(Convert.ToInt32(decoding.Text, 16), 2);

                        DecKeyD.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(key_decoding.Text, 16), 10);
                        HexKeyD.Text = "Hex = " + Convert.ToString(Convert.ToInt32(key_decoding.Text, 16), 16);
                        BinKeyD.Text = "Binary = " + Convert.ToString(Convert.ToInt32(key_decoding.Text, 16), 2);

                        DecResD.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(decoding_result.Text, 16), 10);
                        HexResD.Text = "Hex = " + Convert.ToString(Convert.ToInt32(decoding_result.Text, 16), 16);
                        BinResD.Text = "Binary = " + Convert.ToString(Convert.ToInt32(decoding_result.Text, 16), 2);

                        DecDe.Visible = true; HexDe.Visible = true; BinDe.Visible = true; DecKeyD.Visible = true; HexKeyD.Visible = true; BinKeyD.Visible = true; DecResD.Visible = true; HexResD.Visible = true; BinResD.Visible = true;

                        MessageBox.Show("Дешифрування виконано");
                    }
                    else if (decoding.Text == "" || decoding.Text == "Введіть значення")
                    {
                        MessageBox.Show("Введіть значення");
                    }
                    else if (key_decoding.Text == "" || key_decoding.Text == "Введіть ключ")
                    {
                        MessageBox.Show("Введіть Ключ");
                    }
                    else
                    {
                        MessageBox.Show("Невірне значення або ключ");
                        decoding.Text = "";
                        key_decoding.Text = "";
                    }
                }
                if (decButton == true)
                {
                    if (decoding.Text != "" && key_decoding.Text != "")
                    {
                        string strP = decoding.Text;
                        int intP = Convert.ToInt32(strP, 10);
                        string strKey = key_decoding.Text;
                        int intKey = Convert.ToInt32(strKey, 10);
                        int intC = intP ^ intKey;
                        string strC = Convert.ToString(intC, 10);
                        decoding_result.Text = strC;

                        DecDe.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(decoding.Text, 10), 10);
                        HexDe.Text = "Hex = " + Convert.ToString(Convert.ToInt32(decoding.Text, 10), 16);
                        BinDe.Text = "Binary = " + Convert.ToString(Convert.ToInt32(decoding.Text, 10), 2);

                        DecKeyD.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(key_decoding.Text, 10), 10);
                        HexKeyD.Text = "Hex = " + Convert.ToString(Convert.ToInt32(key_decoding.Text, 10), 16);
                        BinKeyD.Text = "Binary = " + Convert.ToString(Convert.ToInt32(key_decoding.Text, 10), 2);

                        DecResD.Text = "Decimal = " + Convert.ToString(Convert.ToInt32(decoding_result.Text, 10), 10);
                        HexResD.Text = "Hex = " + Convert.ToString(Convert.ToInt32(decoding_result.Text, 10), 16);
                        BinResD.Text = "Binary = " + Convert.ToString(Convert.ToInt32(decoding_result.Text, 10), 2);

                        DecDe.Visible = true; HexDe.Visible = true; BinDe.Visible = true; DecKeyD.Visible = true; HexKeyD.Visible = true; BinKeyD.Visible = true; DecResD.Visible = true; HexResD.Visible = true; BinResD.Visible = true;

                        MessageBox.Show("Дешифрування виконано");
                    }
                    else if (decoding.Text == "" || decoding.Text == "Введіть значення")
                    {
                        MessageBox.Show("Введіть значення");
                    }
                    else if (key_decoding.Text == "" || key_decoding.Text == "Введіть ключ")
                    {
                        MessageBox.Show("Введіть Ключ");
                    }
                    else
                    {
                        MessageBox.Show("Невірне значення або ключ");
                        decoding.Text = "";
                        key_decoding.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BinButton1_CheckedChanged(object sender, EventArgs e)
        {
            binButton = true;
            decButton = false;
            hexButton = false;
        }

        private void decoding_Enter(object sender, EventArgs e)
        {

            if (decoding.Text == "Введіть значення")
            {
                decoding.Text = "";
                decoding.ForeColor = Color.Black;
            }
        }

        private void decoding_Leave(object sender, EventArgs e)
        {

            if (decoding.Text == "")
            {
                decoding.Text = "Введіть значення";
                decoding.ForeColor = Color.Gray;
            }
        }

        private void key_decoding_Enter(object sender, EventArgs e)
        {

            if (key_decoding.Text == "Введіть ключ")
            {
                key_decoding.Text = "";
                key_decoding.ForeColor = Color.Black;
            }
        }

        private void HexButton1_CheckedChanged(object sender, EventArgs e)
        {
            hexButton = true;
            binButton = false;
            decButton = false;
        }

        private void DecButton1_CheckedChanged(object sender, EventArgs e)
        {
            decButton = true;
            binButton = false;
            hexButton = false;
        }

        private void encoding_result_KeyPress(object sender, KeyPressEventArgs e)
        {
            encoding_result.ReadOnly = true;
        }

        private void decoding_result_KeyPress(object sender, KeyPressEventArgs e)
        {
            decoding_result.ReadOnly = true;
        }


        private void key_decoding_Leave(object sender, EventArgs e)
        {

            if (key_decoding.Text == "")
            {
                key_decoding.UseSystemPasswordChar = false;
                key_decoding.Text = "Введіть ключ";
                key_decoding.ForeColor = Color.Gray;
            }
        }

        private void clear_decoding_Click(object sender, EventArgs e)
        {
            decoding.Text = "Введіть значення";
            key_decoding.Text = "Введіть ключ";
            decoding_result.Text = "";
            decoding.ForeColor = Color.Gray;
            key_decoding.ForeColor = Color.Gray;
            DecDe.Visible = false; HexDe.Visible = false; BinDe.Visible = false; DecKeyD.Visible = false; HexKeyD.Visible = false; BinKeyD.Visible = false; DecResD.Visible = false; HexResD.Visible = false; BinResD.Visible = false;
        }
    }
}
