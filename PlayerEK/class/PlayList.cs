using System;
using System.Collections.Generic;


namespace PlayerEK
{ 
    public class PlayList
    {
        public PlayList() { }

        #region[ Поля ]
        /*переменная хранит в себе путь к программе*/
        public static string AppPath = AppDomain.CurrentDomain.BaseDirectory;
        /*Список полных имен файлов*/
        public static List<string> Files = new List<string>();
        /*переменная хранит текущую позицию в playList*/
        public static int CurrentTrackNumber;
        #endregion


        #region[ Методы ]
        /*Получение имя файла для playlist*/
        public static string GetFileName(string file)
        {
            string[] trackName = file.Split('\\');
            return trackName[trackName.Length - 1]; 
        }

        /*Определенные форматы в playList*/
        public static void SetInputFormats()
        {
            FormHide.Link.openFileDialog1.Filter = "Все форматы|*.mp3; *.m4a; *mp4; *.tta; *.alac; *.ogg; *.opus; *.acc; *.ac3; *.mpc; *.ape; *.flac; *.wma; *.wv"
                                           + "|MPEG Audio Layer III (*.mp3)|*.mp3"
                                           + "|Advanced Audio Coding (*.m4a; *.mp4)|*.m4a;*.mp4"
                                           + "|OGG Vorbis Audio (*.ogg)|*.ogg"
                                           + "|OPUS Audio (*.opus)|*.opus"
                                           + "|Dolby Digital AC3 (*.ac3)|*.ac3"
                                           + "|Monkey's Audio (*.ape)|*.ape"
                                           + "|MusePack (*.mpc)|*.mpc"
                                           + "|Free Lossless Audio Codec (*.flac)|*.flac"
                                           + "|Windows Media Audio (*.wma)|*.wma"
                                           + "|True Audio (*.tta)|*.tta"
                                           + "|Apple Lossless Audio Codec (*.alac)|*.alac"
                                           + "|WavPack (*.wv)|*.wv";
        }
        #endregion
    }
}
