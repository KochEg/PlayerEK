namespace PlayerEK
{
    partial class PlayerEKmini
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerEKmini));
            this.panelVisualVoice = new CodeeloUI.Controls.CodeeloGradientPanel();
            this.checkBoxMuteVolume2 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelVolumeProcent2 = new System.Windows.Forms.Label();
            this.sliderVolume2 = new MB.Controls.ColorSlider();
            this.buttonExit2 = new System.Windows.Forms.Button();
            this.buttonOpenForm = new System.Windows.Forms.Button();
            this.buttonStop2 = new System.Windows.Forms.Button();
            this.buttonPause2 = new System.Windows.Forms.Button();
            this.buttonNextTrek2 = new System.Windows.Forms.Button();
            this.buttonPlay2 = new System.Windows.Forms.Button();
            this.buttonPreviousTrek2 = new System.Windows.Forms.Button();
            this.panelVisualVoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelVisualVoice
            // 
            this.panelVisualVoice.AccessibleRole = null;
            this.panelVisualVoice.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelVisualVoice.CausesValidation = false;
            this.panelVisualVoice.ColorFillFirst = System.Drawing.Color.Aqua;
            this.panelVisualVoice.ColorFillSecond = System.Drawing.Color.Lime;
            this.panelVisualVoice.Controls.Add(this.checkBoxMuteVolume2);
            this.panelVisualVoice.Controls.Add(this.textBox1);
            this.panelVisualVoice.Controls.Add(this.pictureBox2);
            this.panelVisualVoice.Controls.Add(this.labelVolumeProcent2);
            this.panelVisualVoice.Controls.Add(this.sliderVolume2);
            this.panelVisualVoice.Controls.Add(this.buttonExit2);
            this.panelVisualVoice.Controls.Add(this.buttonOpenForm);
            this.panelVisualVoice.Controls.Add(this.buttonStop2);
            this.panelVisualVoice.Controls.Add(this.buttonPause2);
            this.panelVisualVoice.Controls.Add(this.buttonNextTrek2);
            this.panelVisualVoice.Controls.Add(this.buttonPlay2);
            this.panelVisualVoice.Controls.Add(this.buttonPreviousTrek2);
            this.panelVisualVoice.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.panelVisualVoice.Location = new System.Drawing.Point(0, 0);
            this.panelVisualVoice.Name = "panelVisualVoice";
            this.panelVisualVoice.Size = new System.Drawing.Size(450, 91);
            this.panelVisualVoice.TabIndex = 0;
            // 
            // checkBoxMuteVolume2
            // 
            this.checkBoxMuteVolume2.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxMuteVolume2.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxMuteVolume2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkBoxMuteVolume2.FlatAppearance.BorderSize = 0;
            this.checkBoxMuteVolume2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.checkBoxMuteVolume2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.checkBoxMuteVolume2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxMuteVolume2.Image = global::PlayerEK.Properties.Resources.mute1;
            this.checkBoxMuteVolume2.Location = new System.Drawing.Point(298, 21);
            this.checkBoxMuteVolume2.Name = "checkBoxMuteVolume2";
            this.checkBoxMuteVolume2.Size = new System.Drawing.Size(32, 32);
            this.checkBoxMuteVolume2.TabIndex = 21;
            this.checkBoxMuteVolume2.UseVisualStyleBackColor = false;
            this.checkBoxMuteVolume2.CheckedChanged += new System.EventHandler(this.checkBoxMuteVolume2_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Aqua;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(269, 15);
            this.textBox1.TabIndex = 20;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::PlayerEK.Properties.Resources.volume;
            this.pictureBox2.Location = new System.Drawing.Point(385, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // labelVolumeProcent2
            // 
            this.labelVolumeProcent2.AutoSize = true;
            this.labelVolumeProcent2.BackColor = System.Drawing.Color.Transparent;
            this.labelVolumeProcent2.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVolumeProcent2.Location = new System.Drawing.Point(406, 31);
            this.labelVolumeProcent2.Name = "labelVolumeProcent2";
            this.labelVolumeProcent2.Size = new System.Drawing.Size(32, 22);
            this.labelVolumeProcent2.TabIndex = 17;
            this.labelVolumeProcent2.Text = "30";
            // 
            // sliderVolume2
            // 
            this.sliderVolume2.BackColor = System.Drawing.Color.Transparent;
            this.sliderVolume2.BarInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sliderVolume2.BarOuterColor = System.Drawing.Color.Aqua;
            this.sliderVolume2.BarPenColor = System.Drawing.Color.Black;
            this.sliderVolume2.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.sliderVolume2.ElapsedInnerColor = System.Drawing.Color.Lime;
            this.sliderVolume2.ElapsedOuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.sliderVolume2.LargeChange = ((uint)(5u));
            this.sliderVolume2.Location = new System.Drawing.Point(298, 57);
            this.sliderVolume2.Name = "sliderVolume2";
            this.sliderVolume2.Size = new System.Drawing.Size(140, 30);
            this.sliderVolume2.SmallChange = ((uint)(1u));
            this.sliderVolume2.TabIndex = 12;
            this.sliderVolume2.Text = "colorSlider1";
            this.sliderVolume2.ThumbInnerColor = System.Drawing.Color.Aqua;
            this.sliderVolume2.ThumbRoundRectSize = new System.Drawing.Size(8, 8);
            this.sliderVolume2.Value = 30;
            this.sliderVolume2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sliderVolume2_Scroll);
            // 
            // buttonExit2
            // 
            this.buttonExit2.BackColor = System.Drawing.Color.Transparent;
            this.buttonExit2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonExit2.FlatAppearance.BorderSize = 0;
            this.buttonExit2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit2.Image = global::PlayerEK.Properties.Resources.exit;
            this.buttonExit2.Location = new System.Drawing.Point(425, 0);
            this.buttonExit2.Name = "buttonExit2";
            this.buttonExit2.Size = new System.Drawing.Size(25, 25);
            this.buttonExit2.TabIndex = 6;
            this.buttonExit2.UseVisualStyleBackColor = false;
            this.buttonExit2.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonOpenForm
            // 
            this.buttonOpenForm.BackColor = System.Drawing.Color.Transparent;
            this.buttonOpenForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonOpenForm.FlatAppearance.BorderSize = 0;
            this.buttonOpenForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenForm.Image = global::PlayerEK.Properties.Resources.expand;
            this.buttonOpenForm.Location = new System.Drawing.Point(394, 0);
            this.buttonOpenForm.Name = "buttonOpenForm";
            this.buttonOpenForm.Size = new System.Drawing.Size(25, 25);
            this.buttonOpenForm.TabIndex = 5;
            this.buttonOpenForm.UseVisualStyleBackColor = false;
            this.buttonOpenForm.Click += new System.EventHandler(this.buttonOpenForm_Click);
            // 
            // buttonStop2
            // 
            this.buttonStop2.BackColor = System.Drawing.Color.Transparent;
            this.buttonStop2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonStop2.FlatAppearance.BorderSize = 0;
            this.buttonStop2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonStop2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.buttonStop2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStop2.Image = global::PlayerEK.Properties.Resources.stop;
            this.buttonStop2.Location = new System.Drawing.Point(232, 38);
            this.buttonStop2.Name = "buttonStop2";
            this.buttonStop2.Size = new System.Drawing.Size(49, 49);
            this.buttonStop2.TabIndex = 4;
            this.buttonStop2.UseVisualStyleBackColor = false;
            this.buttonStop2.Click += new System.EventHandler(this.buttonStop2_Click);
            // 
            // buttonPause2
            // 
            this.buttonPause2.BackColor = System.Drawing.Color.Transparent;
            this.buttonPause2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPause2.FlatAppearance.BorderSize = 0;
            this.buttonPause2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonPause2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.buttonPause2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPause2.Image = global::PlayerEK.Properties.Resources.pause;
            this.buttonPause2.Location = new System.Drawing.Point(177, 38);
            this.buttonPause2.Name = "buttonPause2";
            this.buttonPause2.Size = new System.Drawing.Size(49, 49);
            this.buttonPause2.TabIndex = 3;
            this.buttonPause2.UseVisualStyleBackColor = false;
            this.buttonPause2.Click += new System.EventHandler(this.buttonPause2_Click);
            // 
            // buttonNextTrek2
            // 
            this.buttonNextTrek2.BackColor = System.Drawing.Color.Transparent;
            this.buttonNextTrek2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonNextTrek2.FlatAppearance.BorderSize = 0;
            this.buttonNextTrek2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonNextTrek2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.buttonNextTrek2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNextTrek2.Image = global::PlayerEK.Properties.Resources.rewind_next;
            this.buttonNextTrek2.Location = new System.Drawing.Point(122, 38);
            this.buttonNextTrek2.Name = "buttonNextTrek2";
            this.buttonNextTrek2.Size = new System.Drawing.Size(49, 49);
            this.buttonNextTrek2.TabIndex = 2;
            this.buttonNextTrek2.UseVisualStyleBackColor = false;
            this.buttonNextTrek2.Click += new System.EventHandler(this.buttonNextTrek2_Click);
            // 
            // buttonPlay2
            // 
            this.buttonPlay2.BackColor = System.Drawing.Color.Transparent;
            this.buttonPlay2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPlay2.FlatAppearance.BorderSize = 0;
            this.buttonPlay2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonPlay2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.buttonPlay2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlay2.Image = global::PlayerEK.Properties.Resources.play;
            this.buttonPlay2.Location = new System.Drawing.Point(67, 38);
            this.buttonPlay2.Name = "buttonPlay2";
            this.buttonPlay2.Size = new System.Drawing.Size(49, 49);
            this.buttonPlay2.TabIndex = 1;
            this.buttonPlay2.UseVisualStyleBackColor = false;
            this.buttonPlay2.Click += new System.EventHandler(this.buttonPlay2_Click);
            // 
            // buttonPreviousTrek2
            // 
            this.buttonPreviousTrek2.BackColor = System.Drawing.Color.Transparent;
            this.buttonPreviousTrek2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPreviousTrek2.DialogResult = System.Windows.Forms.DialogResult.No;
            this.buttonPreviousTrek2.FlatAppearance.BorderSize = 0;
            this.buttonPreviousTrek2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonPreviousTrek2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.buttonPreviousTrek2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPreviousTrek2.Image = global::PlayerEK.Properties.Resources.rewind_previous;
            this.buttonPreviousTrek2.Location = new System.Drawing.Point(12, 38);
            this.buttonPreviousTrek2.Name = "buttonPreviousTrek2";
            this.buttonPreviousTrek2.Size = new System.Drawing.Size(49, 49);
            this.buttonPreviousTrek2.TabIndex = 0;
            this.buttonPreviousTrek2.UseVisualStyleBackColor = false;
            this.buttonPreviousTrek2.Click += new System.EventHandler(this.buttonPreviousTrek2_Click);
            // 
            // PlayerEKmini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 91);
            this.Controls.Add(this.panelVisualVoice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PlayerEKmini";
            this.Text = "PlayerEKmini";
            this.panelVisualVoice.ResumeLayout(false);
            this.panelVisualVoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CodeeloUI.Controls.CodeeloGradientPanel panelVisualVoice;
        private System.Windows.Forms.Button buttonPreviousTrek2;
        private System.Windows.Forms.Button buttonStop2;
        private System.Windows.Forms.Button buttonPause2;
        private System.Windows.Forms.Button buttonNextTrek2;
        private System.Windows.Forms.Button buttonPlay2;
        private System.Windows.Forms.Button buttonExit2;
        private System.Windows.Forms.Button buttonOpenForm;
        private System.Windows.Forms.PictureBox pictureBox2;
        public MB.Controls.ColorSlider sliderVolume2;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Label labelVolumeProcent2;
        public System.Windows.Forms.CheckBox checkBoxMuteVolume2;
    }
}