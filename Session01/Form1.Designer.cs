﻿namespace Session01
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNewProduct = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBoxNames = new System.Windows.Forms.ListBox();
            this.btnAddName = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalcAdd = new System.Windows.Forms.Button();
            this.btnCalcSub = new System.Windows.Forms.Button();
            this.btnCalcMul = new System.Windows.Forms.Button();
            this.btnCalcDiv = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNewProduct
            // 
            this.btnNewProduct.Location = new System.Drawing.Point(12, 12);
            this.btnNewProduct.Name = "btnNewProduct";
            this.btnNewProduct.Size = new System.Drawing.Size(152, 23);
            this.btnNewProduct.TabIndex = 0;
            this.btnNewProduct.Text = "New Product";
            this.btnNewProduct.UseVisualStyleBackColor = true;
            this.btnNewProduct.Click += new System.EventHandler(this.btnNewProduct_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBoxNames);
            this.panel1.Controls.Add(this.btnAddName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Location = new System.Drawing.Point(12, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 375);
            this.panel1.TabIndex = 1;
            // 
            // listBoxNames
            // 
            this.listBoxNames.FormattingEnabled = true;
            this.listBoxNames.ItemHeight = 15;
            this.listBoxNames.Location = new System.Drawing.Point(72, 67);
            this.listBoxNames.Name = "listBoxNames";
            this.listBoxNames.Size = new System.Drawing.Size(211, 244);
            this.listBoxNames.TabIndex = 3;
            // 
            // btnAddName
            // 
            this.btnAddName.Location = new System.Drawing.Point(289, 28);
            this.btnAddName.Name = "btnAddName";
            this.btnAddName.Size = new System.Drawing.Size(75, 23);
            this.btnAddName.TabIndex = 2;
            this.btnAddName.Text = "Add";
            this.btnAddName.UseVisualStyleBackColor = true;
            this.btnAddName.Click += new System.EventHandler(this.btnAddName_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(72, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(211, 23);
            this.txtName.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnCalcDiv);
            this.panel2.Controls.Add(this.btnCalcMul);
            this.panel2.Controls.Add(this.btnCalcSub);
            this.panel2.Controls.Add(this.btnCalcAdd);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtB);
            this.panel2.Controls.Add(this.txtA);
            this.panel2.Location = new System.Drawing.Point(404, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 375);
            this.panel2.TabIndex = 2;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(54, 28);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(210, 23);
            this.txtA.TabIndex = 1;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(54, 57);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(210, 23);
            this.txtB.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "B";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "A";
            // 
            // btnCalcAdd
            // 
            this.btnCalcAdd.Location = new System.Drawing.Point(54, 86);
            this.btnCalcAdd.Name = "btnCalcAdd";
            this.btnCalcAdd.Size = new System.Drawing.Size(48, 23);
            this.btnCalcAdd.TabIndex = 5;
            this.btnCalcAdd.Text = "+";
            this.btnCalcAdd.UseVisualStyleBackColor = true;
            // 
            // btnCalcSub
            // 
            this.btnCalcSub.Location = new System.Drawing.Point(108, 86);
            this.btnCalcSub.Name = "btnCalcSub";
            this.btnCalcSub.Size = new System.Drawing.Size(48, 23);
            this.btnCalcSub.TabIndex = 6;
            this.btnCalcSub.Text = "-";
            this.btnCalcSub.UseVisualStyleBackColor = true;
            // 
            // btnCalcMul
            // 
            this.btnCalcMul.Location = new System.Drawing.Point(162, 86);
            this.btnCalcMul.Name = "btnCalcMul";
            this.btnCalcMul.Size = new System.Drawing.Size(48, 23);
            this.btnCalcMul.TabIndex = 7;
            this.btnCalcMul.Text = "*";
            this.btnCalcMul.UseVisualStyleBackColor = true;
            // 
            // btnCalcDiv
            // 
            this.btnCalcDiv.Location = new System.Drawing.Point(216, 86);
            this.btnCalcDiv.Name = "btnCalcDiv";
            this.btnCalcDiv.Size = new System.Drawing.Size(48, 23);
            this.btnCalcDiv.TabIndex = 8;
            this.btnCalcDiv.Text = "/";
            this.btnCalcDiv.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Result";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 130);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(208, 23);
            this.textBox1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 507);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnNewProduct);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnNewProduct;
        private Panel panel1;
        private ListBox listBoxNames;
        private Button btnAddName;
        private Label label1;
        private TextBox txtName;
        private Panel panel2;
        private TextBox textBox1;
        private Label label4;
        private Button btnCalcDiv;
        private Button btnCalcMul;
        private Button btnCalcSub;
        private Button btnCalcAdd;
        private Label label2;
        private Label label3;
        private TextBox txtB;
        private TextBox txtA;
    }
}