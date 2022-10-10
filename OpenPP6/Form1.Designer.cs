namespace OpenPP6
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
            this.Cbx_VideoOn = new System.Windows.Forms.CheckBox();
            this.Cbx_ProjectorsOn = new System.Windows.Forms.CheckBox();
            this.Cbx_AlterLigthsOn = new System.Windows.Forms.CheckBox();
            this.Btn_OpenPP6 = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Cbx_VideoOn
            // 
            this.Cbx_VideoOn.AutoSize = true;
            this.Cbx_VideoOn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cbx_VideoOn.Location = new System.Drawing.Point(88, 61);
            this.Cbx_VideoOn.Name = "Cbx_VideoOn";
            this.Cbx_VideoOn.Size = new System.Drawing.Size(360, 29);
            this.Cbx_VideoOn.TabIndex = 0;
            this.Cbx_VideoOn.Text = "Is the video signal splitter powered on?";
            this.Cbx_VideoOn.UseVisualStyleBackColor = true;
            this.Cbx_VideoOn.CheckedChanged += new System.EventHandler(this.Cbx_VideoOn_CheckedChanged);
            // 
            // Cbx_ProjectorsOn
            // 
            this.Cbx_ProjectorsOn.AutoSize = true;
            this.Cbx_ProjectorsOn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cbx_ProjectorsOn.Location = new System.Drawing.Point(88, 101);
            this.Cbx_ProjectorsOn.Name = "Cbx_ProjectorsOn";
            this.Cbx_ProjectorsOn.Size = new System.Drawing.Size(449, 29);
            this.Cbx_ProjectorsOn.TabIndex = 1;
            this.Cbx_ProjectorsOn.Text = "Are all three projectors powered on and working?";
            this.Cbx_ProjectorsOn.UseVisualStyleBackColor = true;
            this.Cbx_ProjectorsOn.CheckedChanged += new System.EventHandler(this.Cbx_ProjectorsOn_CheckedChanged);
            // 
            // Cbx_AlterLigthsOn
            // 
            this.Cbx_AlterLigthsOn.AutoSize = true;
            this.Cbx_AlterLigthsOn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cbx_AlterLigthsOn.Location = new System.Drawing.Point(88, 145);
            this.Cbx_AlterLigthsOn.Name = "Cbx_AlterLigthsOn";
            this.Cbx_AlterLigthsOn.Size = new System.Drawing.Size(326, 29);
            this.Cbx_AlterLigthsOn.TabIndex = 2;
            this.Cbx_AlterLigthsOn.Text = "Are all the altar lights powered on?";
            this.Cbx_AlterLigthsOn.UseVisualStyleBackColor = true;
            this.Cbx_AlterLigthsOn.CheckedChanged += new System.EventHandler(this.Cbx_AlterLigthsOn_CheckedChanged);
            // 
            // Btn_OpenPP6
            // 
            this.Btn_OpenPP6.Location = new System.Drawing.Point(256, 243);
            this.Btn_OpenPP6.Name = "Btn_OpenPP6";
            this.Btn_OpenPP6.Size = new System.Drawing.Size(129, 23);
            this.Btn_OpenPP6.TabIndex = 3;
            this.Btn_OpenPP6.Text = "Open ProPresenter";
            this.Btn_OpenPP6.UseVisualStyleBackColor = true;
            this.Btn_OpenPP6.Click += new System.EventHandler(this.Btn_OpenPP6_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(408, 243);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(129, 23);
            this.Btn_Cancel.TabIndex = 4;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 278);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_OpenPP6);
            this.Controls.Add(this.Cbx_AlterLigthsOn);
            this.Controls.Add(this.Cbx_ProjectorsOn);
            this.Controls.Add(this.Cbx_VideoOn);
            this.Name = "Form1";
            this.Text = "Open ProPresenter 6";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox Cbx_VideoOn;
        private CheckBox Cbx_ProjectorsOn;
        private CheckBox Cbx_AlterLigthsOn;
        private Button Btn_OpenPP6;
        private Button Btn_Cancel;
    }
}