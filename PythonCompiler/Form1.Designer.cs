﻿namespace PythonCompiler
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ckbNoConsole = new System.Windows.Forms.CheckBox();
            this.ckbClearCache = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.btnManifest = new System.Windows.Forms.Button();
            this.txtManifest = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLocalSave = new System.Windows.Forms.Button();
            this.txtLocalSave = new System.Windows.Forms.TextBox();
            this.btnOpenLocalCompile = new System.Windows.Forms.Button();
            this.btnCompile = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnPath = new System.Windows.Forms.Button();
            this.openFileCompile = new System.Windows.Forms.OpenFileDialog();
            this.openFolderSave = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileManifest = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnManifest);
            this.panel1.Controls.Add(this.txtManifest);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnLocalSave);
            this.panel1.Controls.Add(this.txtLocalSave);
            this.panel1.Controls.Add(this.btnOpenLocalCompile);
            this.panel1.Controls.Add(this.btnCompile);
            this.panel1.Controls.Add(this.txtPath);
            this.panel1.Controls.Add(this.btnPath);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 371);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ckbNoConsole);
            this.groupBox2.Controls.Add(this.ckbClearCache);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 76);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opções";
            // 
            // ckbNoConsole
            // 
            this.ckbNoConsole.AutoSize = true;
            this.ckbNoConsole.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ckbNoConsole.Location = new System.Drawing.Point(6, 49);
            this.ckbNoConsole.Name = "ckbNoConsole";
            this.ckbNoConsole.Size = new System.Drawing.Size(153, 19);
            this.ckbNoConsole.TabIndex = 8;
            this.ckbNoConsole.Text = "Executavel sem Console";
            this.ckbNoConsole.UseVisualStyleBackColor = true;
            // 
            // ckbClearCache
            // 
            this.ckbClearCache.AutoSize = true;
            this.ckbClearCache.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ckbClearCache.Location = new System.Drawing.Point(6, 24);
            this.ckbClearCache.Name = "ckbClearCache";
            this.ckbClearCache.Size = new System.Drawing.Size(97, 19);
            this.ckbClearCache.TabIndex = 7;
            this.ckbClearCache.Text = "Limpar cache";
            this.ckbClearCache.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(279, 218);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Compilação";
            // 
            // radioButton3
            // 
            this.radioButton3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButton3.AutoSize = true;
            this.radioButton3.ForeColor = System.Drawing.Color.White;
            this.radioButton3.Location = new System.Drawing.Point(6, 73);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(118, 19);
            this.radioButton3.TabIndex = 18;
            this.radioButton3.Text = "Gerar Arquivo ZIP";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(6, 48);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(132, 19);
            this.radioButton2.TabIndex = 17;
            this.radioButton2.Text = "Gerar Arquivo Unico";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(6, 23);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(84, 19);
            this.radioButton1.TabIndex = 16;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Gerar DLL\'s";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(246, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "Adicionar Manifesto (XML / Não Obrigatório)";
            // 
            // btnManifest
            // 
            this.btnManifest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnManifest.Location = new System.Drawing.Point(455, 186);
            this.btnManifest.Name = "btnManifest";
            this.btnManifest.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnManifest.Size = new System.Drawing.Size(24, 23);
            this.btnManifest.TabIndex = 20;
            this.btnManifest.Text = "...";
            this.btnManifest.UseVisualStyleBackColor = true;
            this.btnManifest.Click += new System.EventHandler(this.SearchManifest);
            // 
            // txtManifest
            // 
            this.txtManifest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtManifest.Location = new System.Drawing.Point(12, 186);
            this.txtManifest.Name = "txtManifest";
            this.txtManifest.Size = new System.Drawing.Size(437, 23);
            this.txtManifest.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(293, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Versão (Não Obrigatório)";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(293, 133);
            this.textBox2.Name = "textBox2";
            this.textBox2.PlaceholderText = "1.0.0";
            this.textBox2.Size = new System.Drawing.Size(186, 23);
            this.textBox2.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nome Compilado (Sem Extensão)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 133);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Python Compile";
            this.textBox1.Size = new System.Drawing.Size(186, 23);
            this.textBox1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Onde Salvar";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Arquivo a ser Compilado";
            // 
            // btnLocalSave
            // 
            this.btnLocalSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLocalSave.Location = new System.Drawing.Point(455, 81);
            this.btnLocalSave.Name = "btnLocalSave";
            this.btnLocalSave.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnLocalSave.Size = new System.Drawing.Size(24, 23);
            this.btnLocalSave.TabIndex = 7;
            this.btnLocalSave.Text = "...";
            this.btnLocalSave.UseVisualStyleBackColor = true;
            this.btnLocalSave.Click += new System.EventHandler(this.SearchLocalSave);
            // 
            // txtLocalSave
            // 
            this.txtLocalSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLocalSave.Location = new System.Drawing.Point(12, 81);
            this.txtLocalSave.Name = "txtLocalSave";
            this.txtLocalSave.Size = new System.Drawing.Size(437, 23);
            this.txtLocalSave.TabIndex = 6;
            this.txtLocalSave.Text = "C:\\PythonCompile";
            // 
            // btnOpenLocalCompile
            // 
            this.btnOpenLocalCompile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOpenLocalCompile.Location = new System.Drawing.Point(12, 336);
            this.btnOpenLocalCompile.Name = "btnOpenLocalCompile";
            this.btnOpenLocalCompile.Size = new System.Drawing.Size(171, 23);
            this.btnOpenLocalCompile.TabIndex = 4;
            this.btnOpenLocalCompile.Text = "Abrir Pasta da Compilação";
            this.btnOpenLocalCompile.UseVisualStyleBackColor = true;
            // 
            // btnCompile
            // 
            this.btnCompile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCompile.Location = new System.Drawing.Point(404, 336);
            this.btnCompile.Name = "btnCompile";
            this.btnCompile.Size = new System.Drawing.Size(75, 23);
            this.btnCompile.TabIndex = 2;
            this.btnCompile.Text = "Compilar";
            this.btnCompile.UseVisualStyleBackColor = true;
            // 
            // txtPath
            // 
            this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPath.Location = new System.Drawing.Point(12, 27);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(437, 23);
            this.txtPath.TabIndex = 1;
            this.txtPath.Text = "C:\\PythonCompile\\PythonCompile.py";
            // 
            // btnPath
            // 
            this.btnPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPath.Location = new System.Drawing.Point(455, 27);
            this.btnPath.Name = "btnPath";
            this.btnPath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPath.Size = new System.Drawing.Size(24, 23);
            this.btnPath.TabIndex = 0;
            this.btnPath.Text = "...";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.SearchFile);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 371);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(507, 410);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Python Compile";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btnPath;
        private TextBox txtPath;
        private OpenFileDialog openFileCompile;
        private Button btnOpenLocalCompile;
        private Button btnCompile;
        private Button btnLocalSave;
        private TextBox txtLocalSave;
        private Label label2;
        private Label label1;
        private FolderBrowserDialog openFolderSave;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox2;
        private Label label5;
        private Button btnManifest;
        private TextBox txtManifest;
        private GroupBox groupBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private GroupBox groupBox2;
        private CheckBox ckbNoConsole;
        private CheckBox ckbClearCache;
        private OpenFileDialog openFileManifest;
    }
}