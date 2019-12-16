using EqPlayer.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EqPlayer
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Нажатие на кнопке эквалайзера для открытия диалогового окна
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void importButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        /// <summary>
        /// запись выбраных для воспроизведения файлов в массив проигрываемых файлов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            Main._files.Add(openFileDialog1.FileName);
            playList.Items.Add(Main.GetFileName(openFileDialog1.FileName));
        }

        /// <summary>
        /// активация воспроизведения кнопкой P
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playButton_Click(object sender, EventArgs e)
        {
            if((playList.Items.Count != 0) && (playList.SelectedIndex != -1))
            {
                string current = Main._files[playList.SelectedIndex];
                BassPlayer.Play(current);
                trackTime.Text = TimeSpan.FromSeconds(BassPlayer.GetTimeOfStream(BassPlayer._stream)).ToString();
                slTime.Maximum = BassPlayer.GetTimeOfStream(BassPlayer._stream);
                timer.Enabled = true;
            }
        }

        /// <summary>
        /// Остановка воспроизведения по кнопке S
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stopButton_Click(object sender, EventArgs e)
        {
            BassPlayer.Stop();
            timer.Enabled = false;
            slTime.Value = 0;
            playTime.Text = "00:00:00";
        }

        /// <summary>
        /// отсчет таймера для обновления показателей
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            playTime.Text = TimeSpan.FromSeconds(BassPlayer.GetPosOfStream(BassPlayer._stream)).ToString();
            slTime.Value = BassPlayer.GetPosOfStream(BassPlayer._stream);
           
        }

        /// <summary>
        /// функция перемотки трека посредством слайдера прогресса проигрывания
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void slTime_Scroll(object sender, EventArgs e)
        {
            BassPlayer.SetPosOfScroll(BassPlayer._stream, slTime.Value);
        }


        /// <summary>
        /// функция изменения звука посредством слайзера звука
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void slVol_Scroll(object sender, EventArgs e)
        {
            BassPlayer.SetVolumeToStream(BassPlayer._stream, slVol.Value);
        }

        /// <summary>
        /// Приостановка проигрывания кнопкой U
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pauseButton_Click(object sender, EventArgs e)
        {
            BassPlayer.Pause();
            timer.Enabled = false;
        }

        /// <summary>
        /// обновление данных эквалайзера при измении значения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sl50hz_Scroll(object sender, EventArgs e)
        {
            Main.eqValues[0] = sl50hz.Value - 10;
            if (Main.EqIsActive == true)
                eq.UpdateEq(Main.eqValues, Main.fx, Main.freq, 0);
        }

        private void sl100hz_Scroll(object sender, EventArgs e)
        {
            Main.eqValues[1] = sl100hz.Value - 10;
            if (Main.EqIsActive == true)
                eq.UpdateEq(Main.eqValues, Main.fx, Main.freq ,1);
        }

        private void sl250hz_Scroll(object sender, EventArgs e)
        {
            Main.eqValues[2] = sl250hz.Value - 10;
            if (Main.EqIsActive == true)
                eq.UpdateEq(Main.eqValues, Main.fx, Main.freq, 2);
        }

        private void sl500hz_Scroll(object sender, EventArgs e)
        {
            Main.eqValues[3] = sl500hz.Value - 10;
            if (Main.EqIsActive == true)
                eq.UpdateEq(Main.eqValues, Main.fx, Main.freq, 3);
        }

        private void sl1khz_Scroll(object sender, EventArgs e)
        {
            Main.eqValues[4] = sl1khz.Value - 10;
            if (Main.EqIsActive == true)
                eq.UpdateEq(Main.eqValues, Main.fx, Main.freq, 4);
        }

        private void sl2_5khz_Scroll(object sender, EventArgs e)
        {
            Main.eqValues[5] = sl2_5khz.Value - 10;
            if (Main.EqIsActive == true)
                eq.UpdateEq(Main.eqValues, Main.fx, Main.freq, 5);
        }

        private void sl5khz_Scroll(object sender, EventArgs e)
        {
            Main.eqValues[6] = sl5khz.Value - 10;
            if (Main.EqIsActive == true)
                eq.UpdateEq(Main.eqValues, Main.fx, Main.freq, 6);
        }

        private void sl8khz_Scroll(object sender, EventArgs e)
        {
            Main.eqValues[7] = sl8khz.Value - 10;
            if (Main.EqIsActive == true)
                eq.UpdateEq(Main.eqValues, Main.fx, Main.freq, 7);
        }

        private void sl12khz_Scroll(object sender, EventArgs e)
        {
            Main.eqValues[8] = sl12khz.Value - 10;
            if (Main.EqIsActive == true)
                eq.UpdateEq(Main.eqValues, Main.fx, Main.freq, 8);
        }

        private void sl15khz_Scroll(object sender, EventArgs e)
        {
            Main.eqValues[9] = sl15khz.Value - 10;
            if (Main.EqIsActive == true)
                eq.UpdateEq(Main.eqValues, Main.fx, Main.freq, 9);
        }

        /// <summary>
        /// активация эквалайзера кнопкой EQ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void eqButton_Click(object sender, EventArgs e)
        {
            if (!Main.EqIsActive)
            {
                eq.ActivEq(Main.eqValues, Main.fx, Main.freq, BassPlayer._stream);
                Main.EqIsActive = true;
                eqTextSwitch.Text = "ON";
            } else
            {
                eq.DeactivEq(Main.fx);
                Main.EqIsActive = false;
                eqTextSwitch.Text = "OFF";
            }
            
        }
    }
}
