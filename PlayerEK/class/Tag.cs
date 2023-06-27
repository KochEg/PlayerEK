using System.Collections.Generic;
using Un4seen.Bass.AddOn.Tags;


namespace PlayerEK
{
    public class Tag
    {
        public Tag() { }
        public Tag(string nameFile) 
        {
            TAG_INFO tagInfo = new TAG_INFO();
            tagInfo = BassTags.BASS_TAG_GetFromFile(nameFile);
            _bitRate = tagInfo.bitrate;
            _freq = tagInfo.channelinfo.freq;
            _channel = ChannelIsDict[tagInfo.channelinfo.chans];
            _artist = tagInfo.artist;
            _album = tagInfo.album;
            if(tagInfo.title == "")
                _title = PlayList.GetFileName(nameFile);
            else
                _title = tagInfo.title;
            _year = tagInfo.year;
        }

        #region [ Поля ]
        private int _bitRate;
        private int _freq;
        private string _channel;
        private string _artist;
        private string _album;
        private string _title;
        private string _year;
        private Dictionary<int, string> ChannelIsDict = new Dictionary<int, string>()
        {
            {0, "Null" },
            {1, "Mono" },
            {2, "Stereo" }
        };
        #endregion

        #region [ Свойства ]
        public string Artist { get { return _artist; } }
        public string Title { get { return _title; } }
        #endregion
    }
}

