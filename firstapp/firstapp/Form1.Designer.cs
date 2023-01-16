
namespace firstapp
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
            this.twanst = new System.Windows.Forms.Label();
            this.calculation = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnsum = new System.Windows.Forms.Button();
            this.btnsub = new System.Windows.Forms.Button();
            this.btndiv = new System.Windows.Forms.Button();
            this.btnmul = new System.Windows.Forms.Button();
            this.btncamcel = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // twanst
            // 
            this.twanst.AutoSize = true;
            this.twanst.Font = new System.Drawing.Font("Snap ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.twanst.ForeColor = System.Drawing.SystemColors.ControlText;
            this.twanst.Location = new System.Drawing.Point(85, 24);
            this.twanst.Name = "twanst";
            this.twanst.Size = new System.Drawing.Size(205, 31);
            this.twanst.TabIndex = 0;
            this.twanst.Text = "TwanstCodes";
            this.twanst.Click += new System.EventHandler(this.label1_Click);
            // 
            // calculation
            // 
            this.calculation.AutoSize = true;
            this.calculation.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.calculation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.calculation.Location = new System.Drawing.Point(112, 55);
            this.calculation.Name = "calculation";
            this.calculation.Size = new System.Drawing.Size(156, 25);
            this.calculation.TabIndex = 1;
            this.calculation.Text = "Calculation";
            this.calculation.Click += new System.EventHandler(this.calculation_Click);
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(132, 105);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(237, 23);
            this.num1.TabIndex = 2;
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(132, 161);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(237, 23);
            this.num2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Urdu Typesetting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(4, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "numberTwo";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Urdu Typesetting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(4, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 38);
            this.label2.TabIndex = 5;
            this.label2.Text = "numberOne";
            // 
            // btnsum
            // 
            this.btnsum.Location = new System.Drawing.Point(8, 308);
            this.btnsum.Name = "btnsum";
            this.btnsum.Size = new System.Drawing.Size(160, 29);
            this.btnsum.TabIndex = 6;
            this.btnsum.Text = "SUM";
            this.btnsum.UseVisualStyleBackColor = true;
            this.btnsum.Click += new System.EventHandler(this.btnsum_Click);
            // 
            // btnsub
            // 
            this.btnsub.Location = new System.Drawing.Point(208, 308);
            this.btnsub.Name = "btnsub";
            this.btnsub.Size = new System.Drawing.Size(160, 29);
            this.btnsub.TabIndex = 7;
            this.btnsub.Text = "SUB";
            this.btnsub.UseVisualStyleBackColor = true;
            this.btnsub.Click += new System.EventHandler(this.btnsub_Click);
            // 
            // btndiv
            // 
            this.btndiv.Location = new System.Drawing.Point(208, 359);
            this.btndiv.Name = "btndiv";
            this.btndiv.Size = new System.Drawing.Size(160, 29);
            this.btndiv.TabIndex = 8;
            this.btndiv.Text = "DIV";
            this.btndiv.UseVisualStyleBackColor = true;
            this.btndiv.Click += new System.EventHandler(this.btndiv_Click);
            // 
            // btnmul
            // 
            this.btnmul.Location = new System.Drawing.Point(8, 359);
            this.btnmul.Name = "btnmul";
            this.btnmul.Size = new System.Drawing.Size(160, 29);
            this.btnmul.TabIndex = 9;
            this.btnmul.Text = "MUL";
            this.btnmul.UseVisualStyleBackColor = true;
            this.btnmul.Click += new System.EventHandler(this.btnmul_Click);
            // 
            // btncamcel
            // 
            this.btncamcel.Location = new System.Drawing.Point(111, 422);
            this.btncamcel.Name = "btncamcel";
            this.btncamcel.Size = new System.Drawing.Size(160, 29);
            this.btncamcel.TabIndex = 10;
            this.btncamcel.Text = "AC";
            this.btncamcel.UseVisualStyleBackColor = true;
            this.btncamcel.Click += new System.EventHandler(this.btncamcel_Click);
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.Color.Transparent;
            this.result.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.result.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.result.Font = new System.Drawing.Font("Engravers MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.result.Location = new System.Drawing.Point(132, 228);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(236, 38);
            this.result.TabIndex = 11;
            this.result.Text = "                              ";
            this.result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Urdu Typesetting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(12, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 38);
            this.label4.TabIndex = 12;
            this.label4.Text = "RESULT";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(112, 475);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(203, 15);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://github.com/TwanstDeveloper";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(338, -3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 43);
            this.button1.TabIndex = 14;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Urdu Typesetting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(12, 457);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 38);
            this.label3.TabIndex = 15;
            this.label3.Text = "GitHub";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(380, 499);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.result);
            this.Controls.Add(this.btncamcel);
            this.Controls.Add(this.btnmul);
            this.Controls.Add(this.btndiv);
            this.Controls.Add(this.btnsub);
            this.Controls.Add(this.btnsum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.calculation);
            this.Controls.Add(this.twanst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label twanst;
        private System.Windows.Forms.Label calculation;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnsum;
        private System.Windows.Forms.Button btnsub;
        private System.Windows.Forms.Button btndiv;
        private System.Windows.Forms.Button btnmul;
        private System.Windows.Forms.Button btncamcel;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
    }
}

