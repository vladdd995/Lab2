
namespace Lab2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.XOR = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.encoding = new System.Windows.Forms.TextBox();
            this.key_encoding = new System.Windows.Forms.TextBox();
            this.encoding_result = new System.Windows.Forms.TextBox();
            this.decoding_result = new System.Windows.Forms.TextBox();
            this.key_decoding = new System.Windows.Forms.TextBox();
            this.decoding = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.clear_decoding = new System.Windows.Forms.Button();
            this.XOR2 = new System.Windows.Forms.Button();
            this.HexEN = new System.Windows.Forms.Label();
            this.BinEN = new System.Windows.Forms.Label();
            this.DecEN = new System.Windows.Forms.Label();
            this.HexKey = new System.Windows.Forms.Label();
            this.BinKey = new System.Windows.Forms.Label();
            this.DecKey = new System.Windows.Forms.Label();
            this.HexDe = new System.Windows.Forms.Label();
            this.BinDe = new System.Windows.Forms.Label();
            this.DecDe = new System.Windows.Forms.Label();
            this.HexKeyD = new System.Windows.Forms.Label();
            this.BinKeyD = new System.Windows.Forms.Label();
            this.DecKeyD = new System.Windows.Forms.Label();
            this.HexResD = new System.Windows.Forms.Label();
            this.BinResD = new System.Windows.Forms.Label();
            this.DecResD = new System.Windows.Forms.Label();
            this.HexRes = new System.Windows.Forms.Label();
            this.BinRes = new System.Windows.Forms.Label();
            this.DecRes = new System.Windows.Forms.Label();
            this.BinButton1 = new System.Windows.Forms.RadioButton();
            this.HexButton1 = new System.Windows.Forms.RadioButton();
            this.DecButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // XOR
            // 
            this.XOR.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.XOR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.XOR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.XOR.Location = new System.Drawing.Point(310, 12);
            this.XOR.Name = "XOR";
            this.XOR.Size = new System.Drawing.Size(84, 30);
            this.XOR.TabIndex = 0;
            this.XOR.Text = "Виконати";
            this.XOR.UseVisualStyleBackColor = true;
            this.XOR.Click += new System.EventHandler(this.XOR_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(310, 62);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(84, 30);
            this.clear.TabIndex = 1;
            this.clear.Text = "Очистити";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "P = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Key =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "C =";
            // 
            // encoding
            // 
            this.encoding.Location = new System.Drawing.Point(47, 16);
            this.encoding.Name = "encoding";
            this.encoding.Size = new System.Drawing.Size(244, 26);
            this.encoding.TabIndex = 5;
            this.encoding.Enter += new System.EventHandler(this.encoding_Enter);
            this.encoding.Leave += new System.EventHandler(this.encoding_Leave);
            // 
            // key_encoding
            // 
            this.key_encoding.Location = new System.Drawing.Point(47, 62);
            this.key_encoding.Name = "key_encoding";
            this.key_encoding.Size = new System.Drawing.Size(244, 26);
            this.key_encoding.TabIndex = 6;
            this.key_encoding.Enter += new System.EventHandler(this.key_encoding_Enter);
            this.key_encoding.Leave += new System.EventHandler(this.key_encoding_Leave);
            // 
            // encoding_result
            // 
            this.encoding_result.Location = new System.Drawing.Point(47, 112);
            this.encoding_result.Name = "encoding_result";
            this.encoding_result.ReadOnly = true;
            this.encoding_result.Size = new System.Drawing.Size(244, 26);
            this.encoding_result.TabIndex = 7;
            this.encoding_result.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.encoding_result_KeyPress);
            // 
            // decoding_result
            // 
            this.decoding_result.Location = new System.Drawing.Point(49, 112);
            this.decoding_result.Name = "decoding_result";
            this.decoding_result.ReadOnly = true;
            this.decoding_result.Size = new System.Drawing.Size(241, 26);
            this.decoding_result.TabIndex = 15;
            this.decoding_result.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.decoding_result_KeyPress);
            // 
            // key_decoding
            // 
            this.key_decoding.Location = new System.Drawing.Point(49, 66);
            this.key_decoding.Name = "key_decoding";
            this.key_decoding.Size = new System.Drawing.Size(241, 26);
            this.key_decoding.TabIndex = 14;
            this.key_decoding.Enter += new System.EventHandler(this.key_decoding_Enter);
            this.key_decoding.Leave += new System.EventHandler(this.key_decoding_Leave);
            // 
            // decoding
            // 
            this.decoding.Location = new System.Drawing.Point(49, 18);
            this.decoding.Name = "decoding";
            this.decoding.Size = new System.Drawing.Size(241, 26);
            this.decoding.TabIndex = 13;
            this.decoding.Enter += new System.EventHandler(this.decoding_Enter);
            this.decoding.Leave += new System.EventHandler(this.decoding_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "C =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Key =";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "P = ";
            // 
            // clear_decoding
            // 
            this.clear_decoding.Location = new System.Drawing.Point(296, 63);
            this.clear_decoding.Name = "clear_decoding";
            this.clear_decoding.Size = new System.Drawing.Size(84, 30);
            this.clear_decoding.TabIndex = 9;
            this.clear_decoding.Text = "Очистити";
            this.clear_decoding.UseVisualStyleBackColor = true;
            this.clear_decoding.Click += new System.EventHandler(this.clear_decoding_Click);
            // 
            // XOR2
            // 
            this.XOR2.Location = new System.Drawing.Point(296, 12);
            this.XOR2.Name = "XOR2";
            this.XOR2.Size = new System.Drawing.Size(84, 30);
            this.XOR2.TabIndex = 8;
            this.XOR2.Text = "Виконати";
            this.XOR2.UseVisualStyleBackColor = true;
            this.XOR2.Click += new System.EventHandler(this.XOR2_Click);
            // 
            // HexEN
            // 
            this.HexEN.AutoSize = true;
            this.HexEN.Location = new System.Drawing.Point(138, 42);
            this.HexEN.Name = "HexEN";
            this.HexEN.Size = new System.Drawing.Size(34, 19);
            this.HexEN.TabIndex = 28;
            this.HexEN.Text = "Hex";
            // 
            // BinEN
            // 
            this.BinEN.AutoSize = true;
            this.BinEN.Location = new System.Drawing.Point(213, 42);
            this.BinEN.Name = "BinEN";
            this.BinEN.Size = new System.Drawing.Size(48, 19);
            this.BinEN.TabIndex = 27;
            this.BinEN.Text = "Binary";
            // 
            // DecEN
            // 
            this.DecEN.AutoSize = true;
            this.DecEN.Location = new System.Drawing.Point(43, 42);
            this.DecEN.Name = "DecEN";
            this.DecEN.Size = new System.Drawing.Size(58, 19);
            this.DecEN.TabIndex = 26;
            this.DecEN.Text = "Decimal";
            // 
            // HexKey
            // 
            this.HexKey.AutoSize = true;
            this.HexKey.Location = new System.Drawing.Point(138, 91);
            this.HexKey.Name = "HexKey";
            this.HexKey.Size = new System.Drawing.Size(34, 19);
            this.HexKey.TabIndex = 31;
            this.HexKey.Text = "Hex";
            // 
            // BinKey
            // 
            this.BinKey.AutoSize = true;
            this.BinKey.Location = new System.Drawing.Point(213, 90);
            this.BinKey.Name = "BinKey";
            this.BinKey.Size = new System.Drawing.Size(48, 19);
            this.BinKey.TabIndex = 30;
            this.BinKey.Text = "Binary";
            // 
            // DecKey
            // 
            this.DecKey.AutoSize = true;
            this.DecKey.Location = new System.Drawing.Point(43, 91);
            this.DecKey.Name = "DecKey";
            this.DecKey.Size = new System.Drawing.Size(58, 19);
            this.DecKey.TabIndex = 29;
            this.DecKey.Text = "Decimal";
            // 
            // HexDe
            // 
            this.HexDe.AutoSize = true;
            this.HexDe.Location = new System.Drawing.Point(140, 45);
            this.HexDe.Name = "HexDe";
            this.HexDe.Size = new System.Drawing.Size(34, 19);
            this.HexDe.TabIndex = 34;
            this.HexDe.Text = "Hex";
            // 
            // BinDe
            // 
            this.BinDe.AutoSize = true;
            this.BinDe.Location = new System.Drawing.Point(219, 45);
            this.BinDe.Name = "BinDe";
            this.BinDe.Size = new System.Drawing.Size(48, 19);
            this.BinDe.TabIndex = 33;
            this.BinDe.Text = "Binary";
            // 
            // DecDe
            // 
            this.DecDe.AutoSize = true;
            this.DecDe.Location = new System.Drawing.Point(46, 44);
            this.DecDe.Name = "DecDe";
            this.DecDe.Size = new System.Drawing.Size(58, 19);
            this.DecDe.TabIndex = 32;
            this.DecDe.Text = "Decimal";
            // 
            // HexKeyD
            // 
            this.HexKeyD.AutoSize = true;
            this.HexKeyD.Location = new System.Drawing.Point(140, 91);
            this.HexKeyD.Name = "HexKeyD";
            this.HexKeyD.Size = new System.Drawing.Size(34, 19);
            this.HexKeyD.TabIndex = 37;
            this.HexKeyD.Text = "Hex";
            // 
            // BinKeyD
            // 
            this.BinKeyD.AutoSize = true;
            this.BinKeyD.Location = new System.Drawing.Point(219, 91);
            this.BinKeyD.Name = "BinKeyD";
            this.BinKeyD.Size = new System.Drawing.Size(48, 19);
            this.BinKeyD.TabIndex = 36;
            this.BinKeyD.Text = "Binary";
            // 
            // DecKeyD
            // 
            this.DecKeyD.AutoSize = true;
            this.DecKeyD.Location = new System.Drawing.Point(46, 91);
            this.DecKeyD.Name = "DecKeyD";
            this.DecKeyD.Size = new System.Drawing.Size(58, 19);
            this.DecKeyD.TabIndex = 35;
            this.DecKeyD.Text = "Decimal";
            // 
            // HexResD
            // 
            this.HexResD.AutoSize = true;
            this.HexResD.Location = new System.Drawing.Point(140, 140);
            this.HexResD.Name = "HexResD";
            this.HexResD.Size = new System.Drawing.Size(34, 19);
            this.HexResD.TabIndex = 40;
            this.HexResD.Text = "Hex";
            // 
            // BinResD
            // 
            this.BinResD.AutoSize = true;
            this.BinResD.Location = new System.Drawing.Point(219, 138);
            this.BinResD.Name = "BinResD";
            this.BinResD.Size = new System.Drawing.Size(48, 19);
            this.BinResD.TabIndex = 39;
            this.BinResD.Text = "Binary";
            // 
            // DecResD
            // 
            this.DecResD.AutoSize = true;
            this.DecResD.Location = new System.Drawing.Point(46, 141);
            this.DecResD.Name = "DecResD";
            this.DecResD.Size = new System.Drawing.Size(58, 19);
            this.DecResD.TabIndex = 38;
            this.DecResD.Text = "Decimal";
            // 
            // HexRes
            // 
            this.HexRes.AutoSize = true;
            this.HexRes.Location = new System.Drawing.Point(138, 140);
            this.HexRes.Name = "HexRes";
            this.HexRes.Size = new System.Drawing.Size(34, 19);
            this.HexRes.TabIndex = 43;
            this.HexRes.Text = "Hex";
            // 
            // BinRes
            // 
            this.BinRes.AutoSize = true;
            this.BinRes.Location = new System.Drawing.Point(213, 140);
            this.BinRes.Name = "BinRes";
            this.BinRes.Size = new System.Drawing.Size(48, 19);
            this.BinRes.TabIndex = 42;
            this.BinRes.Text = "Binary";
            // 
            // DecRes
            // 
            this.DecRes.AutoSize = true;
            this.DecRes.Location = new System.Drawing.Point(43, 140);
            this.DecRes.Name = "DecRes";
            this.DecRes.Size = new System.Drawing.Size(58, 19);
            this.DecRes.TabIndex = 41;
            this.DecRes.Text = "Decimal";
            // 
            // BinButton1
            // 
            this.BinButton1.AutoSize = true;
            this.BinButton1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BinButton1.Location = new System.Drawing.Point(340, 12);
            this.BinButton1.Name = "BinButton1";
            this.BinButton1.Size = new System.Drawing.Size(66, 23);
            this.BinButton1.TabIndex = 44;
            this.BinButton1.TabStop = true;
            this.BinButton1.Text = "Binary";
            this.BinButton1.UseVisualStyleBackColor = true;
            this.BinButton1.CheckedChanged += new System.EventHandler(this.BinButton1_CheckedChanged);
            // 
            // HexButton1
            // 
            this.HexButton1.AutoSize = true;
            this.HexButton1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HexButton1.Location = new System.Drawing.Point(412, 12);
            this.HexButton1.Name = "HexButton1";
            this.HexButton1.Size = new System.Drawing.Size(52, 23);
            this.HexButton1.TabIndex = 45;
            this.HexButton1.TabStop = true;
            this.HexButton1.Text = "Hex";
            this.HexButton1.UseVisualStyleBackColor = true;
            this.HexButton1.CheckedChanged += new System.EventHandler(this.HexButton1_CheckedChanged);
            // 
            // DecButton1
            // 
            this.DecButton1.AutoSize = true;
            this.DecButton1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DecButton1.Location = new System.Drawing.Point(462, 12);
            this.DecButton1.Name = "DecButton1";
            this.DecButton1.Size = new System.Drawing.Size(76, 23);
            this.DecButton1.TabIndex = 46;
            this.DecButton1.TabStop = true;
            this.DecButton1.Text = "Decimal";
            this.DecButton1.UseVisualStyleBackColor = true;
            this.DecButton1.CheckedChanged += new System.EventHandler(this.DecButton1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.XOR);
            this.groupBox1.Controls.Add(this.clear);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.HexRes);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BinRes);
            this.groupBox1.Controls.Add(this.encoding);
            this.groupBox1.Controls.Add(this.DecRes);
            this.groupBox1.Controls.Add(this.key_encoding);
            this.groupBox1.Controls.Add(this.encoding_result);
            this.groupBox1.Controls.Add(this.DecEN);
            this.groupBox1.Controls.Add(this.BinEN);
            this.groupBox1.Controls.Add(this.HexEN);
            this.groupBox1.Controls.Add(this.DecKey);
            this.groupBox1.Controls.Add(this.BinKey);
            this.groupBox1.Controls.Add(this.HexKey);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 160);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Зашифрувати";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.XOR2);
            this.groupBox2.Controls.Add(this.clear_decoding);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.HexResD);
            this.groupBox2.Controls.Add(this.decoding);
            this.groupBox2.Controls.Add(this.BinResD);
            this.groupBox2.Controls.Add(this.key_decoding);
            this.groupBox2.Controls.Add(this.DecResD);
            this.groupBox2.Controls.Add(this.decoding_result);
            this.groupBox2.Controls.Add(this.HexKeyD);
            this.groupBox2.Controls.Add(this.DecDe);
            this.groupBox2.Controls.Add(this.BinKeyD);
            this.groupBox2.Controls.Add(this.BinDe);
            this.groupBox2.Controls.Add(this.DecKeyD);
            this.groupBox2.Controls.Add(this.HexDe);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(418, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 160);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Розшифрувати";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(825, 208);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DecButton1);
            this.Controls.Add(this.HexButton1);
            this.Controls.Add(this.BinButton1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(841, 247);
            this.MinimumSize = new System.Drawing.Size(841, 247);
            this.Name = "Form1";
            this.Text = "Шифратор/Дешифратор чисел XOR";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button XOR;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox encoding;
        private System.Windows.Forms.TextBox key_encoding;
        private System.Windows.Forms.TextBox encoding_result;
        private System.Windows.Forms.TextBox decoding_result;
        private System.Windows.Forms.TextBox key_decoding;
        private System.Windows.Forms.TextBox decoding;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button clear_decoding;
        private System.Windows.Forms.Button XOR2;
        private System.Windows.Forms.Label HexEN;
        private System.Windows.Forms.Label BinEN;
        private System.Windows.Forms.Label DecEN;
        private System.Windows.Forms.Label HexKey;
        private System.Windows.Forms.Label BinKey;
        private System.Windows.Forms.Label DecKey;
        private System.Windows.Forms.Label HexDe;
        private System.Windows.Forms.Label BinDe;
        private System.Windows.Forms.Label DecDe;
        private System.Windows.Forms.Label HexKeyD;
        private System.Windows.Forms.Label BinKeyD;
        private System.Windows.Forms.Label DecKeyD;
        private System.Windows.Forms.Label HexResD;
        private System.Windows.Forms.Label BinResD;
        private System.Windows.Forms.Label DecResD;
        private System.Windows.Forms.Label HexRes;
        private System.Windows.Forms.Label BinRes;
        private System.Windows.Forms.Label DecRes;
        private System.Windows.Forms.RadioButton BinButton1;
        private System.Windows.Forms.RadioButton HexButton1;
        private System.Windows.Forms.RadioButton DecButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

