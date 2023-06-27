using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace PlayerEK
{
    public partial class PlayerEKmini : Form
    {
        public PlayerEKmini()
        {
            InitializeComponent();
            MovementForm();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MovementForm()
        {
            new List<Control> {  panelVisualVoice }.ForEach(x =>
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

        private void buttonOpenForm_Click(object sender, EventArgs e)
        {
            FormHide.ShowForm1(FormHide.Link);
            this.Hide();
        }

        private void buttonStop2_Click(object sender, EventArgs e)
        {
            FormHide.Link.buttonStop_Click(this, EventArgs.Empty);
        }

        private void buttonPlay2_Click(object sender, EventArgs e)
        {
            FormHide.Link.buttonPlay_Click(this, EventArgs.Empty);
        }

        private void buttonPause2_Click(object sender, EventArgs e)
        {
            FormHide.Link.buttonPause_Click(this, EventArgs.Empty);
        }

        private void buttonPreviousTrek2_Click(object sender, EventArgs e)
        {
            FormHide.Link.buttonPreviousTrek_Click(this, EventArgs.Empty);
        }

        private void buttonNextTrek2_Click(object sender, EventArgs e)
        {
            FormHide.Link.buttonNextTrek_Click(this, EventArgs.Empty);
        }

        private void sliderVolume2_Scroll(object sender, ScrollEventArgs e)
        {
            labelVolumeProcent2.Text = BassInit.Volume.ToString(); 
            BassInit.VolumeSetToStream(BassInit.Stream, sliderVolume2.Value);
            FormHide.Link.labelVolumeProcent.Text = labelVolumeProcent2.Text;
            FormHide.Link.sliderVolume.Value = sliderVolume2.Value;
            FormHide.Link.checkBoxMuteVolume.Checked = false; 
            checkBoxMuteVolume2.Checked = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
        }

        private void checkBoxMuteVolume2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxMuteVolume2.Checked)
            {
                labelVolumeProcent2.Text = "0";
                sliderVolume2.Value = 0;
                BassInit.VolumeSetToStream(BassInit.Stream, sliderVolume2.Value);
                FormHide.Link.labelVolumeProcent.Text = labelVolumeProcent2.Text;
                FormHide.Link.sliderVolume.Value = sliderVolume2.Value;
                BassInit.VolumeSetToStream(BassInit.Stream, FormHide.Link.sliderVolume.Value);
                FormHide.Link.checkBoxMuteVolume.Checked = true;
            }
        }
    }
}
