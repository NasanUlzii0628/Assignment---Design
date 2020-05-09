namespace Assignment___Design
{
    partial class NewAccount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.type1 = new System.Windows.Forms.RadioButton();
            this.type2 = new System.Windows.Forms.RadioButton();
            this.product = new System.Windows.Forms.ComboBox();
            this.combo2 = new System.Windows.Forms.ComboBox();
            this.combo3 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дансны төрөл:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Бүтээгдэхүүн:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Мөнгөн тэмдэгт:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Үлдэгдэл суутгах данс:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(52, 28);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(107, 24);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Харилцах";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(199, 28);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(122, 24);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Хадгаламж";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // type1
            // 
            this.type1.AutoSize = true;
            this.type1.Enabled = false;
            this.type1.Location = new System.Drawing.Point(52, 25);
            this.type1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.type1.Name = "type1";
            this.type1.Size = new System.Drawing.Size(122, 24);
            this.type1.TabIndex = 7;
            this.type1.TabStop = true;
            this.type1.Text = "Хугацаатай";
            this.type1.UseVisualStyleBackColor = true;
            this.type1.CheckedChanged += new System.EventHandler(this.type1_CheckedChanged);
            // 
            // type2
            // 
            this.type2.AutoSize = true;
            this.type2.Enabled = false;
            this.type2.Location = new System.Drawing.Point(199, 25);
            this.type2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.type2.Name = "type2";
            this.type2.Size = new System.Drawing.Size(118, 24);
            this.type2.TabIndex = 8;
            this.type2.TabStop = true;
            this.type2.Text = "Хугацаагүй";
            this.type2.UseVisualStyleBackColor = true;
            this.type2.CheckedChanged += new System.EventHandler(this.type2_CheckedChanged);
            // 
            // product
            // 
            this.product.BackColor = System.Drawing.Color.White;
            this.product.Enabled = false;
            this.product.FormattingEnabled = true;
            this.product.Items.AddRange(new object[] {
            "Энгийн",
            "Хүүхдийн",
            "Хуритлалын"});
            this.product.Location = new System.Drawing.Point(101, 225);
            this.product.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(330, 28);
            this.product.TabIndex = 9;
            // 
            // combo2
            // 
            this.combo2.FormattingEnabled = true;
            this.combo2.Items.AddRange(new object[] {
            "MNT",
            "USD",
            "EUR"});
            this.combo2.Location = new System.Drawing.Point(101, 291);
            this.combo2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combo2.Name = "combo2";
            this.combo2.Size = new System.Drawing.Size(330, 28);
            this.combo2.TabIndex = 10;
            // 
            // combo3
            // 
            this.combo3.Enabled = false;
            this.combo3.FormattingEnabled = true;
            this.combo3.Items.AddRange(new object[] {
            "5598174990",
            "5587145660"});
            this.combo3.Location = new System.Drawing.Point(101, 356);
            this.combo3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combo3.Name = "combo3";
            this.combo3.Size = new System.Drawing.Size(330, 28);
            this.combo3.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 406);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 39);
            this.button1.TabIndex = 12;
            this.button1.Text = "Данс нээх";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(58, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(372, 68);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Дансны төрөл:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.type1);
            this.groupBox2.Controls.Add(this.type2);
            this.groupBox2.Location = new System.Drawing.Point(58, 110);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(372, 68);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Хадгаламжийн төрөл:";
            // 
            // NewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 490);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.combo3);
            this.Controls.Add(this.combo2);
            this.Controls.Add(this.product);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NewAccount";
            this.Text = "Данс нээх";
            this.Load += new System.EventHandler(this.NewAccount_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton type1;
        private System.Windows.Forms.RadioButton type2;
        private System.Windows.Forms.ComboBox product;
        private System.Windows.Forms.ComboBox combo2;
        private System.Windows.Forms.ComboBox combo3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}