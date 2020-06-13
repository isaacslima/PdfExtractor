namespace PdfExtractor
{
    partial class PdfExtractor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PdfExtractor));
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelecionarArquivo = new System.Windows.Forms.Button();
            this.lblArquivoSelecionado = new System.Windows.Forms.Label();
            this.pbLanguageSelected = new System.Windows.Forms.PictureBox();
            this.pnlMultilanguage = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblPortuguese = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLanguageSelected)).BeginInit();
            this.pnlMultilanguage.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seja bem vindo.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(510, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Clique no botão abaixo e selecione o arquivo para começar a converter.";
            // 
            // btnSelecionarArquivo
            // 
            this.btnSelecionarArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionarArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionarArquivo.Location = new System.Drawing.Point(15, 52);
            this.btnSelecionarArquivo.Name = "btnSelecionarArquivo";
            this.btnSelecionarArquivo.Size = new System.Drawing.Size(226, 31);
            this.btnSelecionarArquivo.TabIndex = 3;
            this.btnSelecionarArquivo.Text = "SELECIONAR ARQUIVO";
            this.btnSelecionarArquivo.UseVisualStyleBackColor = true;
            this.btnSelecionarArquivo.Click += new System.EventHandler(this.btnSelecionarArquivo_Click);
            // 
            // lblArquivoSelecionado
            // 
            this.lblArquivoSelecionado.AutoSize = true;
            this.lblArquivoSelecionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArquivoSelecionado.Location = new System.Drawing.Point(12, 86);
            this.lblArquivoSelecionado.Name = "lblArquivoSelecionado";
            this.lblArquivoSelecionado.Size = new System.Drawing.Size(211, 20);
            this.lblArquivoSelecionado.TabIndex = 4;
            this.lblArquivoSelecionado.Text = "nenhum arquivo selecionado";
            // 
            // pbLanguageSelected
            // 
            this.pbLanguageSelected.BackColor = System.Drawing.SystemColors.MenuBar;
            this.pbLanguageSelected.Image = global::PdfExtractor.Properties.Resources.portuguese;
            this.pbLanguageSelected.Location = new System.Drawing.Point(549, 10);
            this.pbLanguageSelected.Name = "pbLanguageSelected";
            this.pbLanguageSelected.Padding = new System.Windows.Forms.Padding(5);
            this.pbLanguageSelected.Size = new System.Drawing.Size(37, 34);
            this.pbLanguageSelected.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLanguageSelected.TabIndex = 5;
            this.pbLanguageSelected.TabStop = false;
            // 
            // pnlMultilanguage
            // 
            this.pnlMultilanguage.BackColor = System.Drawing.SystemColors.MenuBar;
            this.pnlMultilanguage.Controls.Add(this.panel3);
            this.pnlMultilanguage.Controls.Add(this.panel2);
            this.pnlMultilanguage.Location = new System.Drawing.Point(386, 44);
            this.pnlMultilanguage.Name = "pnlMultilanguage";
            this.pnlMultilanguage.Size = new System.Drawing.Size(200, 81);
            this.pnlMultilanguage.TabIndex = 6;
            this.pnlMultilanguage.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblPortuguese);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 39);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Location = new System.Drawing.Point(0, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 39);
            this.panel3.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PdfExtractor.Properties.Resources.portuguese;
            this.pictureBox2.Location = new System.Drawing.Point(2, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Padding = new System.Windows.Forms.Padding(5);
            this.pictureBox2.Size = new System.Drawing.Size(37, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PdfExtractor.Properties.Resources.english;
            this.pictureBox3.Location = new System.Drawing.Point(2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Padding = new System.Windows.Forms.Padding(5);
            this.pictureBox3.Size = new System.Drawing.Size(37, 34);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // lblPortuguese
            // 
            this.lblPortuguese.AutoSize = true;
            this.lblPortuguese.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPortuguese.Location = new System.Drawing.Point(45, 10);
            this.lblPortuguese.Name = "lblPortuguese";
            this.lblPortuguese.Size = new System.Drawing.Size(122, 20);
            this.lblPortuguese.TabIndex = 1;
            this.lblPortuguese.Text = "PORTUGUESE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "ENGLISH";
            // 
            // PdfExtractor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(593, 188);
            this.Controls.Add(this.pnlMultilanguage);
            this.Controls.Add(this.pbLanguageSelected);
            this.Controls.Add(this.lblArquivoSelecionado);
            this.Controls.Add(this.btnSelecionarArquivo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PdfExtractor";
            this.Text = "PdfExtractor";
            ((System.ComponentModel.ISupportInitialize)(this.pbLanguageSelected)).EndInit();
            this.pnlMultilanguage.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSelecionarArquivo;
        private System.Windows.Forms.Label lblArquivoSelecionado;
        private System.Windows.Forms.PictureBox pbLanguageSelected;
        private System.Windows.Forms.Panel pnlMultilanguage;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPortuguese;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

