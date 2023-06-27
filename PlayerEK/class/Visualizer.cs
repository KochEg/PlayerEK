using System;
using System.Drawing;
using System.Windows.Forms;
using Un4seen.Bass;


namespace PlayerEK
{
    public abstract class Visualizer
    {
        Visualizer() { }    

        #region [ Поля ]
        /*Массив данных спектра Fast Fourier transform (Быстрое преобразование Фурье)*/
        private static Single[] _fft = null;
        /*Номер потока*/
        private static int _channel = 0;
        #endregion


        #region [ Свойства ]
        public static int Channel 
        { 
          get { return _channel; }
          set { _channel = value; }
        }
        #endregion


        #region [ Методы ]
        /*Установка таймера для визуализатора*/
        public static void TimerVizual()
        {
            if (_channel == 0) return;
            if (Bass.BASS_ChannelIsActive(_channel) != BASSActive.BASS_ACTIVE_PLAYING) return;

            _fft = new Single[2048];//выделяем массив для данных            
            Bass.BASS_ChannelGetData(_channel, _fft, (int)BASSData.BASS_DATA_FFT4096);//получаем спектр потока
            _fft[0] = 0.0f;//избавляемся от постоянной составляющей                                
        }

        /*Отрисовка графика визулизатора*/
        public static void GraphicVizual(PaintEventArgs e, Control panelVisualVoice)
        {
            if (Visualizer._fft == null) return;

            PointF p1, p2;
            float max_y = 0;//максимальное значение амплитуды
            float min_y = Single.MaxValue;//минимальное значение амплитуды
            float max_x = Visualizer._fft.Length - 1;//максимальная частота, для которой амплитуда ненулевая

            int i = 0;
            max_x = 0;
            foreach (float f in Visualizer._fft)//находим максимальные и минимальные значения
            {
                if (f > max_y) max_y = f;
                if (f < min_y) min_y = f;

                if (f > 0.001f) max_x = (float)i;
                i++;
            }

            /*меняем направление оси Y, чтобы она смотрела вверх*/
            e.Graphics.ScaleTransform(1.0f, -1.0f);
            e.Graphics.TranslateTransform(0.0f, -1.0f * panelVisualVoice.Height);

            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();

            float y;
            p1 = new PointF(0.0f, 0.0f);//начальная точка

            for (float x = 1; x <= max_x; x++)
            {
                y = Visualizer._fft[(int)x];

                /*вычисляем координату следующей точки по относительной амплитуде*/
                p2 = new PointF((x / max_x) * panelVisualVoice.Width, panelVisualVoice.Height * (y - min_y) / (max_y - min_y));

                path.AddLine(p1, p2);//добавляем линию в график
                p1 = p2;
            }
            Pen pen = new Pen(System.Drawing.Color.Black, 3.0F);
            e.Graphics.DrawPath(pen, path);
        }
        #endregion
    }
}
