namespace View
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this._buttonBuild = new System.Windows.Forms.Button();
            this._textBoxWidth = new System.Windows.Forms.TextBox();
            this._textBoxLength = new System.Windows.Forms.TextBox();
            this._textBoxHeight = new System.Windows.Forms.TextBox();
            this._textBoxInsideWidth = new System.Windows.Forms.TextBox();
            this._textBoxInsideLength = new System.Windows.Forms.TextBox();
            this._textBoxInsideHeight = new System.Windows.Forms.TextBox();
            this._textBoxCapWidth = new System.Windows.Forms.TextBox();
            this._textBoxCapLength = new System.Windows.Forms.TextBox();
            this._textBoxCapHeight = new System.Windows.Forms.TextBox();
            this._groupBoxBase = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._groupBoxInside = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._labelInsideHeight = new System.Windows.Forms.Label();
            this._labelInsideLength = new System.Windows.Forms.Label();
            this._labelInsideWidth = new System.Windows.Forms.Label();
            this._labelBoxHeight = new System.Windows.Forms.Label();
            this._labelBoxLength = new System.Windows.Forms.Label();
            this._labelBoxWidth = new System.Windows.Forms.Label();
            this._groupBoxCap = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this._labelСapHeight = new System.Windows.Forms.Label();
            this._labelСapLength = new System.Windows.Forms.Label();
            this._labelСapWidth = new System.Windows.Forms.Label();
            this.buttonValueDefault = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this._groupBoxBase.SuspendLayout();
            this._groupBoxInside.SuspendLayout();
            this._groupBoxCap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // _buttonBuild
            // 
            this._buttonBuild.Location = new System.Drawing.Point(721, 881);
            this._buttonBuild.Name = "_buttonBuild";
            this._buttonBuild.Size = new System.Drawing.Size(75, 23);
            this._buttonBuild.TabIndex = 0;
            this._buttonBuild.Text = "Построить";
            this._buttonBuild.UseVisualStyleBackColor = true;
            this._buttonBuild.Click += new System.EventHandler(this.ButtonBuild_Click);
            // 
            // _textBoxWidth
            // 
            this._textBoxWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._textBoxWidth.Location = new System.Drawing.Point(91, 261);
            this._textBoxWidth.Name = "_textBoxWidth";
            this._textBoxWidth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._textBoxWidth.ShortcutsEnabled = false;
            this._textBoxWidth.Size = new System.Drawing.Size(100, 20);
            this._textBoxWidth.TabIndex = 1;
            this._textBoxWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressOnlyDigit);
            // 
            // _textBoxLength
            // 
            this._textBoxLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._textBoxLength.Location = new System.Drawing.Point(348, 259);
            this._textBoxLength.Name = "_textBoxLength";
            this._textBoxLength.ShortcutsEnabled = false;
            this._textBoxLength.Size = new System.Drawing.Size(100, 20);
            this._textBoxLength.TabIndex = 2;
            this._textBoxLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressOnlyDigit);
            // 
            // _textBoxHeight
            // 
            this._textBoxHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._textBoxHeight.Location = new System.Drawing.Point(601, 257);
            this._textBoxHeight.Name = "_textBoxHeight";
            this._textBoxHeight.ShortcutsEnabled = false;
            this._textBoxHeight.Size = new System.Drawing.Size(100, 20);
            this._textBoxHeight.TabIndex = 3;
            this._textBoxHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressOnlyDigit);
            // 
            // _textBoxInsideWidth
            // 
            this._textBoxInsideWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._textBoxInsideWidth.Location = new System.Drawing.Point(85, 260);
            this._textBoxInsideWidth.Name = "_textBoxInsideWidth";
            this._textBoxInsideWidth.ShortcutsEnabled = false;
            this._textBoxInsideWidth.Size = new System.Drawing.Size(100, 20);
            this._textBoxInsideWidth.TabIndex = 4;
            this._textBoxInsideWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressOnlyDigit);
            // 
            // _textBoxInsideLength
            // 
            this._textBoxInsideLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._textBoxInsideLength.Location = new System.Drawing.Point(342, 258);
            this._textBoxInsideLength.Name = "_textBoxInsideLength";
            this._textBoxInsideLength.ShortcutsEnabled = false;
            this._textBoxInsideLength.Size = new System.Drawing.Size(100, 20);
            this._textBoxInsideLength.TabIndex = 5;
            this._textBoxInsideLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressOnlyDigit);
            // 
            // _textBoxInsideHeight
            // 
            this._textBoxInsideHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._textBoxInsideHeight.Location = new System.Drawing.Point(595, 256);
            this._textBoxInsideHeight.Name = "_textBoxInsideHeight";
            this._textBoxInsideHeight.ShortcutsEnabled = false;
            this._textBoxInsideHeight.Size = new System.Drawing.Size(100, 20);
            this._textBoxInsideHeight.TabIndex = 6;
            this._textBoxInsideHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressOnlyDigit);
            // 
            // _textBoxCapWidth
            // 
            this._textBoxCapWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._textBoxCapWidth.Location = new System.Drawing.Point(91, 251);
            this._textBoxCapWidth.Name = "_textBoxCapWidth";
            this._textBoxCapWidth.ShortcutsEnabled = false;
            this._textBoxCapWidth.Size = new System.Drawing.Size(100, 20);
            this._textBoxCapWidth.TabIndex = 7;
            this._textBoxCapWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressOnlyDigit);
            // 
            // _textBoxCapLength
            // 
            this._textBoxCapLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._textBoxCapLength.Location = new System.Drawing.Point(348, 254);
            this._textBoxCapLength.Name = "_textBoxCapLength";
            this._textBoxCapLength.ShortcutsEnabled = false;
            this._textBoxCapLength.Size = new System.Drawing.Size(100, 20);
            this._textBoxCapLength.TabIndex = 8;
            this._textBoxCapLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressOnlyDigit);
            // 
            // _textBoxCapHeight
            // 
            this._textBoxCapHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._textBoxCapHeight.Location = new System.Drawing.Point(601, 254);
            this._textBoxCapHeight.Name = "_textBoxCapHeight";
            this._textBoxCapHeight.ShortcutsEnabled = false;
            this._textBoxCapHeight.Size = new System.Drawing.Size(100, 20);
            this._textBoxCapHeight.TabIndex = 9;
            this._textBoxCapHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressOnlyDigit);
            // 
            // _groupBoxBase
            // 
            this._groupBoxBase.Controls.Add(this.pictureBox3);
            this._groupBoxBase.Controls.Add(this.pictureBox2);
            this._groupBoxBase.Controls.Add(this.pictureBox1);
            this._groupBoxBase.Controls.Add(this.label3);
            this._groupBoxBase.Controls.Add(this.label2);
            this._groupBoxBase.Controls.Add(this.label1);
            this._groupBoxBase.Controls.Add(this._groupBoxInside);
            this._groupBoxBase.Controls.Add(this._labelBoxHeight);
            this._groupBoxBase.Controls.Add(this._labelBoxLength);
            this._groupBoxBase.Controls.Add(this._labelBoxWidth);
            this._groupBoxBase.Controls.Add(this._textBoxWidth);
            this._groupBoxBase.Controls.Add(this._textBoxLength);
            this._groupBoxBase.Controls.Add(this._textBoxHeight);
            this._groupBoxBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._groupBoxBase.Location = new System.Drawing.Point(12, 12);
            this._groupBoxBase.Name = "_groupBoxBase";
            this._groupBoxBase.Size = new System.Drawing.Size(784, 575);
            this._groupBoxBase.TabIndex = 10;
            this._groupBoxBase.TabStop = false;
            this._groupBoxBase.Text = "Основание";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(703, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "мм";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(450, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "мм";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(193, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "мм";
            // 
            // _groupBoxInside
            // 
            this._groupBoxInside.Controls.Add(this.pictureBox6);
            this._groupBoxInside.Controls.Add(this.pictureBox5);
            this._groupBoxInside.Controls.Add(this.pictureBox4);
            this._groupBoxInside.Controls.Add(this.label6);
            this._groupBoxInside.Controls.Add(this.label5);
            this._groupBoxInside.Controls.Add(this.label4);
            this._groupBoxInside.Controls.Add(this._labelInsideHeight);
            this._groupBoxInside.Controls.Add(this._labelInsideLength);
            this._groupBoxInside.Controls.Add(this._labelInsideWidth);
            this._groupBoxInside.Controls.Add(this._textBoxInsideWidth);
            this._groupBoxInside.Controls.Add(this._textBoxInsideLength);
            this._groupBoxInside.Controls.Add(this._textBoxInsideHeight);
            this._groupBoxInside.Location = new System.Drawing.Point(6, 287);
            this._groupBoxInside.Name = "_groupBoxInside";
            this._groupBoxInside.Size = new System.Drawing.Size(772, 283);
            this._groupBoxInside.TabIndex = 10;
            this._groupBoxInside.TabStop = false;
            this._groupBoxInside.Text = "Внутренняя часть";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(697, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "мм";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(444, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "мм";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(187, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "мм";
            // 
            // _labelInsideHeight
            // 
            this._labelInsideHeight.AutoSize = true;
            this._labelInsideHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._labelInsideHeight.Location = new System.Drawing.Point(528, 256);
            this._labelInsideHeight.Name = "_labelInsideHeight";
            this._labelInsideHeight.Size = new System.Drawing.Size(61, 18);
            this._labelInsideHeight.TabIndex = 11;
            this._labelInsideHeight.Text = "Высота";
            // 
            // _labelInsideLength
            // 
            this._labelInsideLength.AutoSize = true;
            this._labelInsideLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._labelInsideLength.Location = new System.Drawing.Point(275, 258);
            this._labelInsideLength.Name = "_labelInsideLength";
            this._labelInsideLength.Size = new System.Drawing.Size(53, 18);
            this._labelInsideLength.TabIndex = 11;
            this._labelInsideLength.Text = "Длина";
            // 
            // _labelInsideWidth
            // 
            this._labelInsideWidth.AutoSize = true;
            this._labelInsideWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._labelInsideWidth.Location = new System.Drawing.Point(18, 260);
            this._labelInsideWidth.Name = "_labelInsideWidth";
            this._labelInsideWidth.Size = new System.Drawing.Size(61, 18);
            this._labelInsideWidth.TabIndex = 11;
            this._labelInsideWidth.Text = "Ширина";
            // 
            // _labelBoxHeight
            // 
            this._labelBoxHeight.AutoSize = true;
            this._labelBoxHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._labelBoxHeight.Location = new System.Drawing.Point(534, 257);
            this._labelBoxHeight.Name = "_labelBoxHeight";
            this._labelBoxHeight.Size = new System.Drawing.Size(61, 18);
            this._labelBoxHeight.TabIndex = 9;
            this._labelBoxHeight.Text = "Высота";
            // 
            // _labelBoxLength
            // 
            this._labelBoxLength.AutoSize = true;
            this._labelBoxLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._labelBoxLength.Location = new System.Drawing.Point(281, 259);
            this._labelBoxLength.Name = "_labelBoxLength";
            this._labelBoxLength.Size = new System.Drawing.Size(53, 18);
            this._labelBoxLength.TabIndex = 8;
            this._labelBoxLength.Text = "Длина";
            // 
            // _labelBoxWidth
            // 
            this._labelBoxWidth.AutoSize = true;
            this._labelBoxWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._labelBoxWidth.Location = new System.Drawing.Point(24, 261);
            this._labelBoxWidth.Name = "_labelBoxWidth";
            this._labelBoxWidth.Size = new System.Drawing.Size(61, 18);
            this._labelBoxWidth.TabIndex = 7;
            this._labelBoxWidth.Text = "Ширина";
            // 
            // _groupBoxCap
            // 
            this._groupBoxCap.Controls.Add(this.pictureBox9);
            this._groupBoxCap.Controls.Add(this.pictureBox8);
            this._groupBoxCap.Controls.Add(this.pictureBox7);
            this._groupBoxCap.Controls.Add(this.label9);
            this._groupBoxCap.Controls.Add(this.label8);
            this._groupBoxCap.Controls.Add(this.label7);
            this._groupBoxCap.Controls.Add(this._labelСapHeight);
            this._groupBoxCap.Controls.Add(this._labelСapLength);
            this._groupBoxCap.Controls.Add(this._labelСapWidth);
            this._groupBoxCap.Controls.Add(this._textBoxCapWidth);
            this._groupBoxCap.Controls.Add(this._textBoxCapLength);
            this._groupBoxCap.Controls.Add(this._textBoxCapHeight);
            this._groupBoxCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._groupBoxCap.Location = new System.Drawing.Point(12, 593);
            this._groupBoxCap.Name = "_groupBoxCap";
            this._groupBoxCap.Size = new System.Drawing.Size(784, 282);
            this._groupBoxCap.TabIndex = 11;
            this._groupBoxCap.TabStop = false;
            this._groupBoxCap.Text = "Крышка";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(704, 257);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "мм";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(451, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "мм";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(194, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "мм";
            // 
            // _labelСapHeight
            // 
            this._labelСapHeight.AutoSize = true;
            this._labelСapHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._labelСapHeight.Location = new System.Drawing.Point(534, 254);
            this._labelСapHeight.Name = "_labelСapHeight";
            this._labelСapHeight.Size = new System.Drawing.Size(61, 18);
            this._labelСapHeight.TabIndex = 14;
            this._labelСapHeight.Text = "Высота";
            // 
            // _labelСapLength
            // 
            this._labelСapLength.AutoSize = true;
            this._labelСapLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._labelСapLength.Location = new System.Drawing.Point(281, 254);
            this._labelСapLength.Name = "_labelСapLength";
            this._labelСapLength.Size = new System.Drawing.Size(53, 18);
            this._labelСapLength.TabIndex = 13;
            this._labelСapLength.Text = "Длина";
            // 
            // _labelСapWidth
            // 
            this._labelСapWidth.AutoSize = true;
            this._labelСapWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._labelСapWidth.Location = new System.Drawing.Point(24, 251);
            this._labelСapWidth.Name = "_labelСapWidth";
            this._labelСapWidth.Size = new System.Drawing.Size(61, 18);
            this._labelСapWidth.TabIndex = 12;
            this._labelСapWidth.Text = "Ширина";
            // 
            // buttonValueDefault
            // 
            this.buttonValueDefault.Location = new System.Drawing.Point(613, 881);
            this.buttonValueDefault.Name = "buttonValueDefault";
            this.buttonValueDefault.Size = new System.Drawing.Size(88, 23);
            this.buttonValueDefault.TabIndex = 12;
            this.buttonValueDefault.Text = "По умолчанию";
            this.buttonValueDefault.UseVisualStyleBackColor = true;
            this.buttonValueDefault.Click += new System.EventHandler(this.ButtonValueDefault_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(284, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(234, 220);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(536, 25);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(234, 220);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(22, 25);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(234, 220);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(278, 25);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(234, 220);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 18;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(530, 25);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(234, 220);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 19;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(28, 25);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(234, 220);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 20;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(284, 25);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(234, 220);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 21;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(536, 25);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(234, 220);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 22;
            this.pictureBox9.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(807, 911);
            this.Controls.Add(this.buttonValueDefault);
            this.Controls.Add(this._groupBoxCap);
            this.Controls.Add(this._groupBoxBase);
            this.Controls.Add(this._buttonBuild);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Построение шкатулки";
            this._groupBoxBase.ResumeLayout(false);
            this._groupBoxBase.PerformLayout();
            this._groupBoxInside.ResumeLayout(false);
            this._groupBoxInside.PerformLayout();
            this._groupBoxCap.ResumeLayout(false);
            this._groupBoxCap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _buttonBuild;
        private System.Windows.Forms.TextBox _textBoxWidth;
        private System.Windows.Forms.TextBox _textBoxLength;
        private System.Windows.Forms.TextBox _textBoxHeight;
        private System.Windows.Forms.TextBox _textBoxInsideWidth;
        private System.Windows.Forms.TextBox _textBoxInsideLength;
        private System.Windows.Forms.TextBox _textBoxInsideHeight;
        private System.Windows.Forms.TextBox _textBoxCapWidth;
        private System.Windows.Forms.TextBox _textBoxCapLength;
        private System.Windows.Forms.TextBox _textBoxCapHeight;
        private System.Windows.Forms.GroupBox _groupBoxBase;
        private System.Windows.Forms.GroupBox _groupBoxInside;
        private System.Windows.Forms.Label _labelInsideHeight;
        private System.Windows.Forms.Label _labelInsideLength;
        private System.Windows.Forms.Label _labelInsideWidth;
        private System.Windows.Forms.Label _labelBoxHeight;
        private System.Windows.Forms.Label _labelBoxLength;
        private System.Windows.Forms.Label _labelBoxWidth;
        private System.Windows.Forms.GroupBox _groupBoxCap;
        private System.Windows.Forms.Label _labelСapHeight;
        private System.Windows.Forms.Label _labelСapLength;
        private System.Windows.Forms.Label _labelСapWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonValueDefault;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}

