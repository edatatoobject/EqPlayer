using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Un4seen.Bass;

namespace EqPlayer.Classes
{
    class eq
    {
        /// <summary>
        /// объявление эквалайзера
        /// </summary>
        public static BASS_DX8_PARAMEQ EQ = new BASS_DX8_PARAMEQ();

        /// <summary>
        /// Переменная добротности полосы
        /// </summary>
        public static float bandwidth;

        /// <summary>
        /// Функция активации эквалайзера
        /// </summary>
        /// <param name="eqFx"></param>
        public static void ActivEq(int[] eqFx, int[] fx, int[] freq, int handle)
        {
            if (fx.Length < 15)
                bandwidth = 12.0f;
            else
                bandwidth = 6.0f;
            for (int i = 0; i < fx.Length; i++)
            {
                fx[i] = Bass.BASS_ChannelSetFX(handle, BASSFXType.BASS_FX_DX8_PARAMEQ, 0);
                SetParametersEQ(fx[i], freq[i], eqFx[i]);
            }

        }

        /// <summary>
        /// функция обновления параметров эквалайзера при изменении значений слайдеров
        /// </summary>
        /// <param name="eqFx"></param>
        public static void UpdateEq(int[] eqFx, int[] fx, int[] freq, int p)
        {
                SetParametersEQ(fx[p], freq[p], eqFx[p]);
        }

        /// <summary>
        /// функция отключения эквалайзера
        /// </summary>
        public static void DeactivEq(int[] fx)
        {
            for (int i = 0; i < fx.Length; i++)
                Bass.BASS_ChannelRemoveFX(BassPlayer._stream, fx[i]);
            
        }

        /// <summary>
        /// Функция установки параметров эквалайзера в переменную
        /// </summary>
        /// <param name="fx"></param>
        /// <param name="center"></param>
        /// <param name="gain"></param>
        /// <returns></returns>
        public static bool SetParametersEQ(int fx , int center, int gain)
        {
            EQ.fBandwidth = bandwidth;
            EQ.fCenter = (float)center;
            EQ.fGain = (float)gain;
            return Bass.BASS_FXSetParameters(fx, EQ);
        }
    }
}
