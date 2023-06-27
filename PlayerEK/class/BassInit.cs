using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Un4seen.Bass;

namespace PlayerEK
{
    public abstract class BassInit
    {
        BassInit() { }

        #region [ Поля ]
        /*Частота дискретизации*/
        private const int _HZ = 44100;
        /*Состояние инициализации*/
        private static bool _initDevice;
        /*Звукавой канал*/
        private static int _stream;
        /*Громкость*/
        private static int _volume = 30;
        /*коллекция которая хранит плагины*/
        private static readonly List<int> BassHandlesPlugins = new List<int>();
        /*флаг остановки канала руками*/
        private static bool _isStoped = true;
        /*флаг полностью проигронного playList*/
        private static bool _endPlayList;
        #endregion


        #region [ Свойства ]
        public static bool EndPlayList 
        { 
          get { return _endPlayList; } 
          set { _endPlayList = value; }
        }

        public static int HZ
        { get { return _HZ; } }

        public static int Volume
        {
            get { return _volume; }
            private set { _volume = value; }
        }

        public static int Stream
        {
            get { return _stream; } 
        }

        public static bool IsStoped
        {
            get { return _isStoped; }
        }
        #endregion


        #region [ Методы ]
        /*Инициализация Bass.dll*/
        public static bool InitializationBass(int hz) 
        {
            if (!_initDevice)
            {
                _initDevice = Bass.BASS_Init(-1, hz, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero);
                if(_initDevice)
                {
                    BassHandlesPlugins.Add(Bass.BASS_PluginLoad(PlayList.AppPath + @"plugins\bass_aac.dll"));
                    BassHandlesPlugins.Add(Bass.BASS_PluginLoad(PlayList.AppPath + @"plugins\bass_ac3.dll"));
                    BassHandlesPlugins.Add(Bass.BASS_PluginLoad(PlayList.AppPath + @"plugins\bass_mpc.dll"));
                    BassHandlesPlugins.Add(Bass.BASS_PluginLoad(PlayList.AppPath + @"plugins\bass_tta.dll"));
                    BassHandlesPlugins.Add(Bass.BASS_PluginLoad(PlayList.AppPath + @"plugins\bassalac.dll"));
                    BassHandlesPlugins.Add(Bass.BASS_PluginLoad(PlayList.AppPath + @"plugins\bassape.dll"));
                    BassHandlesPlugins.Add(Bass.BASS_PluginLoad(PlayList.AppPath + @"plugins\bassflac.dll"));
                    BassHandlesPlugins.Add(Bass.BASS_PluginLoad(PlayList.AppPath + @"plugins\bassopus.dll"));
                    BassHandlesPlugins.Add(Bass.BASS_PluginLoad(PlayList.AppPath + @"plugins\basswma.dll"));
                    BassHandlesPlugins.Add(Bass.BASS_PluginLoad(PlayList.AppPath + @"plugins\basswv.dll"));

                    int ErrorCnt = 0;
                    for (int i = 0; i < BassHandlesPlugins.Count; i++)
                        if (BassHandlesPlugins[i] == 0)
                            ErrorCnt++;
                    if (ErrorCnt != 0) 
                        MessageBox.Show(ErrorCnt + " плагина не было загружено", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ErrorCnt = 0;
                }
            }
            return _initDevice;
        }

        /*Воспроизведение*/
        public static void Play(string fileName, int vol)
        {
            if (Bass.BASS_ChannelIsActive(_stream) != BASSActive.BASS_ACTIVE_PAUSED)
            {
                Stop();
                if (InitializationBass(_HZ))
                {
                    _stream = Bass.BASS_StreamCreateFile(fileName, 0, 0, BASSFlag.BASS_DEFAULT);
                    Visualizer.Channel = _stream;
                    if (_stream != 0)
                    {
                        Volume = vol;
                        Bass.BASS_ChannelSetAttribute(_stream, BASSAttribute.BASS_ATTRIB_VOL, Volume / 100F);
                        Bass.BASS_ChannelPlay(_stream, false);
                    }
                }
            }
            else
                Bass.BASS_ChannelPlay(_stream, false);
        _isStoped = false;
        }

        /*Стоп*/
        public static void Stop()
        {
            Bass.BASS_ChannelStop(_stream);
            Bass.BASS_StreamFree(_stream);
            _isStoped = true;
        }

        /*Пауза*/
        public static void Pause()
        {
            if (Bass.BASS_ChannelIsActive(_stream) == BASSActive.BASS_ACTIVE_PLAYING)
                Bass.BASS_ChannelPause(_stream);
        }

        /*Длитильность трека в секундак*/
        public static int TimeOfStream(int stream)
        {
            long TimeBytes = Bass.BASS_ChannelGetLength(stream);
            double Time = Bass.BASS_ChannelBytes2Seconds(stream, TimeBytes);
            return (int)Time;
        }

        /*Получение текущей позиции воспроизведения*/
        public static int GetPositionOfStream(int stream)
        {
            long position = Bass.BASS_ChannelGetPosition(stream);
            int secPos = (int)Bass.BASS_ChannelBytes2Seconds(stream, position);
            return secPos;
        }

        /*Перемотка трека*/
        public static void PosOfSlaider(int stream, int position)
        {
            Bass.BASS_ChannelSetPosition(stream, (double)position);
        }

        /*Установка громкости*/
        public static void VolumeSetToStream(int stream, int vol)
        {
            Volume = vol;
            Bass.BASS_ChannelSetAttribute(stream, BASSAttribute.BASS_ATTRIB_VOL, Volume / 100F);
        }

        /*Переключение трека по завершению другого трека*/
        public static bool ToNextTrack()
        {
            if((Bass.BASS_ChannelIsActive(_stream) == BASSActive.BASS_ACTIVE_STOPPED) && (!_isStoped))
            {
                if(PlayList.Files.Count > PlayList.CurrentTrackNumber +1)
                {
                    Play(PlayList.Files[++PlayList.CurrentTrackNumber], Volume);
                    _endPlayList = false;
                    return true;
                }
                else
                    _endPlayList= true;
            }
            return false;
        }

        /*Переключение трека по завершению другого трека в случайном порядке*/
        public static bool ToRandomTrack()
        {
            if ((Bass.BASS_ChannelIsActive(_stream) == BASSActive.BASS_ACTIVE_STOPPED) && (!_isStoped))
            {
                if (PlayList.Files.Count > PlayList.CurrentTrackNumber + 1)
                {
                    Random random = new Random();
                    PlayList.CurrentTrackNumber = random.Next(0, PlayList.Files.Count);
                    Play(PlayList.Files[PlayList.CurrentTrackNumber], Volume);
                    _endPlayList = false;
                    return true;
                }
                else
                    _endPlayList = true;
            }
            return false;
        }
         
        /*Повторение трека*/
        public static bool ToRepeatTrack()
        {
            if ((Bass.BASS_ChannelIsActive(_stream) == BASSActive.BASS_ACTIVE_STOPPED) && (!_isStoped))
            {
                if (PlayList.Files.Count > PlayList.CurrentTrackNumber + 1)
                {
                    Play(PlayList.Files[PlayList.CurrentTrackNumber], Volume);
                    _endPlayList = false;
                    return true;
                }
                else
                    _endPlayList = true;
            }
            return false;
        }

        /*Переключение трека на кнопку вперед*/
        public static void ClickButtonNextTrack()
        {
            if(PlayList.Files.Count > PlayList.CurrentTrackNumber + 1)
            {
                Play(PlayList.Files[++PlayList.CurrentTrackNumber], Volume);
            }
        }

        /*Переключение трека на кнопку назад*/
        public static void ClickButtonPreviousTrack()
        {
            if ((PlayList.Files.Count >= 0) && (PlayList.CurrentTrackNumber > 0)) 
            {
                Play(PlayList.Files[--PlayList.CurrentTrackNumber], Volume);
            }
        }
        #endregion
    }
}
