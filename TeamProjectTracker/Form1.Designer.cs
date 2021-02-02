
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.addElectCmd = new System.Windows.Forms.Button();
            this.updateElectCmd = new System.Windows.Forms.Button();
            this.deleteElectCmd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(81, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(234, 276);
            this.listBox1.TabIndex = 0;
            // 
            // addElectCmd
            // 
            this.addElectCmd.Location = new System.Drawing.Point(360, 12);
            this.addElectCmd.Name = "addElectCmd";
            this.addElectCmd.Size = new System.Drawing.Size(133, 68);
            this.addElectCmd.TabIndex = 1;
            this.addElectCmd.Text = "Add Electronics";
            this.addElectCmd.UseVisualStyleBackColor = true;
            // 
            // updateElectCmd
            // 
            this.updateElectCmd.Location = new System.Drawing.Point(360, 112);
            this.updateElectCmd.Name = "updateElectCmd";
            this.updateElectCmd.Size = new System.Drawing.Size(133, 69);
            this.updateElectCmd.TabIndex = 2;
            this.updateElectCmd.Text = "Update Electronics";
            this.updateElectCmd.UseVisualStyleBackColor = true;
            // 
            // deleteElectCmd
            // 
            this.deleteElectCmd.Location = new System.Drawing.Point(360, 213);
            this.deleteElectCmd.Name = "deleteElectCmd";
            this.deleteElectCmd.Size = new System.Drawing.Size(133, 75);
            this.deleteElectCmd.TabIndex = 3;
            this.deleteElectCmd.Text = "Delete Electronics";
            this.deleteElectCmd.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteElectCmd);
            this.Controls.Add(this.updateElectCmd);
            this.Controls.Add(this.addElectCmd);
            this.Controls.Add(this.listBox1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button addElectCmd;
        private System.Windows.Forms.Button updateElectCmd;
        private System.Windows.Forms.Button deleteElectCmd;
    }
}

