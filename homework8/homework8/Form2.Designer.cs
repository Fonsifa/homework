namespace homework8
{
    partial class 修改订单
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.goodsidlabel = new System.Windows.Forms.Label();
            this.goodsidtextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.customeridtextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pricetextBox = new System.Windows.Forms.TextBox();
            this.amounttextBox = new System.Windows.Forms.TextBox();
            this.goodstextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.customertextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IDtextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.savebutton = new System.Windows.Forms.Button();
            this.changebutton = new System.Windows.Forms.Button();
            this.createbutton = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.deletebutton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.goodsidlabel);
            this.groupBox1.Controls.Add(this.goodsidtextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.customeridtextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pricetextBox);
            this.groupBox1.Controls.Add(this.amounttextBox);
            this.groupBox1.Controls.Add(this.goodstextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.customertextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.IDtextBox);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 355);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本信息";
            // 
            // goodsidlabel
            // 
            this.goodsidlabel.AutoSize = true;
            this.goodsidlabel.Location = new System.Drawing.Point(405, 157);
            this.goodsidlabel.Name = "goodsidlabel";
            this.goodsidlabel.Size = new System.Drawing.Size(68, 15);
            this.goodsidlabel.TabIndex = 13;
            this.goodsidlabel.Text = "商品id：";
            // 
            // goodsidtextBox
            // 
            this.goodsidtextBox.Location = new System.Drawing.Point(495, 147);
            this.goodsidtextBox.Name = "goodsidtextBox";
            this.goodsidtextBox.Size = new System.Drawing.Size(146, 25);
            this.goodsidtextBox.TabIndex = 12;
            this.goodsidtextBox.TextChanged += new System.EventHandler(this.goodsidtextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(404, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "客户id：";
            // 
            // customeridtextBox
            // 
            this.customeridtextBox.Location = new System.Drawing.Point(495, 89);
            this.customeridtextBox.Name = "customeridtextBox";
            this.customeridtextBox.Size = new System.Drawing.Size(146, 25);
            this.customeridtextBox.TabIndex = 10;
            this.customeridtextBox.TextChanged += new System.EventHandler(this.customeridtextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(113, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "单价：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "数量：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "商品：";
            // 
            // pricetextBox
            // 
            this.pricetextBox.Location = new System.Drawing.Point(171, 259);
            this.pricetextBox.Name = "pricetextBox";
            this.pricetextBox.Size = new System.Drawing.Size(301, 25);
            this.pricetextBox.TabIndex = 6;
            this.pricetextBox.TextChanged += new System.EventHandler(this.pricetextBox_TextChanged);
            // 
            // amounttextBox
            // 
            this.amounttextBox.Location = new System.Drawing.Point(171, 202);
            this.amounttextBox.Name = "amounttextBox";
            this.amounttextBox.Size = new System.Drawing.Size(301, 25);
            this.amounttextBox.TabIndex = 5;
            this.amounttextBox.TextChanged += new System.EventHandler(this.amounttextBox_TextChanged);
            // 
            // goodstextBox
            // 
            this.goodstextBox.Location = new System.Drawing.Point(172, 147);
            this.goodstextBox.Name = "goodstextBox";
            this.goodstextBox.Size = new System.Drawing.Size(160, 25);
            this.goodstextBox.TabIndex = 4;
            this.goodstextBox.TextChanged += new System.EventHandler(this.goodstextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "客户：";
            // 
            // customertextBox
            // 
            this.customertextBox.Location = new System.Drawing.Point(172, 89);
            this.customertextBox.Name = "customertextBox";
            this.customertextBox.Size = new System.Drawing.Size(160, 25);
            this.customertextBox.TabIndex = 2;
            this.customertextBox.TextChanged += new System.EventHandler(this.customertextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "订单ID：";
            // 
            // IDtextBox
            // 
            this.IDtextBox.Location = new System.Drawing.Point(172, 37);
            this.IDtextBox.Name = "IDtextBox";
            this.IDtextBox.Size = new System.Drawing.Size(301, 25);
            this.IDtextBox.TabIndex = 0;
            this.IDtextBox.TextChanged += new System.EventHandler(this.IDtextBox_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.deletebutton);
            this.panel1.Controls.Add(this.savebutton);
            this.panel1.Controls.Add(this.changebutton);
            this.panel1.Controls.Add(this.createbutton);
            this.panel1.Location = new System.Drawing.Point(3, 355);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 100);
            this.panel1.TabIndex = 5;
            // 
            // savebutton
            // 
            this.savebutton.Location = new System.Drawing.Point(645, 41);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(86, 31);
            this.savebutton.TabIndex = 3;
            this.savebutton.Text = "保存";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // changebutton
            // 
            this.changebutton.Location = new System.Drawing.Point(250, 41);
            this.changebutton.Name = "changebutton";
            this.changebutton.Size = new System.Drawing.Size(92, 31);
            this.changebutton.TabIndex = 1;
            this.changebutton.Text = "修改";
            this.changebutton.UseVisualStyleBackColor = true;
            this.changebutton.Click += new System.EventHandler(this.changebutton_Click);
            // 
            // createbutton
            // 
            this.createbutton.Location = new System.Drawing.Point(50, 41);
            this.createbutton.Name = "createbutton";
            this.createbutton.Size = new System.Drawing.Size(92, 31);
            this.createbutton.TabIndex = 0;
            this.createbutton.Text = "创建";
            this.createbutton.UseVisualStyleBackColor = true;
            this.createbutton.Click += new System.EventHandler(this.createbutton_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(ordertest.OrderDetail);
            // 
            // deletebutton
            // 
            this.deletebutton.Location = new System.Drawing.Point(423, 41);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(92, 31);
            this.deletebutton.TabIndex = 6;
            this.deletebutton.Text = "删除";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // 修改订单
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "修改订单";
            this.Text = "修改订单";
            this.Load += new System.EventHandler(this.修改订单_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox IDtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox customertextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Button changebutton;
        private System.Windows.Forms.Button createbutton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pricetextBox;
        private System.Windows.Forms.TextBox amounttextBox;
        private System.Windows.Forms.TextBox goodstextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox customeridtextBox;
        private System.Windows.Forms.TextBox goodsidtextBox;
        private System.Windows.Forms.Label goodsidlabel;
        private System.Windows.Forms.Button deletebutton;
    }
}