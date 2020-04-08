namespace QuestõesSimulaVest
{
    partial class dsd
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dsd));
            this.button1 = new System.Windows.Forms.Button();
            this.txtquest = new System.Windows.Forms.TextBox();
            this.cbovest = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txta = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.txtc = new System.Windows.Forms.TextBox();
            this.txtd = new System.Windows.Forms.TextBox();
            this.txte = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cbomat = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.cbocorreto = new System.Windows.Forms.ComboBox();
            this.cboassunto = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtimg = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(163, 960);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "Inserir a questão";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtquest
            // 
            this.txtquest.Location = new System.Drawing.Point(386, 195);
            this.txtquest.Margin = new System.Windows.Forms.Padding(4);
            this.txtquest.Multiline = true;
            this.txtquest.Name = "txtquest";
            this.txtquest.Size = new System.Drawing.Size(550, 192);
            this.txtquest.TabIndex = 1;
            // 
            // cbovest
            // 
            this.cbovest.FormattingEnabled = true;
            this.cbovest.Items.AddRange(new object[] {
            "Fuvest",
            "Unicamp",
            "UNESP",
            "ENEM"});
            this.cbovest.Location = new System.Drawing.Point(604, 70);
            this.cbovest.Margin = new System.Windows.Forms.Padding(4);
            this.cbovest.Name = "cbovest";
            this.cbovest.Size = new System.Drawing.Size(134, 27);
            this.cbovest.TabIndex = 2;
            this.cbovest.SelectedIndexChanged += new System.EventHandler(this.Cbovest_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 31);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(577, 158);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(566, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Digite o enunciado da questão:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(578, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "INSERÇÃO DAS QUESTÕES";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(590, 45);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Selecione o vestibular:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(394, 445);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Alternativa A:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(394, 485);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Alternativa B:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(395, 521);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "Alternativa C:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(394, 560);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 19);
            this.label8.TabIndex = 9;
            this.label8.Text = "Alternativa D:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(395, 600);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 19);
            this.label9.TabIndex = 9;
            this.label9.Text = "Alternativa E:";
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(515, 442);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(389, 27);
            this.txta.TabIndex = 10;
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(515, 482);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(389, 27);
            this.txtb.TabIndex = 11;
            // 
            // txtc
            // 
            this.txtc.Location = new System.Drawing.Point(515, 521);
            this.txtc.Name = "txtc";
            this.txtc.Size = new System.Drawing.Size(389, 27);
            this.txtc.TabIndex = 12;
            // 
            // txtd
            // 
            this.txtd.Location = new System.Drawing.Point(515, 560);
            this.txtd.Name = "txtd";
            this.txtd.Size = new System.Drawing.Size(389, 27);
            this.txtd.TabIndex = 13;
            // 
            // txte
            // 
            this.txte.Location = new System.Drawing.Point(515, 597);
            this.txte.Name = "txte";
            this.txte.Size = new System.Drawing.Size(389, 27);
            this.txte.TabIndex = 14;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(854, 960);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 47);
            this.button3.TabIndex = 15;
            this.button3.Text = "Limpar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(637, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 19);
            this.label10.TabIndex = 16;
            this.label10.Text = "Matéria:";
            this.label10.Click += new System.EventHandler(this.Label10_Click);
            // 
            // cbomat
            // 
            this.cbomat.FormattingEnabled = true;
            this.cbomat.Items.AddRange(new object[] {
            "Matemática",
            "Biologia",
            "História",
            "Literatura",
            "Física",
            "Química",
            "Gramática",
            "Filosofia",
            "Sociologia",
            "Geografia",
            "Inglês"});
            this.cbomat.Location = new System.Drawing.Point(604, 123);
            this.cbomat.Name = "cbomat";
            this.cbomat.Size = new System.Drawing.Size(134, 27);
            this.cbomat.TabIndex = 17;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1028, 960);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(168, 47);
            this.button4.TabIndex = 18;
            this.button4.Text = "Sair";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(339, 960);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(172, 47);
            this.button5.TabIndex = 19;
            this.button5.Text = "Selecionar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(578, 887);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(180, 27);
            this.txtid.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(528, 865);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(308, 19);
            this.label11.TabIndex = 21;
            this.label11.Text = "ID (Para selecionar , deletar ou atualizar):";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(517, 960);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(164, 47);
            this.button6.TabIndex = 22;
            this.button6.Text = "Atualizar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(684, 960);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(164, 47);
            this.button7.TabIndex = 23;
            this.button7.Text = "Deletar";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(395, 642);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 19);
            this.label12.TabIndex = 25;
            this.label12.Text = "Correta:";
            // 
            // cbocorreto
            // 
            this.cbocorreto.FormattingEnabled = true;
            this.cbocorreto.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.cbocorreto.Location = new System.Drawing.Point(515, 639);
            this.cbocorreto.Name = "cbocorreto";
            this.cbocorreto.Size = new System.Drawing.Size(134, 27);
            this.cbocorreto.TabIndex = 26;
            // 
            // cboassunto
            // 
            this.cboassunto.FormattingEnabled = true;
            this.cboassunto.Items.AddRange(new object[] {
            "Sistema respiratório",
            "Revolução francesa",
            "Genética"});
            this.cboassunto.Location = new System.Drawing.Point(515, 409);
            this.cboassunto.Name = "cboassunto";
            this.cboassunto.Size = new System.Drawing.Size(134, 27);
            this.cboassunto.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(395, 412);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 19);
            this.label13.TabIndex = 28;
            this.label13.Text = "Assunto:";
            // 
            // txtimg
            // 
            this.txtimg.Location = new System.Drawing.Point(592, 686);
            this.txtimg.Name = "txtimg";
            this.txtimg.Size = new System.Drawing.Size(312, 27);
            this.txtimg.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(395, 689);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(191, 19);
            this.label14.TabIndex = 29;
            this.label14.Text = "URL da imagem (se tiver):";
            // 
            // dsd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1337, 1028);
            this.Controls.Add(this.txtimg);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cboassunto);
            this.Controls.Add(this.cbocorreto);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.cbomat);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txte);
            this.Controls.Add(this.txtd);
            this.Controls.Add(this.txtc);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbovest);
            this.Controls.Add(this.txtquest);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "dsd";
            this.Text = "Questões SimulaVest";
            this.Load += new System.EventHandler(this.Dsd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtquest;
        private System.Windows.Forms.ComboBox cbovest;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.TextBox txtc;
        private System.Windows.Forms.TextBox txtd;
        private System.Windows.Forms.TextBox txte;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbomat;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbocorreto;
        private System.Windows.Forms.ComboBox cboassunto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtimg;
        private System.Windows.Forms.Label label14;
    }
}

