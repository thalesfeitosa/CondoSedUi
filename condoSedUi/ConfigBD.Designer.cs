namespace condoSedUi
{
    partial class ConfigBD
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.servidorTextBox = new System.Windows.Forms.TextBox();
            this.bdTextBox = new System.Windows.Forms.TextBox();
            this.conectaBdButton = new System.Windows.Forms.Button();
            this.closeFormBdButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.closeFormBdButton);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 113);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(38, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Servidor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(38, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Banco de Dados";
            // 
            // servidorTextBox
            // 
            this.servidorTextBox.Location = new System.Drawing.Point(41, 182);
            this.servidorTextBox.Name = "servidorTextBox";
            this.servidorTextBox.Size = new System.Drawing.Size(184, 20);
            this.servidorTextBox.TabIndex = 3;
            // 
            // bdTextBox
            // 
            this.bdTextBox.Location = new System.Drawing.Point(41, 239);
            this.bdTextBox.Name = "bdTextBox";
            this.bdTextBox.Size = new System.Drawing.Size(184, 20);
            this.bdTextBox.TabIndex = 4;
            // 
            // conectaBdButton
            // 
            this.conectaBdButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.conectaBdButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.conectaBdButton.FlatAppearance.BorderSize = 0;
            this.conectaBdButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.conectaBdButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conectaBdButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.conectaBdButton.Location = new System.Drawing.Point(0, 300);
            this.conectaBdButton.Name = "conectaBdButton";
            this.conectaBdButton.Size = new System.Drawing.Size(261, 23);
            this.conectaBdButton.TabIndex = 5;
            this.conectaBdButton.Text = "Conectar";
            this.conectaBdButton.UseVisualStyleBackColor = true;
            this.conectaBdButton.Click += new System.EventHandler(this.conectaBdButton_Click);
            // 
            // closeFormBdButton
            // 
            this.closeFormBdButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeFormBdButton.FlatAppearance.BorderSize = 0;
            this.closeFormBdButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeFormBdButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeFormBdButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.closeFormBdButton.Location = new System.Drawing.Point(231, 0);
            this.closeFormBdButton.Name = "closeFormBdButton";
            this.closeFormBdButton.Size = new System.Drawing.Size(30, 23);
            this.closeFormBdButton.TabIndex = 6;
            this.closeFormBdButton.Text = "X";
            this.closeFormBdButton.UseVisualStyleBackColor = true;
            this.closeFormBdButton.Click += new System.EventHandler(this.closeFormBdButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::condoSedUi.Properties.Resources.bd;
            this.pictureBox1.Location = new System.Drawing.Point(55, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ConfigBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(261, 323);
            this.Controls.Add(this.conectaBdButton);
            this.Controls.Add(this.bdTextBox);
            this.Controls.Add(this.servidorTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfigBD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfigBD";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox servidorTextBox;
        private System.Windows.Forms.TextBox bdTextBox;
        private System.Windows.Forms.Button conectaBdButton;
        private System.Windows.Forms.Button closeFormBdButton;
    }
}