using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Un4seen.Bass;


namespace EqPlayer.Classes
{
    public static class BassPlayer
    {
        /// <summary>
        /// частота дискретизации
        /// </summary>
        private static int SR = 44100;

        /// <summary>
        /// состояние инициализации
        /// </summary>
        public static bool InitDefaultDevice;

        /// <summary>
        /// канал
        /// </summary>
        public static int _stream;

        /// <summary>
        /// громкость
        /// </summary>
        public static int _volume = 100;

        /// <summary>
        /// инициализация библиотеки bass.dll
        /// </summary>
        /// <param name="hz"></param>
        /// <returns></returns>
        public static bool InitBass(int hz)
        {
            if (!InitDefaultDevice)
                // функция bass.dll инициализирущая библиотеку
                InitDefaultDevice = Bass.BASS_Init(-1, hz, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero);
            return InitDefaultDevice;
        }

        /// <summary>
        /// метод начала проигрывания, принимает параметры полного пути к файлу проигрывания, и громкости воспроизведения
        /// и создает поток воспроизведения
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="vol"></param>
        public static void Play(string filename)
        {
            if (Bass.BASS_ChannelIsActive(_stream) != BASSActive.BASS_ACTIVE_PAUSED)
            {
                Stop();
                if (InitBass(SR))
                {
                    _stream = Bass.BASS_StreamCreateFile(filename, 0, 0, BASSFlag.BASS_DEFAULT);
                    if (_stream != 0)
                    {
                        SetVolumeToStream(_stream, _volume);
                        Bass.BASS_ChannelPlay(_stream, false);
                    }
                }
            }
            else
                Bass.BASS_ChannelPlay(_stream, false);
        }

        /// <summary>
        /// метод остановки воспроизведения
        /// </summary>
        public static void Stop()
        {
            Bass.BASS_ChannelStop(_stream);
            Bass.BASS_StreamFree(_stream);
        }

        /// <summary>
        /// функция приостановки воспроизведения
        /// </summary>
        public static void Pause()
        {
            if (Bass.BASS_ChannelIsActive(_stream) == BASSActive.BASS_ACTIVE_PLAYING)
            Bass.BASS_ChannelPause(_stream);
        }

        /// <summary>
        /// Получение длительности воспроизведения
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static int GetTimeOfStream(int stream)
        {
            long TimeBytes = Bass.BASS_ChannelGetLength(stream);
            double Time = Bass.BASS_ChannelBytes2Seconds(stream, TimeBytes);
            return (int)Time;
        }

        /// <summary>
        /// Установка позиции при перемотке
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="pos"></param>
        public static void SetPosOfScroll(int stream, int pos)
        {
            Bass.BASS_ChannelSetPosition(stream, (double)pos);
        }

        /// <summary>
        /// Получение позиции воспроизведения
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static int GetPosOfStream(int stream)
        {
            long pos = Bass.BASS_ChannelGetPosition(stream);
            int posSec = (int)Bass.BASS_ChannelBytes2Seconds(stream, pos);
            return posSec;
        }

        /// <summary>
        /// метод установки громкости
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="vol"></param>
        public static void SetVolumeToStream(int stream, int vol)
        {
            _volume = vol;
            Bass.BASS_ChannelSetAttribute(stream, BASSAttribute.BASS_ATTRIB_VOL, _volume / 100F);
        }
    }
}
