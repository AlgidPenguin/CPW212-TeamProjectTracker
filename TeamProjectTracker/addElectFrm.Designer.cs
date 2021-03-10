
namespace TeamProjectTracker
{
    partial class addElectFrm
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
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.manufactTxt = new System.Windows.Forms.TextBox();
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.addElectCmd = new System.Windows.Forms.Button();
            this.categoryCbx = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(116, 38);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(135, 20);
            this.nameTxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Manufacturer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Category:";
            // 
            // manufactTxt
            // 
            this.manufactTxt.Location = new System.Drawing.Point(117, 99);
            this.manufactTxt.Name = "manufactTxt";
            this.manufactTxt.Size = new System.Drawing.Size(135, 20);
            this.manufactTxt.TabIndex = 5;
            // 
            // priceTxt
            // 
            this.priceTxt.Location = new System.Drawing.Point(117, 160);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.Size = new System.Drawing.Size(135, 20);
            this.priceTxt.TabIndex = 6;
            // 
            // addElectCmd
            // 
            this.addElectCmd.Location = new System.Drawing.Point(108, 262);
            this.addElectCmd.Margin = new System.Windows.Forms.Padding(2);
            this.addElectCmd.Name = "addElectCmd";
            this.addElectCmd.Size = new System.Drawing.Size(117, 61);
            this.addElectCmd.TabIndex = 9;
            this.addElectCmd.Text = "Add Electronic";
            this.addElectCmd.UseVisualStyleBackColor = true;
            this.addElectCmd.Click += new System.EventHandler(this.addElectCmd_Click);
            // 
            // categoryCbx
            // 
            this.categoryCbx.FormattingEnabled = true;
            this.categoryCbx.Location = new System.Drawing.Point(115, 217);
            this.categoryCbx.Name = "categoryCbx";
            this.categoryCbx.Size = new System.Drawing.Size(136, 21);
            this.categoryCbx.TabIndex = 10;
            // 
            // addElectFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 363);
            this.Controls.Add(this.categoryCbx);
            this.Controls.Add(this.addElectCmd);
            this.Controls.Add(this.priceTxt);
            this.Controls.Add(this.manufactTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.label1);
            this.Name = "addElectFrm";
            this.Text = "Add Electronic";
            this.Load += new System.EventHandler(this.addElectFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox manufactTxt;
        private System.Windows.Forms.TextBox priceTxt;
        private System.Windows.Forms.Button addElectCmd;
        private System.Windows.Forms.ComboBox categoryCbx;
    }
}