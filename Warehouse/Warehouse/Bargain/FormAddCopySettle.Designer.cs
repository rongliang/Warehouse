﻿namespace Warehouse.Bargain
{
    partial class FormAddCopySettle
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.s_czto = new System.Windows.Forms.TextBox();
            this.s_czfrom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.s_moneyType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.n_czxh = new System.Windows.Forms.TextBox();
            this.n_hsxh = new System.Windows.Forms.TextBox();
            this.s_hctype = new System.Windows.Forms.TextBox();
            this.s_Manufactcode = new System.Windows.Forms.TextBox();
            this.s_mtype = new System.Windows.Forms.TextBox();
            this.s_bargid = new System.Windows.Forms.TextBox();
            this.s_custid = new System.Windows.Forms.TextBox();
            this.n_cmsysid = new System.Windows.Forms.TextBox();
            this.n_TotMoney = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.n_Num = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.n_Fee = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.s_czto);
            this.panel1.Controls.Add(this.s_czfrom);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.s_moneyType);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.n_czxh);
            this.panel1.Controls.Add(this.n_hsxh);
            this.panel1.Controls.Add(this.s_hctype);
            this.panel1.Controls.Add(this.s_Manufactcode);
            this.panel1.Controls.Add(this.s_mtype);
            this.panel1.Controls.Add(this.s_bargid);
            this.panel1.Controls.Add(this.s_custid);
            this.panel1.Controls.Add(this.n_cmsysid);
            this.panel1.Controls.Add(this.n_TotMoney);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.n_Num);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.n_Fee);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 180);
            this.panel1.TabIndex = 0;
            // 
            // s_czto
            // 
            this.s_czto.Location = new System.Drawing.Point(115, 72);
            this.s_czto.Name = "s_czto";
            this.s_czto.ReadOnly = true;
            this.s_czto.Size = new System.Drawing.Size(120, 21);
            this.s_czto.TabIndex = 3;
            // 
            // s_czfrom
            // 
            this.s_czfrom.Location = new System.Drawing.Point(115, 46);
            this.s_czfrom.Name = "s_czfrom";
            this.s_czfrom.ReadOnly = true;
            this.s_czfrom.Size = new System.Drawing.Size(120, 21);
            this.s_czfrom.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 58;
            this.label5.Text = "抄张周期到";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 56;
            this.label4.Text = "抄张周期从";
            // 
            // s_moneyType
            // 
            this.s_moneyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.s_moneyType.FormattingEnabled = true;
            this.s_moneyType.Items.AddRange(new object[] {
            "--请选择--",
            "保内基本印量内",
            "保内基本印量外",
            "保外基本印量内",
            "保外基本印量外"});
            this.s_moneyType.Location = new System.Drawing.Point(115, 21);
            this.s_moneyType.Name = "s_moneyType";
            this.s_moneyType.Size = new System.Drawing.Size(121, 20);
            this.s_moneyType.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 54;
            this.label3.Text = "费用类别";
            // 
            // n_czxh
            // 
            this.n_czxh.BackColor = System.Drawing.Color.Red;
            this.n_czxh.Location = new System.Drawing.Point(9, 70);
            this.n_czxh.Name = "n_czxh";
            this.n_czxh.Size = new System.Drawing.Size(22, 21);
            this.n_czxh.TabIndex = 53;
            // 
            // n_hsxh
            // 
            this.n_hsxh.BackColor = System.Drawing.Color.Red;
            this.n_hsxh.Location = new System.Drawing.Point(9, 40);
            this.n_hsxh.Name = "n_hsxh";
            this.n_hsxh.Size = new System.Drawing.Size(22, 21);
            this.n_hsxh.TabIndex = 52;
            // 
            // s_hctype
            // 
            this.s_hctype.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.s_hctype.Location = new System.Drawing.Point(216, 3);
            this.s_hctype.Name = "s_hctype";
            this.s_hctype.Size = new System.Drawing.Size(22, 21);
            this.s_hctype.TabIndex = 49;
            // 
            // s_Manufactcode
            // 
            this.s_Manufactcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.s_Manufactcode.Location = new System.Drawing.Point(171, 3);
            this.s_Manufactcode.Name = "s_Manufactcode";
            this.s_Manufactcode.Size = new System.Drawing.Size(22, 21);
            this.s_Manufactcode.TabIndex = 48;
            // 
            // s_mtype
            // 
            this.s_mtype.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.s_mtype.Location = new System.Drawing.Point(143, 3);
            this.s_mtype.Name = "s_mtype";
            this.s_mtype.Size = new System.Drawing.Size(22, 21);
            this.s_mtype.TabIndex = 47;
            // 
            // s_bargid
            // 
            this.s_bargid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.s_bargid.Location = new System.Drawing.Point(115, 3);
            this.s_bargid.Name = "s_bargid";
            this.s_bargid.Size = new System.Drawing.Size(22, 21);
            this.s_bargid.TabIndex = 46;
            // 
            // s_custid
            // 
            this.s_custid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.s_custid.Location = new System.Drawing.Point(87, 3);
            this.s_custid.Name = "s_custid";
            this.s_custid.Size = new System.Drawing.Size(22, 21);
            this.s_custid.TabIndex = 45;
            // 
            // n_cmsysid
            // 
            this.n_cmsysid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.n_cmsysid.Location = new System.Drawing.Point(12, 3);
            this.n_cmsysid.Name = "n_cmsysid";
            this.n_cmsysid.Size = new System.Drawing.Size(22, 21);
            this.n_cmsysid.TabIndex = 44;
            // 
            // n_TotMoney
            // 
            this.n_TotMoney.Location = new System.Drawing.Point(115, 151);
            this.n_TotMoney.Name = "n_TotMoney";
            this.n_TotMoney.ReadOnly = true;
            this.n_TotMoney.Size = new System.Drawing.Size(121, 21);
            this.n_TotMoney.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(56, 154);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 42;
            this.label13.Text = "基本金额";
            // 
            // n_Num
            // 
            this.n_Num.Location = new System.Drawing.Point(115, 124);
            this.n_Num.Name = "n_Num";
            this.n_Num.Size = new System.Drawing.Size(121, 21);
            this.n_Num.TabIndex = 5;
            this.n_Num.TextChanged += new System.EventHandler(this.n_Fee_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 24;
            this.label2.Text = "数量";
            // 
            // n_Fee
            // 
            this.n_Fee.Location = new System.Drawing.Point(115, 98);
            this.n_Fee.Name = "n_Fee";
            this.n_Fee.Size = new System.Drawing.Size(121, 21);
            this.n_Fee.TabIndex = 4;
            this.n_Fee.TextChanged += new System.EventHandler(this.n_Fee_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 22;
            this.label1.Text = "单价";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(171, 187);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "关闭";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormAddCopySettle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 216);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FormAddCopySettle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "抄张结算编辑";
            this.Load += new System.EventHandler(this.FormAddCopySettle_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormAddCopySettle_KeyPress);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox n_TotMoney;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox n_Num;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox n_Fee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox n_hsxh;
        private System.Windows.Forms.TextBox s_hctype;
        private System.Windows.Forms.TextBox s_Manufactcode;
        private System.Windows.Forms.TextBox s_mtype;
        private System.Windows.Forms.TextBox s_bargid;
        private System.Windows.Forms.TextBox s_custid;
        private System.Windows.Forms.TextBox n_cmsysid;
        private System.Windows.Forms.TextBox n_czxh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox s_moneyType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox s_czto;
        private System.Windows.Forms.TextBox s_czfrom;

    }
}