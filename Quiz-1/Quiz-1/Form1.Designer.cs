
namespace Quiz_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnZoom = new System.Windows.Forms.Button();
            this.btnCenter = new System.Windows.Forms.Button();
            this.btnAuto = new System.Windows.Forms.Button();
            this.btnStretch = new System.Windows.Forms.Button();
            this.btnNormal = new System.Windows.Forms.Button();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.btnPicReset = new System.Windows.Forms.Button();
            this.btnUIReset = new System.Windows.Forms.Button();
            this.btnDrawBorder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(329, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "C:\\...";
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(347, 10);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 180);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnZoom);
            this.groupBox1.Controls.Add(this.btnCenter);
            this.groupBox1.Controls.Add(this.btnAuto);
            this.groupBox1.Controls.Add(this.btnStretch);
            this.groupBox1.Controls.Add(this.btnNormal);
            this.groupBox1.Location = new System.Drawing.Point(336, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(86, 180);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Size Mode";
            // 
            // btnZoom
            // 
            this.btnZoom.Location = new System.Drawing.Point(6, 135);
            this.btnZoom.Name = "btnZoom";
            this.btnZoom.Size = new System.Drawing.Size(75, 23);
            this.btnZoom.TabIndex = 4;
            this.btnZoom.Text = "Zoom";
            this.btnZoom.UseVisualStyleBackColor = true;
            this.btnZoom.Click += new System.EventHandler(this.btnZoom_Click);
            // 
            // btnCenter
            // 
            this.btnCenter.Location = new System.Drawing.Point(6, 106);
            this.btnCenter.Name = "btnCenter";
            this.btnCenter.Size = new System.Drawing.Size(75, 23);
            this.btnCenter.TabIndex = 3;
            this.btnCenter.Text = "Center";
            this.btnCenter.UseVisualStyleBackColor = true;
            this.btnCenter.Click += new System.EventHandler(this.btnCenter_Click);
            // 
            // btnAuto
            // 
            this.btnAuto.Location = new System.Drawing.Point(6, 77);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(75, 23);
            this.btnAuto.TabIndex = 2;
            this.btnAuto.Text = "Auto";
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // btnStretch
            // 
            this.btnStretch.Location = new System.Drawing.Point(6, 48);
            this.btnStretch.Name = "btnStretch";
            this.btnStretch.Size = new System.Drawing.Size(75, 23);
            this.btnStretch.TabIndex = 1;
            this.btnStretch.Text = "Stretch";
            this.btnStretch.UseVisualStyleBackColor = true;
            this.btnStretch.Click += new System.EventHandler(this.btnStretch_Click);
            // 
            // btnNormal
            // 
            this.btnNormal.Location = new System.Drawing.Point(6, 19);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(75, 23);
            this.btnNormal.TabIndex = 0;
            this.btnNormal.Text = "Normal";
            this.btnNormal.UseVisualStyleBackColor = true;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // btnResetForm
            // 
            this.btnResetForm.Location = new System.Drawing.Point(134, 276);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(75, 23);
            this.btnResetForm.TabIndex = 5;
            this.btnResetForm.Text = "Reset Form";
            this.btnResetForm.UseVisualStyleBackColor = true;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // btnPicReset
            // 
            this.btnPicReset.Location = new System.Drawing.Point(12, 231);
            this.btnPicReset.Name = "btnPicReset";
            this.btnPicReset.Size = new System.Drawing.Size(75, 23);
            this.btnPicReset.TabIndex = 6;
            this.btnPicReset.Text = "Pic Preset";
            this.btnPicReset.UseVisualStyleBackColor = true;
            this.btnPicReset.Click += new System.EventHandler(this.btnPicReset_Click);
            // 
            // btnUIReset
            // 
            this.btnUIReset.Location = new System.Drawing.Point(134, 231);
            this.btnUIReset.Name = "btnUIReset";
            this.btnUIReset.Size = new System.Drawing.Size(75, 23);
            this.btnUIReset.TabIndex = 7;
            this.btnUIReset.Text = "UI Preset";
            this.btnUIReset.UseVisualStyleBackColor = true;
            this.btnUIReset.Click += new System.EventHandler(this.btnUIReset_Click);
            // 
            // btnDrawBorder
            // 
            this.btnDrawBorder.Location = new System.Drawing.Point(257, 231);
            this.btnDrawBorder.Name = "btnDrawBorder";
            this.btnDrawBorder.Size = new System.Drawing.Size(75, 23);
            this.btnDrawBorder.TabIndex = 8;
            this.btnDrawBorder.Text = "Draw Border";
            this.btnDrawBorder.UseVisualStyleBackColor = true;
            this.btnDrawBorder.Click += new System.EventHandler(this.btnDrawBorder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 361);
            this.Controls.Add(this.btnDrawBorder);
            this.Controls.Add(this.btnUIReset);
            this.Controls.Add(this.btnPicReset);
            this.Controls.Add(this.btnResetForm);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Picture Viewer - 20170301006 - Tuğra GÜNDÜZ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnZoom;
        private System.Windows.Forms.Button btnCenter;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.Button btnStretch;
        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.Button btnPicReset;
        private System.Windows.Forms.Button btnUIReset;
        private System.Windows.Forms.Button btnDrawBorder;
    }
}

