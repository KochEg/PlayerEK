using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;



namespace PlayerEK
{
    public partial class MusicPlayer : Form
    {
        PlayerEKmini playerEKmini = new PlayerEKmini();
        
        public MusicPlayer()
        {
            InitializeComponent();
            FormHide.Link = this;
            BassInit.InitializationBass(BassInit.HZ);
            PlayList.SetInputFormats();
            MovementForm();
            NoFlicker();
        }

        /*Перетаскивание формы с помощью мыши*/
        private void MovementForm()
        {
            new List<Control> { PlayerPanel, panelVisualVoice, pictureBox1 }.ForEach(x =>
            {
                x.MouseDown += (s, a) =>
                {
                    x.Capture = false;
                    Capture = false;
                    var mes = Message.Create(Handle, 0xA1, new IntPtr(2), IntPtr.Zero);
                    base.WndProc(ref mes);
                };
            });
        }

        /*Избавление от мерцания в панели Визуализатора*/
        private void NoFlicker()
        {
            typeof(Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic |
                                        System.Reflection.BindingFlags.Instance |
                                        System.Reflection.BindingFlags.SetProperty).SetValue(panelVisualVoice, true, null);
        }

        /*Кнопка выход*/
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /*Кнопка свернуть*/
        private void buttonCollapse_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /*Кнопка открыть файл*/
        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string[] tmp = openFileDialog1.FileNames;
            for (int i = 0; i < tmp.Length; i++)
            {
                PlayList.Files.Add(tmp[i]);
                Tag TM = new Tag(tmp[i]);
                playList.Items.Add(TM.Artist + " - " + TM.Title);
                
            } 
        }


        /*кнопка STOP*/
        public void buttonStop_Click(object sender, EventArgs e)
        {
            BassInit.Stop();
            timer1.Enabled = false;
            sliderTime.Value = 0;
            labelTime.Text = "00:00:00";
        }

        /*кнопка PLAY*/
        public void buttonPlay_Click(object sender, EventArgs e)
        {
            if ((playList.Items.Count != 0) && (playList.SelectedIndex != -1))
            {
                string current = PlayList.Files[playList.SelectedIndex];
                PlayList.CurrentTrackNumber = playList.SelectedIndex;
                BassInit.Play(current, BassInit.Volume);
                playerEKmini.textBox1.Text = playList.SelectedIndex.ToString(playList.Text);
                labelTime.Text = TimeSpan.FromSeconds(BassInit.GetPositionOfStream(BassInit.Stream)).ToString();
                labelTimer.Text = TimeSpan.FromSeconds(BassInit.TimeOfStream(BassInit.Stream)).ToString();
                sliderTime.Maximum = BassInit.TimeOfStream(BassInit.Stream);
                sliderTime.Value = BassInit.GetPositionOfStream(BassInit.Stream);
                timer1.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = TimeSpan.FromSeconds(BassInit.GetPositionOfStream(BassInit.Stream)).ToString();
            sliderTime.Value = BassInit.GetPositionOfStream(BassInit.Stream);

            if(checkBoxRandomTrek.Checked)
            {
                if (BassInit.ToRandomTrack())
                {
                    playList.SelectedIndex = PlayList.CurrentTrackNumber;
                    playerEKmini.textBox1.Text = playList.SelectedIndex.ToString(playList.Text);
                    labelTime.Text = TimeSpan.FromSeconds(BassInit.GetPositionOfStream(BassInit.Stream)).ToString();
                    labelTimer.Text = TimeSpan.FromSeconds(BassInit.TimeOfStream(BassInit.Stream)).ToString();
                    sliderTime.Maximum = BassInit.TimeOfStream(BassInit.Stream);
                    sliderTime.Value = BassInit.GetPositionOfStream(BassInit.Stream);
                }

            }

            if(checkBoxRepeat.Checked)
            {
                if(BassInit.ToRepeatTrack())
                {
                    playList.SelectedIndex = PlayList.CurrentTrackNumber;
                    playerEKmini.textBox1.Text = playList.SelectedIndex.ToString(playList.Text);
                    labelTime.Text = TimeSpan.FromSeconds(BassInit.GetPositionOfStream(BassInit.Stream)).ToString();
                    labelTimer.Text = TimeSpan.FromSeconds(BassInit.TimeOfStream(BassInit.Stream)).ToString();
                    sliderTime.Maximum = BassInit.TimeOfStream(BassInit.Stream);
                    sliderTime.Value = BassInit.GetPositionOfStream(BassInit.Stream);
                }
            }

            if (BassInit.ToNextTrack())
            {
                playList.SelectedIndex = PlayList.CurrentTrackNumber;
                playerEKmini.textBox1.Text = playList.SelectedIndex.ToString(playList.Text);
                labelTime.Text = TimeSpan.FromSeconds(BassInit.GetPositionOfStream(BassInit.Stream)).ToString();
                labelTimer.Text = TimeSpan.FromSeconds(BassInit.TimeOfStream(BassInit.Stream)).ToString();
                sliderTime.Maximum = BassInit.TimeOfStream(BassInit.Stream);
                sliderTime.Value = BassInit.GetPositionOfStream(BassInit.Stream);
            }


            if (BassInit.EndPlayList)
            {
                buttonStop_Click(this, new EventArgs());
                playList.SelectedIndex = PlayList.CurrentTrackNumber = 0;
                BassInit.EndPlayList = false;
                if (checkBoxReplay.Checked)
                    buttonPlay_Click(this, new EventArgs());
                if (checkBoxRandomTrek.Checked)
                {
                    Random random = new Random();
                    playList.SelectedIndex = PlayList.CurrentTrackNumber = random.Next(0,PlayList.Files.Count);
                    buttonPlay_Click(this, new EventArgs());
                }
                if(checkBoxRepeat.Checked)
                {
                    playList.SelectedIndex = PlayList.CurrentTrackNumber = PlayList.Files.Count -1;
                    buttonPlay_Click(this, new EventArgs());
                }
            }
        }

        private void sliderTime_Scroll(object sender, ScrollEventArgs e)
        {
            BassInit.PosOfSlaider(BassInit.Stream, sliderTime.Value);
        }

        public void sliderVolume_Scroll(object sender, ScrollEventArgs e)
        {
            labelVolumeProcent.Text = BassInit.Volume.ToString();
            BassInit.VolumeSetToStream(BassInit.Stream, sliderVolume.Value);
            playerEKmini.labelVolumeProcent2.Text = labelVolumeProcent.Text;
            playerEKmini.sliderVolume2.Value = sliderVolume.Value;
            checkBoxMuteVolume.Checked = false;
            playerEKmini.checkBoxMuteVolume2.Checked = false;
        }

        private void panelVisualVoice_Paint(object sender, PaintEventArgs e)
        {
            Visualizer.GraphicVizual(e, panelVisualVoice);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Visualizer.TimerVizual();
            panelVisualVoice.Refresh();//перерисовка графика
        }


        /*Свернуть развернуть приложение через панель задач*/
        const int WS_MINIMIZEBOX = 0x20000;
        const int CS_DBLCLKS = 0x8;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= WS_MINIMIZEBOX;
                cp.ClassStyle |= CS_DBLCLKS;
                return cp;
            }
        }

        public void buttonPause_Click(object sender, EventArgs e)
        {
            BassInit.Pause();
        }

        public void buttonNextTrek_Click(object sender, EventArgs e)
        {
            BassInit.ClickButtonNextTrack();
            playList.SelectedIndex = PlayList.CurrentTrackNumber;
            playerEKmini.textBox1.Text = playList.SelectedIndex.ToString(playList.Text);
            labelTime.Text = TimeSpan.FromSeconds(BassInit.GetPositionOfStream(BassInit.Stream)).ToString();
            labelTimer.Text = TimeSpan.FromSeconds(BassInit.TimeOfStream(BassInit.Stream)).ToString();
            sliderTime.Maximum = BassInit.TimeOfStream(BassInit.Stream);
            sliderTime.Value = BassInit.GetPositionOfStream(BassInit.Stream);
        }

        public void buttonPreviousTrek_Click(object sender, EventArgs e)
        {
            BassInit.ClickButtonPreviousTrack();
            playList.SelectedIndex = PlayList.CurrentTrackNumber;
            playerEKmini.textBox1.Text = playList.SelectedIndex.ToString(playList.Text);
            labelTime.Text = TimeSpan.FromSeconds(BassInit.GetPositionOfStream(BassInit.Stream)).ToString();
            labelTimer.Text = TimeSpan.FromSeconds(BassInit.TimeOfStream(BassInit.Stream)).ToString();
            sliderTime.Maximum = BassInit.TimeOfStream(BassInit.Stream);
            sliderTime.Value = BassInit.GetPositionOfStream(BassInit.Stream);
        }

        private void playList_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                bool allowFilesDrop = true;
                foreach (string f in (string[])e.Data.GetData(DataFormats.FileDrop))
                {
                    allowFilesDrop = ((new System.IO.FileInfo(f)).Extension == ".mp3") ||
                                     ((new System.IO.FileInfo(f)).Extension == ".m4a") ||
                                     ((new System.IO.FileInfo(f)).Extension == ".mp4") ||
                                     ((new System.IO.FileInfo(f)).Extension == ".ogg") ||
                                     ((new System.IO.FileInfo(f)).Extension == ".opus") ||
                                     ((new System.IO.FileInfo(f)).Extension == ".ac3") ||
                                     ((new System.IO.FileInfo(f)).Extension == ".ape") ||
                                     ((new System.IO.FileInfo(f)).Extension == ".mpc") ||
                                     ((new System.IO.FileInfo(f)).Extension == ".flac") ||
                                     ((new System.IO.FileInfo(f)).Extension == ".wma") ||
                                     ((new System.IO.FileInfo(f)).Extension == ".tta") ||
                                     ((new System.IO.FileInfo(f)).Extension == ".alac") ||
                                     ((new System.IO.FileInfo(f)).Extension == ".wv");
                }

                if (allowFilesDrop)
                    e.Effect = DragDropEffects.All;
                else
                    e.Effect = DragDropEffects.None;
            }
        }

        private void playList_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                bool allowFilesDrop = true;
                foreach (string f in (string[])e.Data.GetData(DataFormats.FileDrop, true))
                {
                    allowFilesDrop = ((new System.IO.FileInfo(f)).Extension == ".mp3") ||
                                     ((new System.IO.FileInfo(f)).Extension == ".m4a") ||
                                     ((new System.IO.FileInfo(f)).Extension == ".mp4") ||
                                     ((new System.IO.FileInfo(f)).Extension == ".ogg") ||
                                     ((new System.IO.FileInfo(f)).Extension == ".opus") ||
                                     ((new System.IO.FileInfo(f)).Extension == ".ac3") ||
                                     ((new System.IO.FileInfo(f)).Extension == ".ape") ||
                                     ((new System.IO.FileInfo(f)).Extension == ".mpc") ||
                                     ((new System.IO.FileInfo(f)).Extension == ".flac") ||
                                     ((new System.IO.FileInfo(f)).Extension == ".wma") ||
                                     ((new System.IO.FileInfo(f)).Extension == ".tta") ||
                                     ((new System.IO.FileInfo(f)).Extension == ".alac") ||
                                     ((new System.IO.FileInfo(f)).Extension == ".wv");
                }

                if (allowFilesDrop)
                {
                    e.Effect = DragDropEffects.Copy;
                    string[] tmp = (string[])e.Data.GetData(DataFormats.FileDrop);
                    for (int i = 0; i < tmp.Length; i++)
                    {
                        PlayList.Files.Add(tmp[i]);
                        Tag TM = new Tag(tmp[i]);
                        playList.Items.Add(TM.Artist + " - " + TM.Title);
                    }
                }
                else
                    e.Effect = DragDropEffects.None;

            }
        }

        private void checkBoxMuteVolume_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMuteVolume.Checked)
            {
                labelVolumeProcent.Text = "0";
                sliderVolume.Value = 0;
                BassInit.VolumeSetToStream(BassInit.Stream, sliderVolume.Value);
                playerEKmini.labelVolumeProcent2.Text = labelVolumeProcent.Text;
                playerEKmini.sliderVolume2.Value = sliderVolume.Value;
                BassInit.VolumeSetToStream(BassInit.Stream, playerEKmini.sliderVolume2.Value);
                playerEKmini.checkBoxMuteVolume2.Checked = true;
            }
        }

        private void buttonOpenMinPlayer_Click(object sender, EventArgs e)
        {
           this.Hide();
           FormHide.ShowForm2(playerEKmini);
        }

        private void checkBoxReplay_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxReplay.Checked)
            {
                checkBoxRandomTrek.Checked = false;
                checkBoxRepeat.Checked = false; 
            }
        }

        private void checkBoxRandomTrek_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxRandomTrek.Checked)
            {
                checkBoxReplay.Checked = false;
                checkBoxRepeat.Checked= false;
            }
        }

        private void checkBoxRepeat_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxRepeat.Checked)
            {
                checkBoxRandomTrek.Checked= false;
                checkBoxReplay.Checked= false;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (playList.SelectedIndex != -1 && BassInit.IsStoped)
            {
                PlayList.Files.RemoveAt(playList.SelectedIndex);
                playList.Items.RemoveAt(playList.SelectedIndex);
            }
        }
    }
}
