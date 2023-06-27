using System.Windows.Forms;


namespace PlayerEK
{ 
    public class FormHide

    {
        /*ссылка на форму*/
        private static MusicPlayer _link;
        public static MusicPlayer Link
        {
            get
            {
                if (_link == null)
                    _link = new MusicPlayer();
                return _link;
            }
            set { _link = value; }
        }

        public static void ShowForm1(Form miniPlayer)
        {
                miniPlayer.Show();
        }

        public static void ShowForm2(Form miniPlayer)
        {
            if(!miniPlayer.IsDisposed)
                miniPlayer.Show();
        }
    }
}
