namespace PlayerEK
{
    partial class MusicPlayer
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlayer));
            this.PlayerPanel = new CodeeloUI.Controls.CodeeloGradientPanel();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.checkBoxRepeat = new System.Windows.Forms.CheckBox();
            this.checkBoxRandomTrek = new System.Windows.Forms.CheckBox();
            this.checkBoxMuteVolume = new System.Windows.Forms.CheckBox();
            this.checkBoxReplay = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonCollapse = new System.Windows.Forms.Button();
            this.labelVolumeProcent = new System.Windows.Forms.Label();
            this.labelTimer = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.sliderTime = new MB.Controls.ColorSlider();
            this.playList = new System.Windows.Forms.ListBox();
            this.sliderVolume = new MB.Controls.ColorSlider();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.buttonOpenMinPlayer = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panelVisualVoice = new System.Windows.Forms.Panel();
            this.buttonPreviousTrek = new System.Windows.Forms.Button();
            this.buttonNextTrek = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.PlayerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayerPanel
            // 
            this.PlayerPanel.AccessibleRole = null;
            this.PlayerPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PlayerPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PlayerPanel.CausesValidation = false;
            this.PlayerPanel.ColorFillFirst = System.Drawing.Color.Aqua;
            this.PlayerPanel.ColorFillSecond = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.PlayerPanel.Controls.Add(this.buttonDelete);
            this.PlayerPanel.Controls.Add(this.checkBoxRepeat);
            this.PlayerPanel.Controls.Add(this.checkBoxRandomTrek);
            this.PlayerPanel.Controls.Add(this.checkBoxMuteVolume);
            this.PlayerPanel.Controls.Add(this.checkBoxReplay);
            this.PlayerPanel.Controls.Add(this.pictureBox2);
            this.PlayerPanel.Controls.Add(this.pictureBox1);
            this.PlayerPanel.Controls.Add(this.buttonCollapse);
            this.PlayerPanel.Controls.Add(this.labelVolumeProcent);
            this.PlayerPanel.Controls.Add(this.labelTimer);
            this.PlayerPanel.Controls.Add(this.labelTime);
            this.PlayerPanel.Controls.Add(this.sliderTime);
            this.PlayerPanel.Controls.Add(this.playList);
            this.PlayerPanel.Controls.Add(this.sliderVolume);
            this.PlayerPanel.Controls.Add(this.buttonOpenFile);
            this.PlayerPanel.Controls.Add(this.buttonOpenMinPlayer);
            this.PlayerPanel.Controls.Add(this.buttonExit);
            this.PlayerPanel.Controls.Add(this.panelVisualVoice);
            this.PlayerPanel.Controls.Add(this.buttonPreviousTrek);
            this.PlayerPanel.Controls.Add(this.buttonNextTrek);
            this.PlayerPanel.Controls.Add(this.buttonPause);
            this.PlayerPanel.Controls.Add(this.buttonStop);
            this.PlayerPanel.Controls.Add(this.buttonPlay);
            this.PlayerPanel.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.PlayerPanel.Location = new System.Drawing.Point(0, 0);
            this.PlayerPanel.Name = "PlayerPanel";
            this.PlayerPanel.Size = new System.Drawing.Size(800, 450);
            this.PlayerPanel.TabIndex = 0;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Transparent;
            this.buttonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Image = global::PlayerEK.Properties.Resources.delete;
            this.buttonDelete.Location = new System.Drawing.Point(336, 197);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(25, 25);
            this.buttonDelete.TabIndex = 23;
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // checkBoxRepeat
            // 
            this.checkBoxRepeat.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxRepeat.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxRepeat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkBoxRepeat.FlatAppearance.BorderSize = 0;
            this.checkBoxRepeat.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.checkBoxRepeat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.checkBoxRepeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxRepeat.Image = global::PlayerEK.Properties.Resources.repeat;
            this.checkBoxRepeat.Location = new System.Drawing.Point(336, 88);
            this.checkBoxRepeat.Name = "checkBoxRepeat";
            this.checkBoxRepeat.Size = new System.Drawing.Size(32, 32);
            this.checkBoxRepeat.TabIndex = 22;
            this.checkBoxRepeat.UseVisualStyleBackColor = false;
            this.checkBoxRepeat.CheckedChanged += new System.EventHandler(this.checkBoxRepeat_CheckedChanged);
            // 
            // checkBoxRandomTrek
            // 
            this.checkBoxRandomTrek.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxRandomTrek.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxRandomTrek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkBoxRandomTrek.FlatAppearance.BorderSize = 0;
            this.checkBoxRandomTrek.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.checkBoxRandomTrek.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.checkBoxRandomTrek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxRandomTrek.Image = global::PlayerEK.Properties.Resources.shuffle;
            this.checkBoxRandomTrek.Location = new System.Drawing.Point(336, 50);
            this.checkBoxRandomTrek.Name = "checkBoxRandomTrek";
            this.checkBoxRandomTrek.Size = new System.Drawing.Size(32, 32);
            this.checkBoxRandomTrek.TabIndex = 21;
            this.checkBoxRandomTrek.UseVisualStyleBackColor = false;
            this.checkBoxRandomTrek.CheckedChanged += new System.EventHandler(this.checkBoxRandomTrek_CheckedChanged);
            // 
            // checkBoxMuteVolume
            // 
            this.checkBoxMuteVolume.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxMuteVolume.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxMuteVolume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkBoxMuteVolume.FlatAppearance.BorderSize = 0;
            this.checkBoxMuteVolume.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.checkBoxMuteVolume.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.checkBoxMuteVolume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxMuteVolume.Image = global::PlayerEK.Properties.Resources.mute1;
            this.checkBoxMuteVolume.Location = new System.Drawing.Point(399, 320);
            this.checkBoxMuteVolume.Name = "checkBoxMuteVolume";
            this.checkBoxMuteVolume.Size = new System.Drawing.Size(32, 32);
            this.checkBoxMuteVolume.TabIndex = 20;
            this.checkBoxMuteVolume.UseVisualStyleBackColor = false;
            this.checkBoxMuteVolume.CheckedChanged += new System.EventHandler(this.checkBoxMuteVolume_CheckedChanged);
            // 
            // checkBoxReplay
            // 
            this.checkBoxReplay.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxReplay.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxReplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkBoxReplay.FlatAppearance.BorderSize = 0;
            this.checkBoxReplay.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.checkBoxReplay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.checkBoxReplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxReplay.Image = global::PlayerEK.Properties.Resources.replay;
            this.checkBoxReplay.Location = new System.Drawing.Point(336, 12);
            this.checkBoxReplay.Name = "checkBoxReplay";
            this.checkBoxReplay.Size = new System.Drawing.Size(32, 32);
            this.checkBoxReplay.TabIndex = 19;
            this.checkBoxReplay.UseVisualStyleBackColor = false;
            this.checkBoxReplay.CheckedChanged += new System.EventHandler(this.checkBoxReplay_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::PlayerEK.Properties.Resources.volume;
            this.pictureBox2.Location = new System.Drawing.Point(380, 257);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::PlayerEK.Properties.Resources.pngegg;
            this.pictureBox1.Location = new System.Drawing.Point(437, 181);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(351, 208);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // buttonCollapse
            // 
            this.buttonCollapse.BackColor = System.Drawing.Color.Transparent;
            this.buttonCollapse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonCollapse.FlatAppearance.BorderSize = 0;
            this.buttonCollapse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonCollapse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.buttonCollapse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCollapse.Image = global::PlayerEK.Properties.Resources.down;
            this.buttonCollapse.Location = new System.Drawing.Point(741, 3);
            this.buttonCollapse.Name = "buttonCollapse";
            this.buttonCollapse.Size = new System.Drawing.Size(25, 25);
            this.buttonCollapse.TabIndex = 8;
            this.buttonCollapse.UseVisualStyleBackColor = false;
            this.buttonCollapse.Click += new System.EventHandler(this.buttonCollapse_Click);
            // 
            // labelVolumeProcent
            // 
            this.labelVolumeProcent.AutoSize = true;
            this.labelVolumeProcent.BackColor = System.Drawing.Color.Transparent;
            this.labelVolumeProcent.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVolumeProcent.Location = new System.Drawing.Point(399, 259);
            this.labelVolumeProcent.Name = "labelVolumeProcent";
            this.labelVolumeProcent.Size = new System.Drawing.Size(32, 22);
            this.labelVolumeProcent.TabIndex = 16;
            this.labelVolumeProcent.Text = "30";
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.BackColor = System.Drawing.Color.Transparent;
            this.labelTimer.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimer.Location = new System.Drawing.Point(709, 426);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(88, 22);
            this.labelTimer.TabIndex = 15;
            this.labelTimer.Text = "00:00:00";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.Color.Transparent;
            this.labelTime.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(12, 426);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(88, 22);
            this.labelTime.TabIndex = 14;
            this.labelTime.Text = "00:00:00";
            // 
            // sliderTime
            // 
            this.sliderTime.BackColor = System.Drawing.Color.Transparent;
            this.sliderTime.BarInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sliderTime.BarOuterColor = System.Drawing.Color.Aqua;
            this.sliderTime.BarPenColor = System.Drawing.Color.Black;
            this.sliderTime.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.sliderTime.ElapsedInnerColor = System.Drawing.Color.Lime;
            this.sliderTime.ElapsedOuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.sliderTime.LargeChange = ((uint)(5u));
            this.sliderTime.Location = new System.Drawing.Point(12, 393);
            this.sliderTime.Name = "sliderTime";
            this.sliderTime.Size = new System.Drawing.Size(776, 30);
            this.sliderTime.SmallChange = ((uint)(1u));
            this.sliderTime.TabIndex = 10;
            this.sliderTime.Text = "colorSlider1";
            this.sliderTime.ThumbInnerColor = System.Drawing.Color.Aqua;
            this.sliderTime.ThumbRoundRectSize = new System.Drawing.Size(8, 8);
            this.sliderTime.Value = 0;
            this.sliderTime.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sliderTime_Scroll);
            // 
            // playList
            // 
            this.playList.AllowDrop = true;
            this.playList.BackColor = System.Drawing.Color.Aqua;
            this.playList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playList.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playList.FormattingEnabled = true;
            this.playList.ItemHeight = 15;
            this.playList.Location = new System.Drawing.Point(12, 12);
            this.playList.Name = "playList";
            this.playList.Size = new System.Drawing.Size(318, 210);
            this.playList.TabIndex = 13;
            this.playList.DragDrop += new System.Windows.Forms.DragEventHandler(this.playList_DragDrop);
            this.playList.DragEnter += new System.Windows.Forms.DragEventHandler(this.playList_DragEnter);
            this.playList.DoubleClick += new System.EventHandler(this.buttonPlay_Click);
            // 
            // sliderVolume
            // 
            this.sliderVolume.BackColor = System.Drawing.Color.Transparent;
            this.sliderVolume.BarInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sliderVolume.BarOuterColor = System.Drawing.Color.Aqua;
            this.sliderVolume.BarPenColor = System.Drawing.Color.Black;
            this.sliderVolume.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.sliderVolume.ElapsedInnerColor = System.Drawing.Color.Lime;
            this.sliderVolume.ElapsedOuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.sliderVolume.LargeChange = ((uint)(5u));
            this.sliderVolume.Location = new System.Drawing.Point(221, 284);
            this.sliderVolume.Name = "sliderVolume";
            this.sliderVolume.Size = new System.Drawing.Size(210, 30);
            this.sliderVolume.SmallChange = ((uint)(1u));
            this.sliderVolume.TabIndex = 11;
            this.sliderVolume.Text = "colorSlider1";
            this.sliderVolume.ThumbInnerColor = System.Drawing.Color.Aqua;
            this.sliderVolume.ThumbRoundRectSize = new System.Drawing.Size(8, 8);
            this.sliderVolume.Value = 30;
            this.sliderVolume.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sliderVolume_Scroll);
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.BackColor = System.Drawing.Color.Transparent;
            this.buttonOpenFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonOpenFile.FlatAppearance.BorderSize = 0;
            this.buttonOpenFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonOpenFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.buttonOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenFile.Image = global::PlayerEK.Properties.Resources.insert;
            this.buttonOpenFile.Location = new System.Drawing.Point(12, 239);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(49, 49);
            this.buttonOpenFile.TabIndex = 12;
            this.buttonOpenFile.UseVisualStyleBackColor = false;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // buttonOpenMinPlayer
            // 
            this.buttonOpenMinPlayer.BackColor = System.Drawing.Color.Transparent;
            this.buttonOpenMinPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonOpenMinPlayer.FlatAppearance.BorderSize = 0;
            this.buttonOpenMinPlayer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonOpenMinPlayer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.buttonOpenMinPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenMinPlayer.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenMinPlayer.Image")));
            this.buttonOpenMinPlayer.Location = new System.Drawing.Point(710, 3);
            this.buttonOpenMinPlayer.Name = "buttonOpenMinPlayer";
            this.buttonOpenMinPlayer.Size = new System.Drawing.Size(25, 25);
            this.buttonOpenMinPlayer.TabIndex = 9;
            this.buttonOpenMinPlayer.UseVisualStyleBackColor = false;
            this.buttonOpenMinPlayer.Click += new System.EventHandler(this.buttonOpenMinPlayer_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Transparent;
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Image = ((System.Drawing.Image)(resources.GetObject("buttonExit.Image")));
            this.buttonExit.Location = new System.Drawing.Point(772, 3);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(25, 25);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // panelVisualVoice
            // 
            this.panelVisualVoice.BackColor = System.Drawing.Color.Transparent;
            this.panelVisualVoice.ForeColor = System.Drawing.Color.Black;
            this.panelVisualVoice.Location = new System.Drawing.Point(437, 34);
            this.panelVisualVoice.Name = "panelVisualVoice";
            this.panelVisualVoice.Size = new System.Drawing.Size(351, 141);
            this.panelVisualVoice.TabIndex = 6;
            this.panelVisualVoice.Paint += new System.Windows.Forms.PaintEventHandler(this.panelVisualVoice_Paint);
            // 
            // buttonPreviousTrek
            // 
            this.buttonPreviousTrek.BackColor = System.Drawing.Color.Transparent;
            this.buttonPreviousTrek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPreviousTrek.FlatAppearance.BorderSize = 0;
            this.buttonPreviousTrek.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonPreviousTrek.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.buttonPreviousTrek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPreviousTrek.Image = global::PlayerEK.Properties.Resources.rewind_previous;
            this.buttonPreviousTrek.Location = new System.Drawing.Point(12, 338);
            this.buttonPreviousTrek.Name = "buttonPreviousTrek";
            this.buttonPreviousTrek.Size = new System.Drawing.Size(49, 49);
            this.buttonPreviousTrek.TabIndex = 5;
            this.buttonPreviousTrek.UseVisualStyleBackColor = false;
            this.buttonPreviousTrek.Click += new System.EventHandler(this.buttonPreviousTrek_Click);
            // 
            // buttonNextTrek
            // 
            this.buttonNextTrek.BackColor = System.Drawing.Color.Transparent;
            this.buttonNextTrek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonNextTrek.FlatAppearance.BorderSize = 0;
            this.buttonNextTrek.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonNextTrek.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.buttonNextTrek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNextTrek.Image = global::PlayerEK.Properties.Resources.rewind_next;
            this.buttonNextTrek.Location = new System.Drawing.Point(122, 338);
            this.buttonNextTrek.Name = "buttonNextTrek";
            this.buttonNextTrek.Size = new System.Drawing.Size(49, 49);
            this.buttonNextTrek.TabIndex = 4;
            this.buttonNextTrek.UseVisualStyleBackColor = false;
            this.buttonNextTrek.Click += new System.EventHandler(this.buttonNextTrek_Click);
            // 
            // buttonPause
            // 
            this.buttonPause.BackColor = System.Drawing.Color.Transparent;
            this.buttonPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPause.FlatAppearance.BorderSize = 0;
            this.buttonPause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonPause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.buttonPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPause.Image = global::PlayerEK.Properties.Resources.pause;
            this.buttonPause.Location = new System.Drawing.Point(177, 338);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(49, 49);
            this.buttonPause.TabIndex = 3;
            this.buttonPause.UseVisualStyleBackColor = false;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.BackColor = System.Drawing.Color.Transparent;
            this.buttonStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonStop.FlatAppearance.BorderSize = 0;
            this.buttonStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.buttonStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStop.Image = global::PlayerEK.Properties.Resources.stop;
            this.buttonStop.Location = new System.Drawing.Point(232, 338);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(49, 49);
            this.buttonStop.TabIndex = 2;
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackColor = System.Drawing.Color.Transparent;
            this.buttonPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPlay.FlatAppearance.BorderSize = 0;
            this.buttonPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.buttonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlay.Image = global::PlayerEK.Properties.Resources.play;
            this.buttonPlay.Location = new System.Drawing.Point(67, 338);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(49, 49);
            this.buttonPlay.TabIndex = 1;
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 150;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // MusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PlayerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MusicPlayer";
            this.Text = "PlayerEK";
            this.PlayerPanel.ResumeLayout(false);
            this.PlayerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CodeeloUI.Controls.CodeeloGradientPanel PlayerPanel;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonPreviousTrek;
        private System.Windows.Forms.Button buttonNextTrek;
        private System.Windows.Forms.Button buttonOpenMinPlayer;
        private System.Windows.Forms.Button buttonCollapse;
        private System.Windows.Forms.Button buttonExit;
        private MB.Controls.ColorSlider sliderTime;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer2;
        public System.Windows.Forms.Panel panelVisualVoice;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox checkBoxReplay;
        public System.Windows.Forms.CheckBox checkBoxMuteVolume;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label labelVolumeProcent;
        public MB.Controls.ColorSlider sliderVolume;
        public System.Windows.Forms.ListBox playList;
        private System.Windows.Forms.CheckBox checkBoxRandomTrek;
        public System.Windows.Forms.CheckBox checkBoxRepeat;
        public System.Windows.Forms.Button buttonDelete;
    }
}

