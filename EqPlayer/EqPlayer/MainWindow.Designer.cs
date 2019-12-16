namespace EqPlayer
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.slTime = new Tools.Slider.SliderTrackBar();
            this.playList = new System.Windows.Forms.ListBox();
            this.slVol = new Tools.Slider.SliderTrackBar();
            this.playButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.stopButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.importButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.sl50hz = new Tools.Slider.SliderTrackBar();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.sl100hz = new Tools.Slider.SliderTrackBar();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.sl250hz = new Tools.Slider.SliderTrackBar();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.sl500hz = new Tools.Slider.SliderTrackBar();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.sl1khz = new Tools.Slider.SliderTrackBar();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.sl2_5khz = new Tools.Slider.SliderTrackBar();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.sl5khz = new Tools.Slider.SliderTrackBar();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.sl8khz = new Tools.Slider.SliderTrackBar();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.sl12khz = new Tools.Slider.SliderTrackBar();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.sl15khz = new Tools.Slider.SliderTrackBar();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.eqButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.playTime = new System.Windows.Forms.Label();
            this.trackTime = new System.Windows.Forms.Label();
            this.pauseButton = new MaterialSkin.Controls.MaterialLabel();
            this.eqTextSwitch = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // slTime
            // 
            this.slTime.BackColor = System.Drawing.Color.Transparent;
            this.slTime.EmptyTrackColor = System.Drawing.Color.DimGray;
            this.slTime.ForeColor = System.Drawing.SystemColors.Control;
            this.slTime.Location = new System.Drawing.Point(9, 144);
            this.slTime.Name = "slTime";
            this.slTime.ScaleFieldMaxHeight = 5;
            this.slTime.ScaleType = Tools.Slider.SliderTrackBar.SliderTrackBarScaleType.None;
            this.slTime.Size = new System.Drawing.Size(347, 14);
            this.slTime.SliderButtonSize = new System.Drawing.Size(10, 10);
            this.slTime.SmallChange = 1;
            this.slTime.TabIndex = 2;
            this.slTime.TickHeight = 5;
            this.slTime.TrackLowerColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(80)))), ((int)(((byte)(113)))));
            this.slTime.Scroll += new Tools.Slider.SliderTrackBar.ScrollDelegate(this.slTime_Scroll);
            // 
            // playList
            // 
            this.playList.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.playList.FormattingEnabled = true;
            this.playList.Location = new System.Drawing.Point(12, 12);
            this.playList.Name = "playList";
            this.playList.Size = new System.Drawing.Size(344, 121);
            this.playList.TabIndex = 3;
            this.playList.DoubleClick += new System.EventHandler(this.playButton_Click);
            // 
            // slVol
            // 
            this.slVol.BackColor = System.Drawing.Color.Transparent;
            this.slVol.EmptyTrackColor = System.Drawing.Color.DimGray;
            this.slVol.ForeColor = System.Drawing.SystemColors.Control;
            this.slVol.Location = new System.Drawing.Point(117, 161);
            this.slVol.Name = "slVol";
            this.slVol.ScaleFieldMaxHeight = 5;
            this.slVol.ScaleType = Tools.Slider.SliderTrackBar.SliderTrackBarScaleType.None;
            this.slVol.Size = new System.Drawing.Size(202, 28);
            this.slVol.SliderButtonSize = new System.Drawing.Size(10, 10);
            this.slVol.SmallChange = 1;
            this.slVol.TabIndex = 2;
            this.slVol.TickHeight = 5;
            this.slVol.TrackLowerColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(80)))), ((int)(((byte)(113)))));
            this.slVol.Value = 100;
            this.slVol.Scroll += new Tools.Slider.SliderTrackBar.ScrollDelegate(this.slVol_Scroll);
            // 
            // playButton
            // 
            this.playButton.AutoSize = true;
            this.playButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.playButton.Depth = 0;
            this.playButton.Icon = null;
            this.playButton.Location = new System.Drawing.Point(12, 157);
            this.playButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.playButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.playButton.Name = "playButton";
            this.playButton.Primary = false;
            this.playButton.Size = new System.Drawing.Size(30, 36);
            this.playButton.TabIndex = 4;
            this.playButton.Text = "P";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.AutoSize = true;
            this.stopButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.stopButton.Depth = 0;
            this.stopButton.Icon = null;
            this.stopButton.Location = new System.Drawing.Point(75, 157);
            this.stopButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.stopButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.stopButton.Name = "stopButton";
            this.stopButton.Primary = false;
            this.stopButton.Size = new System.Drawing.Size(29, 36);
            this.stopButton.TabIndex = 4;
            this.stopButton.Text = "S";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // importButton
            // 
            this.importButton.AutoSize = true;
            this.importButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.importButton.Depth = 0;
            this.importButton.Icon = null;
            this.importButton.Location = new System.Drawing.Point(327, 157);
            this.importButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.importButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.importButton.Name = "importButton";
            this.importButton.Primary = false;
            this.importButton.Size = new System.Drawing.Size(25, 36);
            this.importButton.TabIndex = 4;
            this.importButton.Text = "I";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // sl50hz
            // 
            this.sl50hz.BackColor = System.Drawing.Color.Transparent;
            this.sl50hz.EmptyTrackColor = System.Drawing.Color.DimGray;
            this.sl50hz.ForeColor = System.Drawing.SystemColors.Control;
            this.sl50hz.Location = new System.Drawing.Point(385, 12);
            this.sl50hz.Maximum = 20;
            this.sl50hz.Name = "sl50hz";
            this.sl50hz.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.sl50hz.ScaleFieldMaxHeight = 5;
            this.sl50hz.ScaleType = Tools.Slider.SliderTrackBar.SliderTrackBarScaleType.None;
            this.sl50hz.Size = new System.Drawing.Size(27, 147);
            this.sl50hz.SliderButtonSize = new System.Drawing.Size(10, 10);
            this.sl50hz.SmallChange = 1;
            this.sl50hz.TabIndex = 2;
            this.sl50hz.TickHeight = 5;
            this.sl50hz.TrackLowerColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(80)))), ((int)(((byte)(113)))));
            this.sl50hz.Value = 10;
            this.sl50hz.Scroll += new Tools.Slider.SliderTrackBar.ScrollDelegate(this.sl50hz_Scroll);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(386, 165);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(25, 19);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "50";
            // 
            // sl100hz
            // 
            this.sl100hz.BackColor = System.Drawing.Color.Transparent;
            this.sl100hz.EmptyTrackColor = System.Drawing.Color.DimGray;
            this.sl100hz.ForeColor = System.Drawing.SystemColors.Control;
            this.sl100hz.Location = new System.Drawing.Point(420, 12);
            this.sl100hz.Maximum = 20;
            this.sl100hz.Name = "sl100hz";
            this.sl100hz.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.sl100hz.ScaleFieldMaxHeight = 5;
            this.sl100hz.ScaleType = Tools.Slider.SliderTrackBar.SliderTrackBarScaleType.None;
            this.sl100hz.Size = new System.Drawing.Size(27, 147);
            this.sl100hz.SliderButtonSize = new System.Drawing.Size(10, 10);
            this.sl100hz.SmallChange = 1;
            this.sl100hz.TabIndex = 2;
            this.sl100hz.TickHeight = 5;
            this.sl100hz.TrackLowerColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(80)))), ((int)(((byte)(113)))));
            this.sl100hz.Value = 10;
            this.sl100hz.Scroll += new Tools.Slider.SliderTrackBar.ScrollDelegate(this.sl100hz_Scroll);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(417, 165);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(33, 19);
            this.materialLabel3.TabIndex = 5;
            this.materialLabel3.Text = "100";
            this.materialLabel3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // sl250hz
            // 
            this.sl250hz.BackColor = System.Drawing.Color.Transparent;
            this.sl250hz.EmptyTrackColor = System.Drawing.Color.DimGray;
            this.sl250hz.ForeColor = System.Drawing.SystemColors.Control;
            this.sl250hz.Location = new System.Drawing.Point(453, 12);
            this.sl250hz.Maximum = 20;
            this.sl250hz.Name = "sl250hz";
            this.sl250hz.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.sl250hz.ScaleFieldMaxHeight = 5;
            this.sl250hz.ScaleType = Tools.Slider.SliderTrackBar.SliderTrackBarScaleType.None;
            this.sl250hz.Size = new System.Drawing.Size(27, 147);
            this.sl250hz.SliderButtonSize = new System.Drawing.Size(10, 10);
            this.sl250hz.SmallChange = 1;
            this.sl250hz.TabIndex = 2;
            this.sl250hz.TickHeight = 5;
            this.sl250hz.TrackLowerColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(80)))), ((int)(((byte)(113)))));
            this.sl250hz.Value = 10;
            this.sl250hz.Scroll += new Tools.Slider.SliderTrackBar.ScrollDelegate(this.sl250hz_Scroll);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(450, 165);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(33, 19);
            this.materialLabel4.TabIndex = 5;
            this.materialLabel4.Text = "250";
            this.materialLabel4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // sl500hz
            // 
            this.sl500hz.BackColor = System.Drawing.Color.Transparent;
            this.sl500hz.EmptyTrackColor = System.Drawing.Color.DimGray;
            this.sl500hz.ForeColor = System.Drawing.SystemColors.Control;
            this.sl500hz.Location = new System.Drawing.Point(486, 12);
            this.sl500hz.Maximum = 20;
            this.sl500hz.Name = "sl500hz";
            this.sl500hz.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.sl500hz.ScaleFieldMaxHeight = 5;
            this.sl500hz.ScaleType = Tools.Slider.SliderTrackBar.SliderTrackBarScaleType.None;
            this.sl500hz.Size = new System.Drawing.Size(27, 147);
            this.sl500hz.SliderButtonSize = new System.Drawing.Size(10, 10);
            this.sl500hz.SmallChange = 1;
            this.sl500hz.TabIndex = 2;
            this.sl500hz.TickHeight = 5;
            this.sl500hz.TrackLowerColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(80)))), ((int)(((byte)(113)))));
            this.sl500hz.Value = 10;
            this.sl500hz.Scroll += new Tools.Slider.SliderTrackBar.ScrollDelegate(this.sl500hz_Scroll);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(483, 165);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(33, 19);
            this.materialLabel5.TabIndex = 5;
            this.materialLabel5.Text = "500";
            this.materialLabel5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // sl1khz
            // 
            this.sl1khz.BackColor = System.Drawing.Color.Transparent;
            this.sl1khz.EmptyTrackColor = System.Drawing.Color.DimGray;
            this.sl1khz.ForeColor = System.Drawing.SystemColors.Control;
            this.sl1khz.Location = new System.Drawing.Point(519, 12);
            this.sl1khz.Maximum = 20;
            this.sl1khz.Name = "sl1khz";
            this.sl1khz.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.sl1khz.ScaleFieldMaxHeight = 5;
            this.sl1khz.ScaleType = Tools.Slider.SliderTrackBar.SliderTrackBarScaleType.None;
            this.sl1khz.Size = new System.Drawing.Size(27, 147);
            this.sl1khz.SliderButtonSize = new System.Drawing.Size(10, 10);
            this.sl1khz.SmallChange = 1;
            this.sl1khz.TabIndex = 2;
            this.sl1khz.TickHeight = 5;
            this.sl1khz.TrackLowerColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(80)))), ((int)(((byte)(113)))));
            this.sl1khz.Value = 10;
            this.sl1khz.Scroll += new Tools.Slider.SliderTrackBar.ScrollDelegate(this.sl1khz_Scroll);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(521, 165);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(25, 19);
            this.materialLabel6.TabIndex = 5;
            this.materialLabel6.Text = "1k";
            this.materialLabel6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // sl2_5khz
            // 
            this.sl2_5khz.BackColor = System.Drawing.Color.Transparent;
            this.sl2_5khz.EmptyTrackColor = System.Drawing.Color.DimGray;
            this.sl2_5khz.ForeColor = System.Drawing.SystemColors.Control;
            this.sl2_5khz.Location = new System.Drawing.Point(552, 12);
            this.sl2_5khz.Maximum = 20;
            this.sl2_5khz.Name = "sl2_5khz";
            this.sl2_5khz.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.sl2_5khz.ScaleFieldMaxHeight = 5;
            this.sl2_5khz.ScaleType = Tools.Slider.SliderTrackBar.SliderTrackBarScaleType.None;
            this.sl2_5khz.Size = new System.Drawing.Size(27, 147);
            this.sl2_5khz.SliderButtonSize = new System.Drawing.Size(10, 10);
            this.sl2_5khz.SmallChange = 1;
            this.sl2_5khz.TabIndex = 2;
            this.sl2_5khz.TickHeight = 5;
            this.sl2_5khz.TrackLowerColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(80)))), ((int)(((byte)(113)))));
            this.sl2_5khz.Value = 10;
            this.sl2_5khz.Scroll += new Tools.Slider.SliderTrackBar.ScrollDelegate(this.sl2_5khz_Scroll);
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(548, 165);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(37, 19);
            this.materialLabel7.TabIndex = 5;
            this.materialLabel7.Text = "2.5k";
            this.materialLabel7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // sl5khz
            // 
            this.sl5khz.BackColor = System.Drawing.Color.Transparent;
            this.sl5khz.EmptyTrackColor = System.Drawing.Color.DimGray;
            this.sl5khz.ForeColor = System.Drawing.SystemColors.Control;
            this.sl5khz.Location = new System.Drawing.Point(585, 12);
            this.sl5khz.Maximum = 20;
            this.sl5khz.Name = "sl5khz";
            this.sl5khz.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.sl5khz.ScaleFieldMaxHeight = 5;
            this.sl5khz.ScaleType = Tools.Slider.SliderTrackBar.SliderTrackBarScaleType.None;
            this.sl5khz.Size = new System.Drawing.Size(27, 147);
            this.sl5khz.SliderButtonSize = new System.Drawing.Size(10, 10);
            this.sl5khz.SmallChange = 1;
            this.sl5khz.TabIndex = 2;
            this.sl5khz.TickHeight = 5;
            this.sl5khz.TrackLowerColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(80)))), ((int)(((byte)(113)))));
            this.sl5khz.Value = 10;
            this.sl5khz.Scroll += new Tools.Slider.SliderTrackBar.ScrollDelegate(this.sl5khz_Scroll);
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(586, 165);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(25, 19);
            this.materialLabel8.TabIndex = 5;
            this.materialLabel8.Text = "5k";
            this.materialLabel8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // sl8khz
            // 
            this.sl8khz.BackColor = System.Drawing.Color.Transparent;
            this.sl8khz.EmptyTrackColor = System.Drawing.Color.DimGray;
            this.sl8khz.ForeColor = System.Drawing.SystemColors.Control;
            this.sl8khz.Location = new System.Drawing.Point(618, 12);
            this.sl8khz.Maximum = 20;
            this.sl8khz.Name = "sl8khz";
            this.sl8khz.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.sl8khz.ScaleFieldMaxHeight = 5;
            this.sl8khz.ScaleType = Tools.Slider.SliderTrackBar.SliderTrackBarScaleType.None;
            this.sl8khz.Size = new System.Drawing.Size(27, 147);
            this.sl8khz.SliderButtonSize = new System.Drawing.Size(10, 10);
            this.sl8khz.SmallChange = 1;
            this.sl8khz.TabIndex = 2;
            this.sl8khz.TickHeight = 5;
            this.sl8khz.TrackLowerColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(80)))), ((int)(((byte)(113)))));
            this.sl8khz.Value = 10;
            this.sl8khz.Scroll += new Tools.Slider.SliderTrackBar.ScrollDelegate(this.sl8khz_Scroll);
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(618, 165);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(25, 19);
            this.materialLabel9.TabIndex = 5;
            this.materialLabel9.Text = "8k";
            this.materialLabel9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // sl12khz
            // 
            this.sl12khz.BackColor = System.Drawing.Color.Transparent;
            this.sl12khz.EmptyTrackColor = System.Drawing.Color.DimGray;
            this.sl12khz.ForeColor = System.Drawing.SystemColors.Control;
            this.sl12khz.Location = new System.Drawing.Point(651, 12);
            this.sl12khz.Maximum = 20;
            this.sl12khz.Name = "sl12khz";
            this.sl12khz.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.sl12khz.ScaleFieldMaxHeight = 5;
            this.sl12khz.ScaleType = Tools.Slider.SliderTrackBar.SliderTrackBarScaleType.None;
            this.sl12khz.Size = new System.Drawing.Size(27, 147);
            this.sl12khz.SliderButtonSize = new System.Drawing.Size(10, 10);
            this.sl12khz.SmallChange = 1;
            this.sl12khz.TabIndex = 2;
            this.sl12khz.TickHeight = 5;
            this.sl12khz.TrackLowerColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(80)))), ((int)(((byte)(113)))));
            this.sl12khz.Value = 10;
            this.sl12khz.Scroll += new Tools.Slider.SliderTrackBar.ScrollDelegate(this.sl12khz_Scroll);
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(649, 165);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(33, 19);
            this.materialLabel10.TabIndex = 5;
            this.materialLabel10.Text = "12k";
            this.materialLabel10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // sl15khz
            // 
            this.sl15khz.BackColor = System.Drawing.Color.Transparent;
            this.sl15khz.EmptyTrackColor = System.Drawing.Color.DimGray;
            this.sl15khz.ForeColor = System.Drawing.SystemColors.Control;
            this.sl15khz.Location = new System.Drawing.Point(684, 12);
            this.sl15khz.Maximum = 20;
            this.sl15khz.Name = "sl15khz";
            this.sl15khz.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.sl15khz.ScaleFieldMaxHeight = 5;
            this.sl15khz.ScaleType = Tools.Slider.SliderTrackBar.SliderTrackBarScaleType.None;
            this.sl15khz.Size = new System.Drawing.Size(27, 147);
            this.sl15khz.SliderButtonSize = new System.Drawing.Size(10, 10);
            this.sl15khz.SmallChange = 1;
            this.sl15khz.TabIndex = 2;
            this.sl15khz.TickHeight = 5;
            this.sl15khz.TrackLowerColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(80)))), ((int)(((byte)(113)))));
            this.sl15khz.Value = 10;
            this.sl15khz.Scroll += new Tools.Slider.SliderTrackBar.ScrollDelegate(this.sl15khz_Scroll);
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(682, 165);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(33, 19);
            this.materialLabel11.TabIndex = 5;
            this.materialLabel11.Text = "15k";
            this.materialLabel11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // eqButton
            // 
            this.eqButton.AutoSize = true;
            this.eqButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.eqButton.Depth = 0;
            this.eqButton.Icon = null;
            this.eqButton.Location = new System.Drawing.Point(357, 3);
            this.eqButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.eqButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.eqButton.Name = "eqButton";
            this.eqButton.Primary = false;
            this.eqButton.Size = new System.Drawing.Size(38, 36);
            this.eqButton.TabIndex = 6;
            this.eqButton.Text = "EQ";
            this.eqButton.UseVisualStyleBackColor = true;
            this.eqButton.Click += new System.EventHandler(this.eqButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::EqPlayer.Properties.Resources.grid1;
            this.pictureBox1.Location = new System.Drawing.Point(718, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 150);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(744, 147);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(49, 19);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "-10 db";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel13.Location = new System.Drawing.Point(752, 113);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(41, 19);
            this.materialLabel13.TabIndex = 5;
            this.materialLabel13.Text = "-5 db";
            this.materialLabel13.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel14.Location = new System.Drawing.Point(756, 79);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(37, 19);
            this.materialLabel14.TabIndex = 5;
            this.materialLabel14.Text = "0 db";
            this.materialLabel14.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // materialLabel15
            // 
            this.materialLabel15.AutoSize = true;
            this.materialLabel15.Depth = 0;
            this.materialLabel15.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel15.Location = new System.Drawing.Point(756, 43);
            this.materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel15.Name = "materialLabel15";
            this.materialLabel15.Size = new System.Drawing.Size(37, 19);
            this.materialLabel15.TabIndex = 5;
            this.materialLabel15.Text = "5 db";
            this.materialLabel15.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // materialLabel16
            // 
            this.materialLabel16.AutoSize = true;
            this.materialLabel16.Depth = 0;
            this.materialLabel16.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel16.Location = new System.Drawing.Point(748, 7);
            this.materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel16.Name = "materialLabel16";
            this.materialLabel16.Size = new System.Drawing.Size(45, 19);
            this.materialLabel16.TabIndex = 5;
            this.materialLabel16.Text = "10 db";
            this.materialLabel16.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // playTime
            // 
            this.playTime.AutoSize = true;
            this.playTime.Location = new System.Drawing.Point(10, 134);
            this.playTime.Name = "playTime";
            this.playTime.Size = new System.Drawing.Size(49, 13);
            this.playTime.TabIndex = 8;
            this.playTime.Text = "00:00:00";
            // 
            // trackTime
            // 
            this.trackTime.AutoSize = true;
            this.trackTime.Location = new System.Drawing.Point(306, 134);
            this.trackTime.Name = "trackTime";
            this.trackTime.Size = new System.Drawing.Size(49, 13);
            this.trackTime.TabIndex = 9;
            this.trackTime.Text = "00:00:00";
            // 
            // pauseButton
            // 
            this.pauseButton.AutoSize = true;
            this.pauseButton.Depth = 0;
            this.pauseButton.Font = new System.Drawing.Font("Roboto", 11F);
            this.pauseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pauseButton.Location = new System.Drawing.Point(49, 165);
            this.pauseButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(19, 19);
            this.pauseButton.TabIndex = 10;
            this.pauseButton.Text = "U";
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // eqTextSwitch
            // 
            this.eqTextSwitch.AutoSize = true;
            this.eqTextSwitch.Depth = 0;
            this.eqTextSwitch.Font = new System.Drawing.Font("Roboto", 11F);
            this.eqTextSwitch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.eqTextSwitch.Location = new System.Drawing.Point(359, 43);
            this.eqTextSwitch.MouseState = MaterialSkin.MouseState.HOVER;
            this.eqTextSwitch.Name = "eqTextSwitch";
            this.eqTextSwitch.Size = new System.Drawing.Size(35, 19);
            this.eqTextSwitch.TabIndex = 11;
            this.eqTextSwitch.Text = "OFF";
            // 
            // MainWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(809, 190);
            this.Controls.Add(this.eqTextSwitch);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.trackTime);
            this.Controls.Add(this.playTime);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.eqButton);
            this.Controls.Add(this.materialLabel11);
            this.Controls.Add(this.materialLabel10);
            this.Controls.Add(this.materialLabel9);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel16);
            this.Controls.Add(this.materialLabel15);
            this.Controls.Add(this.materialLabel14);
            this.Controls.Add(this.materialLabel13);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.playList);
            this.Controls.Add(this.sl15khz);
            this.Controls.Add(this.sl12khz);
            this.Controls.Add(this.sl8khz);
            this.Controls.Add(this.sl5khz);
            this.Controls.Add(this.sl2_5khz);
            this.Controls.Add(this.sl1khz);
            this.Controls.Add(this.sl500hz);
            this.Controls.Add(this.sl250hz);
            this.Controls.Add(this.sl100hz);
            this.Controls.Add(this.sl50hz);
            this.Controls.Add(this.slVol);
            this.Controls.Add(this.slTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.Text = "EqPlayer";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Tools.Slider.SliderTrackBar slTime;
        private System.Windows.Forms.ListBox playList;
        private Tools.Slider.SliderTrackBar slVol;
        private MaterialSkin.Controls.MaterialFlatButton playButton;
        private MaterialSkin.Controls.MaterialFlatButton stopButton;
        private MaterialSkin.Controls.MaterialFlatButton importButton;
        private Tools.Slider.SliderTrackBar sl50hz;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private Tools.Slider.SliderTrackBar sl100hz;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private Tools.Slider.SliderTrackBar sl250hz;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private Tools.Slider.SliderTrackBar sl500hz;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private Tools.Slider.SliderTrackBar sl1khz;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private Tools.Slider.SliderTrackBar sl2_5khz;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private Tools.Slider.SliderTrackBar sl5khz;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private Tools.Slider.SliderTrackBar sl8khz;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private Tools.Slider.SliderTrackBar sl12khz;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private Tools.Slider.SliderTrackBar sl15khz;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialFlatButton eqButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private MaterialSkin.Controls.MaterialLabel materialLabel15;
        private MaterialSkin.Controls.MaterialLabel materialLabel16;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label playTime;
        private System.Windows.Forms.Label trackTime;
        private MaterialSkin.Controls.MaterialLabel pauseButton;
        private MaterialSkin.Controls.MaterialLabel eqTextSwitch;
    }
}

