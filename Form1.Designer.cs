namespace library_management_materialskin
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.btnEkle = new MaterialSkin.Controls.MaterialButton();
            this.materialTextBox2 = new MaterialSkin.Controls.MaterialTextBox();
            this.btnSil = new MaterialSkin.Controls.MaterialButton();
            this.btnGuncelle = new MaterialSkin.Controls.MaterialButton();
            this.btnArama = new MaterialSkin.Controls.MaterialButton();
            this.materialTextBox3 = new MaterialSkin.Controls.MaterialTextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.materialFloatingActionButton1 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.materialFloatingActionButton2 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.materialFloatingActionButton3 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.materialTabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Controls.Add(this.tabPage5);
            this.materialTabControl1.Controls.Add(this.tabPage6);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.ımageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(894, 533);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.ImageKey = "icons8-home-48.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(886, 490);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dashboard";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.materialFloatingActionButton3);
            this.tabPage2.Controls.Add(this.materialFloatingActionButton2);
            this.tabPage2.Controls.Add(this.materialFloatingActionButton1);
            this.tabPage2.Controls.Add(this.materialTextBox3);
            this.tabPage2.Controls.Add(this.btnArama);
            this.tabPage2.Controls.Add(this.btnGuncelle);
            this.tabPage2.Controls.Add(this.btnSil);
            this.tabPage2.Controls.Add(this.materialTextBox2);
            this.tabPage2.Controls.Add(this.btnEkle);
            this.tabPage2.Controls.Add(this.materialTextBox1);
            this.tabPage2.ImageKey = "icons8-bookmark-48.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(886, 490);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kitaplar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "icons8-home-48.png");
            this.ımageList1.Images.SetKeyName(1, "icons8-search-48.png");
            this.ımageList1.Images.SetKeyName(2, "icons8-bookmark-48.png");
            this.ımageList1.Images.SetKeyName(3, "icons8-settings-48.png");
            this.ımageList1.Images.SetKeyName(4, "icons8-users-64.png");
            this.ımageList1.Images.SetKeyName(5, "icons8-update-50.png");
            this.ımageList1.Images.SetKeyName(6, "icons8-loan-64.png");
            this.ımageList1.Images.SetKeyName(7, "icons8-cancel-64.png");
            this.ımageList1.Images.SetKeyName(8, "icons8-add-64.png");
            this.ımageList1.Images.SetKeyName(9, "icons8-reports-64.png");
            // 
            // tabPage3
            // 
            this.tabPage3.ImageKey = "icons8-users-64.png";
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(886, 490);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Kullanıcılar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.AnimateReadOnly = false;
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox1.Hint = "Kitap adı ekle";
            this.materialTextBox1.LeadingIcon = null;
            this.materialTextBox1.Location = new System.Drawing.Point(110, 106);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(300, 50);
            this.materialTextBox1.TabIndex = 1;
            this.materialTextBox1.Text = "";
            this.materialTextBox1.TrailingIcon = null;
            // 
            // btnEkle
            // 
            this.btnEkle.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.btnEkle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEkle.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEkle.Depth = 0;
            this.btnEkle.HighEmphasis = true;
            this.btnEkle.Icon = null;
            this.btnEkle.ImageKey = "icons8-add-64.png";
            this.btnEkle.ImageList = this.ımageList1;
            this.btnEkle.Location = new System.Drawing.Point(558, 185);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEkle.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEkle.Size = new System.Drawing.Size(64, 36);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEkle.UseAccentColor = false;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // materialTextBox2
            // 
            this.materialTextBox2.AnimateReadOnly = false;
            this.materialTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox2.Depth = 0;
            this.materialTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox2.Hint = "Yazar ekle";
            this.materialTextBox2.LeadingIcon = null;
            this.materialTextBox2.Location = new System.Drawing.Point(110, 201);
            this.materialTextBox2.MaxLength = 50;
            this.materialTextBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox2.Multiline = false;
            this.materialTextBox2.Name = "materialTextBox2";
            this.materialTextBox2.Size = new System.Drawing.Size(300, 50);
            this.materialTextBox2.TabIndex = 3;
            this.materialTextBox2.Text = "";
            this.materialTextBox2.TrailingIcon = null;
            // 
            // btnSil
            // 
            this.btnSil.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.btnSil.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSil.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSil.Depth = 0;
            this.btnSil.HighEmphasis = true;
            this.btnSil.Icon = null;
            this.btnSil.Location = new System.Drawing.Point(558, 274);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSil.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSil.Name = "btnSil";
            this.btnSil.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSil.Size = new System.Drawing.Size(64, 36);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSil.UseAccentColor = false;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.btnGuncelle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuncelle.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGuncelle.Depth = 0;
            this.btnGuncelle.HighEmphasis = true;
            this.btnGuncelle.Icon = null;
            this.btnGuncelle.Location = new System.Drawing.Point(695, 185);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGuncelle.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGuncelle.Size = new System.Drawing.Size(94, 36);
            this.btnGuncelle.TabIndex = 6;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGuncelle.UseAccentColor = false;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnArama
            // 
            this.btnArama.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.btnArama.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnArama.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnArama.Depth = 0;
            this.btnArama.HighEmphasis = true;
            this.btnArama.Icon = null;
            this.btnArama.Location = new System.Drawing.Point(695, 274);
            this.btnArama.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnArama.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnArama.Name = "btnArama";
            this.btnArama.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnArama.Size = new System.Drawing.Size(72, 36);
            this.btnArama.TabIndex = 7;
            this.btnArama.Text = "Arama";
            this.btnArama.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnArama.UseAccentColor = false;
            this.btnArama.UseVisualStyleBackColor = true;
            this.btnArama.Click += new System.EventHandler(this.btnArama_Click);
            // 
            // materialTextBox3
            // 
            this.materialTextBox3.AnimateReadOnly = false;
            this.materialTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox3.Depth = 0;
            this.materialTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox3.Hint = "Yayın evi ekle";
            this.materialTextBox3.LeadingIcon = null;
            this.materialTextBox3.Location = new System.Drawing.Point(110, 305);
            this.materialTextBox3.MaxLength = 50;
            this.materialTextBox3.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox3.Multiline = false;
            this.materialTextBox3.Name = "materialTextBox3";
            this.materialTextBox3.Size = new System.Drawing.Size(300, 50);
            this.materialTextBox3.TabIndex = 8;
            this.materialTextBox3.Text = "";
            this.materialTextBox3.TrailingIcon = null;
            // 
            // tabPage4
            // 
            this.tabPage4.ImageKey = "icons8-loan-64.png";
            this.tabPage4.Location = new System.Drawing.Point(4, 39);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(886, 490);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Ödünçler";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.ImageKey = "icons8-reports-64.png";
            this.tabPage5.Location = new System.Drawing.Point(4, 39);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(886, 490);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Raporlama";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.ImageKey = "icons8-settings-48.png";
            this.tabPage6.Location = new System.Drawing.Point(4, 39);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(886, 490);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Ayarlar";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // materialFloatingActionButton1
            // 
            this.materialFloatingActionButton1.Depth = 0;
            this.materialFloatingActionButton1.Icon = ((System.Drawing.Image)(resources.GetObject("materialFloatingActionButton1.Icon")));
            this.materialFloatingActionButton1.Image = ((System.Drawing.Image)(resources.GetObject("materialFloatingActionButton1.Image")));
            this.materialFloatingActionButton1.Location = new System.Drawing.Point(416, 100);
            this.materialFloatingActionButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFloatingActionButton1.Name = "materialFloatingActionButton1";
            this.materialFloatingActionButton1.Size = new System.Drawing.Size(56, 56);
            this.materialFloatingActionButton1.TabIndex = 9;
            this.materialFloatingActionButton1.Text = "materialFloatingActionButton1";
            this.materialFloatingActionButton1.UseVisualStyleBackColor = false;
            // 
            // materialFloatingActionButton2
            // 
            this.materialFloatingActionButton2.Depth = 0;
            this.materialFloatingActionButton2.Icon = ((System.Drawing.Image)(resources.GetObject("materialFloatingActionButton2.Icon")));
            this.materialFloatingActionButton2.Image = ((System.Drawing.Image)(resources.GetObject("materialFloatingActionButton2.Image")));
            this.materialFloatingActionButton2.Location = new System.Drawing.Point(416, 195);
            this.materialFloatingActionButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFloatingActionButton2.Name = "materialFloatingActionButton2";
            this.materialFloatingActionButton2.Size = new System.Drawing.Size(56, 56);
            this.materialFloatingActionButton2.TabIndex = 10;
            this.materialFloatingActionButton2.Text = "materialFloatingActionButton2";
            this.materialFloatingActionButton2.UseVisualStyleBackColor = false;
            // 
            // materialFloatingActionButton3
            // 
            this.materialFloatingActionButton3.Depth = 0;
            this.materialFloatingActionButton3.Icon = ((System.Drawing.Image)(resources.GetObject("materialFloatingActionButton3.Icon")));
            this.materialFloatingActionButton3.Image = ((System.Drawing.Image)(resources.GetObject("materialFloatingActionButton3.Image")));
            this.materialFloatingActionButton3.Location = new System.Drawing.Point(416, 299);
            this.materialFloatingActionButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFloatingActionButton3.Name = "materialFloatingActionButton3";
            this.materialFloatingActionButton3.Size = new System.Drawing.Size(56, 56);
            this.materialFloatingActionButton3.TabIndex = 11;
            this.materialFloatingActionButton3.Text = "materialFloatingActionButton3";
            this.materialFloatingActionButton3.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerIsOpen = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "Form1";
            this.Sizable = false;
            this.Text = "Material Dash";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ImageList ımageList1;
        private MaterialSkin.Controls.MaterialButton btnSil;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox2;
        private MaterialSkin.Controls.MaterialButton btnEkle;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialButton btnArama;
        private MaterialSkin.Controls.MaterialButton btnGuncelle;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton1;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton3;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton2;
    }
}

