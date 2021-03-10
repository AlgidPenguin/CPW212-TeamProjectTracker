
namespace TeamProjectTracker
{
    partial class MainForm
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
            this.productLstBox = new System.Windows.Forms.ListBox();
            this.addElectCmd = new System.Windows.Forms.Button();
            this.updateElectCmd = new System.Windows.Forms.Button();
            this.deleteElectCmd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.productLstBox.FormattingEnabled = true;
            this.productLstBox.Location = new System.Drawing.Point(61, 10);
            this.productLstBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.productLstBox.Name = "listBox1";
            this.productLstBox.Size = new System.Drawing.Size(176, 225);
            this.productLstBox.TabIndex = 0;
            // 
            // addElectCmd
            // 
            this.addElectCmd.Location = new System.Drawing.Point(270, 10);
            this.addElectCmd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addElectCmd.Name = "addElectCmd";
            this.addElectCmd.Size = new System.Drawing.Size(100, 55);
            this.addElectCmd.TabIndex = 1;
            this.addElectCmd.Text = "Add Electronic";
            this.addElectCmd.UseVisualStyleBackColor = true;
            this.addElectCmd.Click += new System.EventHandler(this.addElectCmd_Click);
            // 
            // updateElectCmd
            // 
            this.updateElectCmd.Location = new System.Drawing.Point(270, 91);
            this.updateElectCmd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.updateElectCmd.Name = "updateElectCmd";
            this.updateElectCmd.Size = new System.Drawing.Size(100, 56);
            this.updateElectCmd.TabIndex = 2;
            this.updateElectCmd.Text = "Update Electronic";
            this.updateElectCmd.UseVisualStyleBackColor = true;
            this.updateElectCmd.Click += new System.EventHandler(this.updateElectCmd_Click);
            // 
            // deleteElectCmd
            // 
            this.deleteElectCmd.Location = new System.Drawing.Point(270, 173);
            this.deleteElectCmd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteElectCmd.Name = "deleteElectCmd";
            this.deleteElectCmd.Size = new System.Drawing.Size(100, 61);
            this.deleteElectCmd.TabIndex = 3;
            this.deleteElectCmd.Text = "Delete Electronic";
            this.deleteElectCmd.UseVisualStyleBackColor = true;
            this.deleteElectCmd.Click += new System.EventHandler(this.deleteElectCmd_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.deleteElectCmd);
            this.Controls.Add(this.updateElectCmd);
            this.Controls.Add(this.addElectCmd);
            this.Controls.Add(this.productLstBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox productLstBox;
        private System.Windows.Forms.Button addElectCmd;
        private System.Windows.Forms.Button updateElectCmd;
        private System.Windows.Forms.Button deleteElectCmd;
    }
}

