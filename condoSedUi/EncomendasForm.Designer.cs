namespace condoSedUi
{
    partial class EncomendasForm
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
            this.destinatarioLbl = new System.Windows.Forms.Label();
            this.apartamentoLbl = new System.Windows.Forms.Label();
            this.blocoLbl = new System.Windows.Forms.Label();
            this.rastreamentoLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.statusCheckBox = new System.Windows.Forms.CheckBox();
            this.destinatarioTxtBox = new System.Windows.Forms.TextBox();
            this.apartamentoTxtBox = new System.Windows.Forms.TextBox();
            this.blocoTxtBox = new System.Windows.Forms.TextBox();
            this.recebedorCondominioTxtBox = new System.Windows.Forms.TextBox();
            this.recebedorCondominoTxtBox = new System.Windows.Forms.TextBox();
            this.rastreamentoTxtBox = new System.Windows.Forms.TextBox();
            this.encomendasGridView = new System.Windows.Forms.DataGridView();
            this.Destinatario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apartamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bloco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Recebedor_Condominio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Condomino_Recebedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rastreamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.encomendaSaveButton = new System.Windows.Forms.Button();
            this.buscarTxtBox = new System.Windows.Forms.TextBox();
            this.buscarButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.localizacaoLbl = new System.Windows.Forms.Label();
            this.localizacaoTxtBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.encomendasGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(349, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Encomendas";
            // 
            // destinatarioLbl
            // 
            this.destinatarioLbl.AutoSize = true;
            this.destinatarioLbl.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destinatarioLbl.Location = new System.Drawing.Point(24, 105);
            this.destinatarioLbl.Name = "destinatarioLbl";
            this.destinatarioLbl.Size = new System.Drawing.Size(126, 24);
            this.destinatarioLbl.TabIndex = 1;
            this.destinatarioLbl.Text = "Destinatário:";
            // 
            // apartamentoLbl
            // 
            this.apartamentoLbl.AutoSize = true;
            this.apartamentoLbl.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apartamentoLbl.Location = new System.Drawing.Point(428, 105);
            this.apartamentoLbl.Name = "apartamentoLbl";
            this.apartamentoLbl.Size = new System.Drawing.Size(133, 24);
            this.apartamentoLbl.TabIndex = 2;
            this.apartamentoLbl.Text = "Apartamento:";
            // 
            // blocoLbl
            // 
            this.blocoLbl.AutoSize = true;
            this.blocoLbl.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blocoLbl.Location = new System.Drawing.Point(665, 105);
            this.blocoLbl.Name = "blocoLbl";
            this.blocoLbl.Size = new System.Drawing.Size(66, 24);
            this.blocoLbl.TabIndex = 3;
            this.blocoLbl.Text = "Bloco:";
            // 
            // rastreamentoLbl
            // 
            this.rastreamentoLbl.AutoSize = true;
            this.rastreamentoLbl.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rastreamentoLbl.Location = new System.Drawing.Point(24, 184);
            this.rastreamentoLbl.Name = "rastreamentoLbl";
            this.rastreamentoLbl.Size = new System.Drawing.Size(141, 24);
            this.rastreamentoLbl.TabIndex = 4;
            this.rastreamentoLbl.Text = "Rastreamento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Recebedor Condomínio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(428, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Condomino recebedor:";
            // 
            // statusCheckBox
            // 
            this.statusCheckBox.AutoSize = true;
            this.statusCheckBox.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusCheckBox.Location = new System.Drawing.Point(432, 184);
            this.statusCheckBox.Name = "statusCheckBox";
            this.statusCheckBox.Size = new System.Drawing.Size(229, 28);
            this.statusCheckBox.TabIndex = 7;
            this.statusCheckBox.Text = "Entregue ao Condômino";
            this.statusCheckBox.UseVisualStyleBackColor = true;
            // 
            // destinatarioTxtBox
            // 
            this.destinatarioTxtBox.Location = new System.Drawing.Point(150, 109);
            this.destinatarioTxtBox.Name = "destinatarioTxtBox";
            this.destinatarioTxtBox.Size = new System.Drawing.Size(265, 20);
            this.destinatarioTxtBox.TabIndex = 8;
            // 
            // apartamentoTxtBox
            // 
            this.apartamentoTxtBox.Location = new System.Drawing.Point(555, 110);
            this.apartamentoTxtBox.Name = "apartamentoTxtBox";
            this.apartamentoTxtBox.Size = new System.Drawing.Size(106, 20);
            this.apartamentoTxtBox.TabIndex = 9;
            // 
            // blocoTxtBox
            // 
            this.blocoTxtBox.Location = new System.Drawing.Point(737, 110);
            this.blocoTxtBox.Name = "blocoTxtBox";
            this.blocoTxtBox.Size = new System.Drawing.Size(106, 20);
            this.blocoTxtBox.TabIndex = 10;
            // 
            // recebedorCondominioTxtBox
            // 
            this.recebedorCondominioTxtBox.Location = new System.Drawing.Point(245, 147);
            this.recebedorCondominioTxtBox.Name = "recebedorCondominioTxtBox";
            this.recebedorCondominioTxtBox.Size = new System.Drawing.Size(177, 20);
            this.recebedorCondominioTxtBox.TabIndex = 11;
            // 
            // recebedorCondominoTxtBox
            // 
            this.recebedorCondominoTxtBox.Location = new System.Drawing.Point(649, 147);
            this.recebedorCondominoTxtBox.Name = "recebedorCondominoTxtBox";
            this.recebedorCondominoTxtBox.Size = new System.Drawing.Size(194, 20);
            this.recebedorCondominoTxtBox.TabIndex = 12;
            // 
            // rastreamentoTxtBox
            // 
            this.rastreamentoTxtBox.Location = new System.Drawing.Point(162, 188);
            this.rastreamentoTxtBox.Name = "rastreamentoTxtBox";
            this.rastreamentoTxtBox.Size = new System.Drawing.Size(253, 20);
            this.rastreamentoTxtBox.TabIndex = 13;
            // 
            // encomendasGridView
            // 
            this.encomendasGridView.AllowUserToAddRows = false;
            this.encomendasGridView.AllowUserToDeleteRows = false;
            this.encomendasGridView.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.encomendasGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.encomendasGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.encomendasGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Destinatario,
            this.Apartamento,
            this.Bloco,
            this.Recebedor_Condominio,
            this.Condomino_Recebedor,
            this.Rastreamento,
            this.Status});
            this.encomendasGridView.GridColor = System.Drawing.Color.Honeydew;
            this.encomendasGridView.Location = new System.Drawing.Point(77, 249);
            this.encomendasGridView.Name = "encomendasGridView";
            this.encomendasGridView.ReadOnly = true;
            this.encomendasGridView.Size = new System.Drawing.Size(744, 245);
            this.encomendasGridView.TabIndex = 14;
            // 
            // Destinatario
            // 
            this.Destinatario.HeaderText = "Destinatario";
            this.Destinatario.Name = "Destinatario";
            this.Destinatario.ReadOnly = true;
            // 
            // Apartamento
            // 
            this.Apartamento.HeaderText = "Apartamento";
            this.Apartamento.Name = "Apartamento";
            this.Apartamento.ReadOnly = true;
            // 
            // Bloco
            // 
            this.Bloco.HeaderText = "Bloco";
            this.Bloco.Name = "Bloco";
            this.Bloco.ReadOnly = true;
            // 
            // Recebedor_Condominio
            // 
            this.Recebedor_Condominio.HeaderText = "Recebedor_Condominio";
            this.Recebedor_Condominio.Name = "Recebedor_Condominio";
            this.Recebedor_Condominio.ReadOnly = true;
            // 
            // Condomino_Recebedor
            // 
            this.Condomino_Recebedor.HeaderText = "Condomino_Recebedor";
            this.Condomino_Recebedor.Name = "Condomino_Recebedor";
            this.Condomino_Recebedor.ReadOnly = true;
            // 
            // Rastreamento
            // 
            this.Rastreamento.HeaderText = "Rastreamento";
            this.Rastreamento.Name = "Rastreamento";
            this.Rastreamento.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // encomendaSaveButton
            // 
            this.encomendaSaveButton.FlatAppearance.BorderSize = 0;
            this.encomendaSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.encomendaSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encomendaSaveButton.Location = new System.Drawing.Point(768, 497);
            this.encomendaSaveButton.Name = "encomendaSaveButton";
            this.encomendaSaveButton.Size = new System.Drawing.Size(75, 23);
            this.encomendaSaveButton.TabIndex = 15;
            this.encomendaSaveButton.Text = "Salvar";
            this.encomendaSaveButton.UseVisualStyleBackColor = true;
            // 
            // buscarTxtBox
            // 
            this.buscarTxtBox.Location = new System.Drawing.Point(478, 52);
            this.buscarTxtBox.Name = "buscarTxtBox";
            this.buscarTxtBox.Size = new System.Drawing.Size(198, 20);
            this.buscarTxtBox.TabIndex = 16;
            this.buscarTxtBox.Text = "Destinatário ou Rastreamento";
            // 
            // buscarButton
            // 
            this.buscarButton.FlatAppearance.BorderSize = 0;
            this.buscarButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buscarButton.Location = new System.Drawing.Point(682, 51);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(75, 23);
            this.buscarButton.TabIndex = 17;
            this.buscarButton.Text = "Buscar";
            this.buscarButton.UseVisualStyleBackColor = true;
            this.buscarButton.Click += new System.EventHandler(this.buscarButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(824, -1);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(35, 23);
            this.closeButton.TabIndex = 18;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // localizacaoLbl
            // 
            this.localizacaoLbl.AutoSize = true;
            this.localizacaoLbl.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localizacaoLbl.Location = new System.Drawing.Point(24, 211);
            this.localizacaoLbl.Name = "localizacaoLbl";
            this.localizacaoLbl.Size = new System.Drawing.Size(122, 24);
            this.localizacaoLbl.TabIndex = 19;
            this.localizacaoLbl.Text = "Localização:";
            // 
            // localizacaoTxtBox
            // 
            this.localizacaoTxtBox.Location = new System.Drawing.Point(162, 214);
            this.localizacaoTxtBox.Name = "localizacaoTxtBox";
            this.localizacaoTxtBox.Size = new System.Drawing.Size(253, 20);
            this.localizacaoTxtBox.TabIndex = 20;
            // 
            // EncomendasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(859, 530);
            this.Controls.Add(this.localizacaoTxtBox);
            this.Controls.Add(this.localizacaoLbl);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.buscarButton);
            this.Controls.Add(this.buscarTxtBox);
            this.Controls.Add(this.encomendaSaveButton);
            this.Controls.Add(this.encomendasGridView);
            this.Controls.Add(this.rastreamentoTxtBox);
            this.Controls.Add(this.recebedorCondominoTxtBox);
            this.Controls.Add(this.recebedorCondominioTxtBox);
            this.Controls.Add(this.blocoTxtBox);
            this.Controls.Add(this.apartamentoTxtBox);
            this.Controls.Add(this.destinatarioTxtBox);
            this.Controls.Add(this.statusCheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rastreamentoLbl);
            this.Controls.Add(this.blocoLbl);
            this.Controls.Add(this.apartamentoLbl);
            this.Controls.Add(this.destinatarioLbl);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.MintCream;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(192, 0);
            this.Name = "EncomendasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EncomendasForm";
            ((System.ComponentModel.ISupportInitialize)(this.encomendasGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label destinatarioLbl;
        private System.Windows.Forms.Label apartamentoLbl;
        private System.Windows.Forms.Label blocoLbl;
        private System.Windows.Forms.Label rastreamentoLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox statusCheckBox;
        private System.Windows.Forms.TextBox destinatarioTxtBox;
        private System.Windows.Forms.TextBox apartamentoTxtBox;
        private System.Windows.Forms.TextBox blocoTxtBox;
        private System.Windows.Forms.TextBox recebedorCondominioTxtBox;
        private System.Windows.Forms.TextBox recebedorCondominoTxtBox;
        private System.Windows.Forms.TextBox rastreamentoTxtBox;
        private System.Windows.Forms.DataGridView encomendasGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destinatario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apartamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bloco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Recebedor_Condominio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Condomino_Recebedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rastreamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Button encomendaSaveButton;
        private System.Windows.Forms.TextBox buscarTxtBox;
        private System.Windows.Forms.Button buscarButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label localizacaoLbl;
        private System.Windows.Forms.TextBox localizacaoTxtBox;
    }
}