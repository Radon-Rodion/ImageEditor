
namespace SPP_2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.picture = new System.Windows.Forms.PictureBox();
            this.skyBtn = new System.Windows.Forms.Button();
            this.limeBtn = new System.Windows.Forms.Button();
            this.greenBtn = new System.Windows.Forms.Button();
            this.orangeBtn = new System.Windows.Forms.Button();
            this.yellowBtn = new System.Windows.Forms.Button();
            this.blueBtn = new System.Windows.Forms.Button();
            this.purpleBtn = new System.Windows.Forms.Button();
            this.pinkBtn = new System.Windows.Forms.Button();
            this.vineBtn = new System.Windows.Forms.Button();
            this.redBtn = new System.Windows.Forms.Button();
            this.blackBtn = new System.Windows.Forms.Button();
            this.dgreyBtn = new System.Windows.Forms.Button();
            this.greyBtn = new System.Windows.Forms.Button();
            this.lgreyBtn = new System.Windows.Forms.Button();
            this.whiteBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.penColor = new System.Windows.Forms.Button();
            this.brushColor = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.penBtn = new System.Windows.Forms.Button();
            this.resizeBtn = new System.Windows.Forms.Button();
            this.reflectVertBtn = new System.Windows.Forms.Button();
            this.reflectHorBtn = new System.Windows.Forms.Button();
            this.rotateBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.scaleBtn = new System.Windows.Forms.Button();
            this.contrastTrack = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.brightnessTrack = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.chromaticityTrack = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lineWidthTrack = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.lineWidthBox = new System.Windows.Forms.TextBox();
            this.chromaticityBox = new System.Windows.Forms.TextBox();
            this.brightnessBox = new System.Windows.Forms.TextBox();
            this.contrastBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.instrumentsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contrastTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chromaticityTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineWidthTrack)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.instrumentsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(861, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            this.manualToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.manualToolStripMenuItem.Text = "Manual";
            this.manualToolStripMenuItem.Click += new System.EventHandler(this.manualToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.Color.White;
            this.picture.ImageLocation = "";
            this.picture.Location = new System.Drawing.Point(0, 0);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(590, 400);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            this.picture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picture_MouseDown);
            this.picture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picture_MouseMove);
            this.picture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picture_MouseUp);
            // 
            // skyBtn
            // 
            this.skyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.skyBtn.Location = new System.Drawing.Point(187, 95);
            this.skyBtn.Name = "skyBtn";
            this.skyBtn.Size = new System.Drawing.Size(40, 40);
            this.skyBtn.TabIndex = 22;
            this.skyBtn.UseVisualStyleBackColor = false;
            this.skyBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.skyBtn_MouseClick);
            // 
            // limeBtn
            // 
            this.limeBtn.BackColor = System.Drawing.Color.Lime;
            this.limeBtn.Location = new System.Drawing.Point(141, 95);
            this.limeBtn.Name = "limeBtn";
            this.limeBtn.Size = new System.Drawing.Size(40, 40);
            this.limeBtn.TabIndex = 19;
            this.limeBtn.UseVisualStyleBackColor = false;
            this.limeBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.limeBtn_MouseClick);
            // 
            // greenBtn
            // 
            this.greenBtn.BackColor = System.Drawing.Color.Green;
            this.greenBtn.Location = new System.Drawing.Point(95, 95);
            this.greenBtn.Name = "greenBtn";
            this.greenBtn.Size = new System.Drawing.Size(40, 40);
            this.greenBtn.TabIndex = 29;
            this.greenBtn.UseVisualStyleBackColor = false;
            this.greenBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.greenBtn_MouseClick);
            // 
            // orangeBtn
            // 
            this.orangeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.orangeBtn.Location = new System.Drawing.Point(49, 95);
            this.orangeBtn.Name = "orangeBtn";
            this.orangeBtn.Size = new System.Drawing.Size(40, 40);
            this.orangeBtn.TabIndex = 18;
            this.orangeBtn.UseVisualStyleBackColor = false;
            this.orangeBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.orangeBtn_MouseClick);
            // 
            // yellowBtn
            // 
            this.yellowBtn.BackColor = System.Drawing.Color.Yellow;
            this.yellowBtn.Location = new System.Drawing.Point(3, 95);
            this.yellowBtn.Name = "yellowBtn";
            this.yellowBtn.Size = new System.Drawing.Size(40, 40);
            this.yellowBtn.TabIndex = 21;
            this.yellowBtn.UseVisualStyleBackColor = false;
            this.yellowBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.yellowBtn_MouseClick);
            // 
            // blueBtn
            // 
            this.blueBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.blueBtn.Location = new System.Drawing.Point(187, 49);
            this.blueBtn.Name = "blueBtn";
            this.blueBtn.Size = new System.Drawing.Size(40, 40);
            this.blueBtn.TabIndex = 28;
            this.blueBtn.UseVisualStyleBackColor = false;
            this.blueBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.blueBtn_MouseClick);
            // 
            // purpleBtn
            // 
            this.purpleBtn.BackColor = System.Drawing.Color.Purple;
            this.purpleBtn.Location = new System.Drawing.Point(141, 49);
            this.purpleBtn.Name = "purpleBtn";
            this.purpleBtn.Size = new System.Drawing.Size(40, 40);
            this.purpleBtn.TabIndex = 25;
            this.purpleBtn.UseVisualStyleBackColor = false;
            this.purpleBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.purpleBtn_MouseClick);
            // 
            // pinkBtn
            // 
            this.pinkBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pinkBtn.Location = new System.Drawing.Point(95, 49);
            this.pinkBtn.Name = "pinkBtn";
            this.pinkBtn.Size = new System.Drawing.Size(40, 40);
            this.pinkBtn.TabIndex = 26;
            this.pinkBtn.UseVisualStyleBackColor = false;
            this.pinkBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pinkBtn_MouseClick);
            // 
            // vineBtn
            // 
            this.vineBtn.BackColor = System.Drawing.Color.Maroon;
            this.vineBtn.Location = new System.Drawing.Point(49, 49);
            this.vineBtn.Name = "vineBtn";
            this.vineBtn.Size = new System.Drawing.Size(40, 40);
            this.vineBtn.TabIndex = 27;
            this.vineBtn.UseVisualStyleBackColor = false;
            this.vineBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.vineBtn_MouseClick);
            // 
            // redBtn
            // 
            this.redBtn.BackColor = System.Drawing.Color.Red;
            this.redBtn.Location = new System.Drawing.Point(3, 49);
            this.redBtn.Name = "redBtn";
            this.redBtn.Size = new System.Drawing.Size(40, 40);
            this.redBtn.TabIndex = 20;
            this.redBtn.UseVisualStyleBackColor = false;
            this.redBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.redBtn_MouseClick);
            // 
            // blackBtn
            // 
            this.blackBtn.BackColor = System.Drawing.Color.Black;
            this.blackBtn.Location = new System.Drawing.Point(187, 3);
            this.blackBtn.Name = "blackBtn";
            this.blackBtn.Size = new System.Drawing.Size(40, 40);
            this.blackBtn.TabIndex = 23;
            this.blackBtn.UseVisualStyleBackColor = false;
            this.blackBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.blackBtn_MouseClick);
            // 
            // dgreyBtn
            // 
            this.dgreyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgreyBtn.Location = new System.Drawing.Point(141, 3);
            this.dgreyBtn.Name = "dgreyBtn";
            this.dgreyBtn.Size = new System.Drawing.Size(40, 40);
            this.dgreyBtn.TabIndex = 24;
            this.dgreyBtn.UseVisualStyleBackColor = false;
            this.dgreyBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgreyBtn_MouseClick);
            // 
            // greyBtn
            // 
            this.greyBtn.BackColor = System.Drawing.Color.Gray;
            this.greyBtn.Location = new System.Drawing.Point(95, 3);
            this.greyBtn.Name = "greyBtn";
            this.greyBtn.Size = new System.Drawing.Size(40, 40);
            this.greyBtn.TabIndex = 16;
            this.greyBtn.UseVisualStyleBackColor = false;
            this.greyBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.greyBtn_MouseClick);
            // 
            // lgreyBtn
            // 
            this.lgreyBtn.BackColor = System.Drawing.Color.Silver;
            this.lgreyBtn.Location = new System.Drawing.Point(49, 3);
            this.lgreyBtn.Name = "lgreyBtn";
            this.lgreyBtn.Size = new System.Drawing.Size(40, 40);
            this.lgreyBtn.TabIndex = 17;
            this.lgreyBtn.UseVisualStyleBackColor = false;
            this.lgreyBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lgreyBtn_MouseClick);
            // 
            // whiteBtn
            // 
            this.whiteBtn.BackColor = System.Drawing.Color.White;
            this.whiteBtn.Location = new System.Drawing.Point(3, 3);
            this.whiteBtn.Name = "whiteBtn";
            this.whiteBtn.Size = new System.Drawing.Size(40, 40);
            this.whiteBtn.TabIndex = 15;
            this.whiteBtn.UseVisualStyleBackColor = false;
            this.whiteBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.whiteBtn_MouseClick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Controls.Add(this.whiteBtn);
            this.flowLayoutPanel1.Controls.Add(this.lgreyBtn);
            this.flowLayoutPanel1.Controls.Add(this.greyBtn);
            this.flowLayoutPanel1.Controls.Add(this.dgreyBtn);
            this.flowLayoutPanel1.Controls.Add(this.blackBtn);
            this.flowLayoutPanel1.Controls.Add(this.redBtn);
            this.flowLayoutPanel1.Controls.Add(this.vineBtn);
            this.flowLayoutPanel1.Controls.Add(this.pinkBtn);
            this.flowLayoutPanel1.Controls.Add(this.purpleBtn);
            this.flowLayoutPanel1.Controls.Add(this.blueBtn);
            this.flowLayoutPanel1.Controls.Add(this.yellowBtn);
            this.flowLayoutPanel1.Controls.Add(this.orangeBtn);
            this.flowLayoutPanel1.Controls.Add(this.greenBtn);
            this.flowLayoutPanel1.Controls.Add(this.limeBtn);
            this.flowLayoutPanel1.Controls.Add(this.skyBtn);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.MaximumSize = new System.Drawing.Size(234, 162);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(234, 145);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.penColor, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.brushColor, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 61);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(112, 66);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 26);
            this.label6.TabIndex = 6;
            this.label6.Text = "Brush Color";
            // 
            // penColor
            // 
            this.penColor.BackColor = System.Drawing.Color.Black;
            this.penColor.Location = new System.Drawing.Point(3, 3);
            this.penColor.Name = "penColor";
            this.penColor.Size = new System.Drawing.Size(50, 27);
            this.penColor.TabIndex = 4;
            this.penColor.UseVisualStyleBackColor = false;
            this.penColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.penColor_MouseClick);
            // 
            // brushColor
            // 
            this.brushColor.BackColor = System.Drawing.Color.White;
            this.brushColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.brushColor.Location = new System.Drawing.Point(59, 3);
            this.brushColor.Name = "brushColor";
            this.brushColor.Size = new System.Drawing.Size(50, 27);
            this.brushColor.TabIndex = 0;
            this.brushColor.UseVisualStyleBackColor = false;
            this.brushColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.brushColor_MouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 26);
            this.label5.TabIndex = 5;
            this.label5.Text = "Pen Color";
            // 
            // penBtn
            // 
            this.penBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.penBtn.Location = new System.Drawing.Point(155, 32);
            this.penBtn.Name = "penBtn";
            this.penBtn.Size = new System.Drawing.Size(70, 23);
            this.penBtn.TabIndex = 4;
            this.penBtn.Text = "Pen Draw";
            this.penBtn.UseVisualStyleBackColor = false;
            this.penBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.penBtn_MouseClick);
            // 
            // resizeBtn
            // 
            this.resizeBtn.Location = new System.Drawing.Point(3, 32);
            this.resizeBtn.Name = "resizeBtn";
            this.resizeBtn.Size = new System.Drawing.Size(70, 23);
            this.resizeBtn.TabIndex = 3;
            this.resizeBtn.Text = "Resize";
            this.resizeBtn.UseVisualStyleBackColor = true;
            this.resizeBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.resizeBtn_MouseClick);
            // 
            // reflectVertBtn
            // 
            this.reflectVertBtn.Location = new System.Drawing.Point(155, 3);
            this.reflectVertBtn.Name = "reflectVertBtn";
            this.reflectVertBtn.Size = new System.Drawing.Size(70, 23);
            this.reflectVertBtn.TabIndex = 2;
            this.reflectVertBtn.Text = "Reflect Ver";
            this.reflectVertBtn.UseVisualStyleBackColor = true;
            this.reflectVertBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.reflectVertBtn_MouseClick);
            // 
            // reflectHorBtn
            // 
            this.reflectHorBtn.Location = new System.Drawing.Point(79, 3);
            this.reflectHorBtn.Name = "reflectHorBtn";
            this.reflectHorBtn.Size = new System.Drawing.Size(70, 23);
            this.reflectHorBtn.TabIndex = 1;
            this.reflectHorBtn.Text = "Reflect Hor";
            this.reflectHorBtn.UseVisualStyleBackColor = true;
            this.reflectHorBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.reflectHorBtn_MouseClick);
            // 
            // rotateBtn
            // 
            this.rotateBtn.Location = new System.Drawing.Point(3, 3);
            this.rotateBtn.Name = "rotateBtn";
            this.rotateBtn.Size = new System.Drawing.Size(70, 23);
            this.rotateBtn.TabIndex = 0;
            this.rotateBtn.Text = "Rotate";
            this.rotateBtn.UseVisualStyleBackColor = true;
            this.rotateBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rotateBtn_MouseClick);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel2.Controls.Add(this.rotateBtn);
            this.flowLayoutPanel2.Controls.Add(this.reflectHorBtn);
            this.flowLayoutPanel2.Controls.Add(this.reflectVertBtn);
            this.flowLayoutPanel2.Controls.Add(this.resizeBtn);
            this.flowLayoutPanel2.Controls.Add(this.scaleBtn);
            this.flowLayoutPanel2.Controls.Add(this.penBtn);
            this.flowLayoutPanel2.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 154);
            this.flowLayoutPanel2.MaximumSize = new System.Drawing.Size(234, 127);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(234, 127);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // scaleBtn
            // 
            this.scaleBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.scaleBtn.Location = new System.Drawing.Point(79, 32);
            this.scaleBtn.Name = "scaleBtn";
            this.scaleBtn.Size = new System.Drawing.Size(70, 23);
            this.scaleBtn.TabIndex = 6;
            this.scaleBtn.Text = "Scale";
            this.scaleBtn.UseVisualStyleBackColor = false;
            this.scaleBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.scaleBtn_MouseClick);
            // 
            // contrastTrack
            // 
            this.contrastTrack.LargeChange = 10;
            this.contrastTrack.Location = new System.Drawing.Point(6, 223);
            this.contrastTrack.Maximum = 127;
            this.contrastTrack.Minimum = -128;
            this.contrastTrack.Name = "contrastTrack";
            this.contrastTrack.Size = new System.Drawing.Size(216, 45);
            this.contrastTrack.SmallChange = 2;
            this.contrastTrack.TabIndex = 12;
            this.contrastTrack.ValueChanged += new System.EventHandler(this.contrastTrack_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Contrast";
            // 
            // brightnessTrack
            // 
            this.brightnessTrack.LargeChange = 10;
            this.brightnessTrack.Location = new System.Drawing.Point(6, 159);
            this.brightnessTrack.Maximum = 127;
            this.brightnessTrack.Minimum = -128;
            this.brightnessTrack.Name = "brightnessTrack";
            this.brightnessTrack.Size = new System.Drawing.Size(216, 45);
            this.brightnessTrack.SmallChange = 2;
            this.brightnessTrack.TabIndex = 10;
            this.brightnessTrack.ValueChanged += new System.EventHandler(this.brightnessTrack_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Brightness";
            // 
            // chromaticityTrack
            // 
            this.chromaticityTrack.LargeChange = 10;
            this.chromaticityTrack.Location = new System.Drawing.Point(6, 95);
            this.chromaticityTrack.Maximum = 127;
            this.chromaticityTrack.Minimum = -128;
            this.chromaticityTrack.Name = "chromaticityTrack";
            this.chromaticityTrack.Size = new System.Drawing.Size(216, 45);
            this.chromaticityTrack.SmallChange = 2;
            this.chromaticityTrack.TabIndex = 8;
            this.chromaticityTrack.ValueChanged += new System.EventHandler(this.chromaticityTrack_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Chromaticity";
            // 
            // lineWidthTrack
            // 
            this.lineWidthTrack.Location = new System.Drawing.Point(6, 31);
            this.lineWidthTrack.Minimum = 1;
            this.lineWidthTrack.Name = "lineWidthTrack";
            this.lineWidthTrack.Size = new System.Drawing.Size(216, 45);
            this.lineWidthTrack.TabIndex = 14;
            this.lineWidthTrack.Value = 1;
            this.lineWidthTrack.ValueChanged += new System.EventHandler(this.lineWidthTrack_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Line width";
            // 
            // lineWidthBox
            // 
            this.lineWidthBox.Location = new System.Drawing.Point(189, 12);
            this.lineWidthBox.Name = "lineWidthBox";
            this.lineWidthBox.Size = new System.Drawing.Size(33, 20);
            this.lineWidthBox.TabIndex = 16;
            this.lineWidthBox.Text = "1";
            this.lineWidthBox.TextChanged += new System.EventHandler(this.lineWidthBox_TextChanged);
            // 
            // chromaticityBox
            // 
            this.chromaticityBox.Location = new System.Drawing.Point(189, 76);
            this.chromaticityBox.Name = "chromaticityBox";
            this.chromaticityBox.Size = new System.Drawing.Size(33, 20);
            this.chromaticityBox.TabIndex = 17;
            this.chromaticityBox.Text = "0";
            this.chromaticityBox.TextChanged += new System.EventHandler(this.chromaticityBox_TextChanged);
            // 
            // brightnessBox
            // 
            this.brightnessBox.Location = new System.Drawing.Point(189, 140);
            this.brightnessBox.Name = "brightnessBox";
            this.brightnessBox.Size = new System.Drawing.Size(33, 20);
            this.brightnessBox.TabIndex = 18;
            this.brightnessBox.Text = "0";
            this.brightnessBox.TextChanged += new System.EventHandler(this.brightnessBox_TextChanged);
            // 
            // contrastBox
            // 
            this.contrastBox.Location = new System.Drawing.Point(189, 204);
            this.contrastBox.Name = "contrastBox";
            this.contrastBox.Size = new System.Drawing.Size(33, 20);
            this.contrastBox.TabIndex = 19;
            this.contrastBox.Text = "0";
            this.contrastBox.TextChanged += new System.EventHandler(this.contrastBox_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.contrastBox);
            this.groupBox1.Controls.Add(this.brightnessBox);
            this.groupBox1.Controls.Add(this.chromaticityBox);
            this.groupBox1.Controls.Add(this.lineWidthBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lineWidthTrack);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chromaticityTrack);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.brightnessTrack);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.contrastTrack);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(3, 287);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 287);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // instrumentsPanel
            // 
            this.instrumentsPanel.AutoScroll = true;
            this.instrumentsPanel.Controls.Add(this.flowLayoutPanel1);
            this.instrumentsPanel.Controls.Add(this.flowLayoutPanel2);
            this.instrumentsPanel.Controls.Add(this.groupBox1);
            this.instrumentsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.instrumentsPanel.Location = new System.Drawing.Point(0, 0);
            this.instrumentsPanel.Name = "instrumentsPanel";
            this.instrumentsPanel.Size = new System.Drawing.Size(260, 564);
            this.instrumentsPanel.TabIndex = 7;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.picture);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.instrumentsPanel);
            this.splitContainer1.Panel2MinSize = 200;
            this.splitContainer1.Size = new System.Drawing.Size(861, 564);
            this.splitContainer1.SplitterDistance = 597;
            this.splitContainer1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(861, 588);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "ImageEditor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contrastTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chromaticityTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineWidthTrack)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.instrumentsPanel.ResumeLayout(false);
            this.instrumentsPanel.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Button skyBtn;
        private System.Windows.Forms.Button limeBtn;
        private System.Windows.Forms.Button greenBtn;
        private System.Windows.Forms.Button orangeBtn;
        private System.Windows.Forms.Button yellowBtn;
        private System.Windows.Forms.Button blueBtn;
        private System.Windows.Forms.Button purpleBtn;
        private System.Windows.Forms.Button pinkBtn;
        private System.Windows.Forms.Button vineBtn;
        private System.Windows.Forms.Button redBtn;
        private System.Windows.Forms.Button blackBtn;
        private System.Windows.Forms.Button dgreyBtn;
        private System.Windows.Forms.Button greyBtn;
        private System.Windows.Forms.Button lgreyBtn;
        private System.Windows.Forms.Button whiteBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button penColor;
        private System.Windows.Forms.Button brushColor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button penBtn;
        private System.Windows.Forms.Button resizeBtn;
        private System.Windows.Forms.Button reflectVertBtn;
        private System.Windows.Forms.Button reflectHorBtn;
        private System.Windows.Forms.Button rotateBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TrackBar contrastTrack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar brightnessTrack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar chromaticityTrack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar lineWidthTrack;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lineWidthBox;
        private System.Windows.Forms.TextBox chromaticityBox;
        private System.Windows.Forms.TextBox brightnessBox;
        private System.Windows.Forms.TextBox contrastBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel instrumentsPanel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button scaleBtn;
    }
}

