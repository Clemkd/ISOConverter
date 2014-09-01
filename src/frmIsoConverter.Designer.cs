namespace ISOConverter
{
    partial class frmIsoConverter
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIsoConverter));
            this.btn_Convert = new System.Windows.Forms.Button();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txt_Path = new System.Windows.Forms.TextBox();
            this.btn_Path = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.lbl_Inf = new System.Windows.Forms.Label();
            this.grp_Params = new System.Windows.Forms.GroupBox();
            this.grp_Dimensions = new System.Windows.Forms.GroupBox();
            this.lbl_InfDimensions = new System.Windows.Forms.Label();
            this.lbl_Width = new System.Windows.Forms.Label();
            this.txt_Height = new System.Windows.Forms.TextBox();
            this.lbl_Height = new System.Windows.Forms.Label();
            this.txt_Width = new System.Windows.Forms.TextBox();
            this.grp_Convert = new System.Windows.Forms.GroupBox();
            this.grp_Params.SuspendLayout();
            this.grp_Dimensions.SuspendLayout();
            this.grp_Convert.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Convert
            // 
            this.btn_Convert.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_Convert.Location = new System.Drawing.Point(115, 178);
            this.btn_Convert.Name = "btn_Convert";
            this.btn_Convert.Size = new System.Drawing.Size(131, 30);
            this.btn_Convert.TabIndex = 0;
            this.btn_Convert.Text = "Convertir";
            this.btn_Convert.UseVisualStyleBackColor = false;
            this.btn_Convert.Click += new System.EventHandler(this.btn_Convert_Click);
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(12, 35);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(337, 32);
            this.progress.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 73);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(336, 82);
            this.listBox1.TabIndex = 2;
            // 
            // txt_Path
            // 
            this.txt_Path.Location = new System.Drawing.Point(8, 41);
            this.txt_Path.Name = "txt_Path";
            this.txt_Path.Size = new System.Drawing.Size(333, 20);
            this.txt_Path.TabIndex = 3;
            // 
            // btn_Path
            // 
            this.btn_Path.Location = new System.Drawing.Point(347, 39);
            this.btn_Path.Name = "btn_Path";
            this.btn_Path.Size = new System.Drawing.Size(30, 23);
            this.btn_Path.TabIndex = 4;
            this.btn_Path.Text = "...";
            this.btn_Path.UseVisualStyleBackColor = true;
            this.btn_Path.Click += new System.EventHandler(this.btn_Path_Click);
            // 
            // openFile
            // 
            this.openFile.FileName = "tileset";
            // 
            // lbl_Inf
            // 
            this.lbl_Inf.AutoSize = true;
            this.lbl_Inf.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Inf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_Inf.Location = new System.Drawing.Point(5, 64);
            this.lbl_Inf.Name = "lbl_Inf";
            this.lbl_Inf.Size = new System.Drawing.Size(264, 24);
            this.lbl_Inf.TabIndex = 5;
            this.lbl_Inf.Text = "Merci de bien vouloir renseigner le chemin du fichier à convertir.\r\n(Formats poss" +
    "ibles : BMP, GIF, EXIF, JPG, PNG, TIFF)\r\n";
            // 
            // grp_Params
            // 
            this.grp_Params.Controls.Add(this.grp_Dimensions);
            this.grp_Params.Controls.Add(this.txt_Path);
            this.grp_Params.Controls.Add(this.lbl_Inf);
            this.grp_Params.Controls.Add(this.btn_Path);
            this.grp_Params.Location = new System.Drawing.Point(12, 12);
            this.grp_Params.Name = "grp_Params";
            this.grp_Params.Size = new System.Drawing.Size(383, 217);
            this.grp_Params.TabIndex = 6;
            this.grp_Params.TabStop = false;
            this.grp_Params.Text = "Étape 1 : Paramètres";
            // 
            // grp_Dimensions
            // 
            this.grp_Dimensions.Controls.Add(this.lbl_InfDimensions);
            this.grp_Dimensions.Controls.Add(this.lbl_Width);
            this.grp_Dimensions.Controls.Add(this.txt_Height);
            this.grp_Dimensions.Controls.Add(this.lbl_Height);
            this.grp_Dimensions.Controls.Add(this.txt_Width);
            this.grp_Dimensions.Location = new System.Drawing.Point(6, 111);
            this.grp_Dimensions.Name = "grp_Dimensions";
            this.grp_Dimensions.Size = new System.Drawing.Size(371, 100);
            this.grp_Dimensions.TabIndex = 11;
            this.grp_Dimensions.TabStop = false;
            this.grp_Dimensions.Text = "Facultatif";
            // 
            // lbl_InfDimensions
            // 
            this.lbl_InfDimensions.AutoSize = true;
            this.lbl_InfDimensions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InfDimensions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_InfDimensions.Location = new System.Drawing.Point(23, 29);
            this.lbl_InfDimensions.Name = "lbl_InfDimensions";
            this.lbl_InfDimensions.Size = new System.Drawing.Size(329, 13);
            this.lbl_InfDimensions.TabIndex = 10;
            this.lbl_InfDimensions.Text = "Définissez les dimensions d\'un tile sur un tileset uniforme";
            // 
            // lbl_Width
            // 
            this.lbl_Width.AutoSize = true;
            this.lbl_Width.Location = new System.Drawing.Point(27, 58);
            this.lbl_Width.Name = "lbl_Width";
            this.lbl_Width.Size = new System.Drawing.Size(49, 13);
            this.lbl_Width.TabIndex = 6;
            this.lbl_Width.Text = "Largeur :";
            // 
            // txt_Height
            // 
            this.txt_Height.Location = new System.Drawing.Point(257, 55);
            this.txt_Height.Name = "txt_Height";
            this.txt_Height.Size = new System.Drawing.Size(87, 20);
            this.txt_Height.TabIndex = 9;
            this.txt_Height.Text = "32";
            this.txt_Height.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Height
            // 
            this.lbl_Height.AutoSize = true;
            this.lbl_Height.Location = new System.Drawing.Point(200, 58);
            this.lbl_Height.Name = "lbl_Height";
            this.lbl_Height.Size = new System.Drawing.Size(51, 13);
            this.lbl_Height.TabIndex = 7;
            this.lbl_Height.Text = "Hauteur :";
            // 
            // txt_Width
            // 
            this.txt_Width.Location = new System.Drawing.Point(82, 55);
            this.txt_Width.Name = "txt_Width";
            this.txt_Width.Size = new System.Drawing.Size(87, 20);
            this.txt_Width.TabIndex = 8;
            this.txt_Width.Text = "32";
            this.txt_Width.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grp_Convert
            // 
            this.grp_Convert.Controls.Add(this.listBox1);
            this.grp_Convert.Controls.Add(this.btn_Convert);
            this.grp_Convert.Controls.Add(this.progress);
            this.grp_Convert.Location = new System.Drawing.Point(406, 12);
            this.grp_Convert.Name = "grp_Convert";
            this.grp_Convert.Size = new System.Drawing.Size(360, 217);
            this.grp_Convert.TabIndex = 7;
            this.grp_Convert.TabStop = false;
            this.grp_Convert.Text = "Étape 2 : Conversion";
            // 
            // frmIsoConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 242);
            this.Controls.Add(this.grp_Convert);
            this.Controls.Add(this.grp_Params);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmIsoConverter";
            this.Text = "ISO Converter";
            this.grp_Params.ResumeLayout(false);
            this.grp_Params.PerformLayout();
            this.grp_Dimensions.ResumeLayout(false);
            this.grp_Dimensions.PerformLayout();
            this.grp_Convert.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Convert;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txt_Path;
        private System.Windows.Forms.Button btn_Path;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Label lbl_Inf;
        private System.Windows.Forms.GroupBox grp_Params;
        private System.Windows.Forms.GroupBox grp_Dimensions;
        private System.Windows.Forms.Label lbl_InfDimensions;
        private System.Windows.Forms.Label lbl_Width;
        private System.Windows.Forms.TextBox txt_Height;
        private System.Windows.Forms.Label lbl_Height;
        private System.Windows.Forms.TextBox txt_Width;
        private System.Windows.Forms.GroupBox grp_Convert;
    }
}

