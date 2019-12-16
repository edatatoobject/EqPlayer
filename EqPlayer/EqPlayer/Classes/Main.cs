using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqPlayer.Classes
{
    public static class Main
    {
        /// <summary>
        /// список полных имен файлов
        /// </summary>
        public static List<string> _files = new List<string>();

        /// <summary>
        /// Массив хранящий показания всех эквализационных значений
        /// </summary>
        public static int[] eqValues = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        /// <summary>
        /// Номер текущего трека
        /// </summary>
        public static int currantTrackNumber;

        /// <summary>
        /// массив значений эффектов, должен быть равен количеству полос эквалайзера
        /// </summary>
        public static int[] fx = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        /// <summary>
        /// массив частот, вводятся частоты всех полос эквалайзера
        /// </summary>
        public static int[] freq = new int[] { 50, 100, 250, 500, 1000, 2500, 5000, 8000, 12000, 15000 };

        /// <summary>
        /// Переменная статуса эквалайзера
        /// </summary>
        public static bool EqIsActive = false;



        /// <summary>
        /// Получение имени файла
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public static string GetFileName(string file)
        {
            string[] tmp = file.Split('\\');
            return tmp[tmp.Length - 1];
        }
    }
}
