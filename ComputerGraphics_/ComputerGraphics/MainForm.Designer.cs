namespace ComputerGraphics
{
    partial class MainForm
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.openButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.drawTimer = new System.Windows.Forms.Timer(this.components);
            this.parallelTransferButton = new System.Windows.Forms.Button();
            this.parallelTransferX = new System.Windows.Forms.TextBox();
            this.parallelTransferGroup = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.parallelTransferZ = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.parallelTransferY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.scaleGroup = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.scaleTextBox = new System.Windows.Forms.TextBox();
            this.scaleAxisRadioZ = new System.Windows.Forms.RadioButton();
            this.scaleAxisRadioY = new System.Windows.Forms.RadioButton();
            this.scaleAxisRadioX = new System.Windows.Forms.RadioButton();
            this.scaleButton = new System.Windows.Forms.Button();
            this.rotateGroup = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rotateTextBox = new System.Windows.Forms.TextBox();
            this.rotateAxisRadioZ = new System.Windows.Forms.RadioButton();
            this.rotateAxisRadioY = new System.Windows.Forms.RadioButton();
            this.rotateAxisRadioX = new System.Windows.Forms.RadioButton();
            this.rotateButton = new System.Windows.Forms.Button();
            this.obliqueShiftGroup = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.obliqueShiftAlongAxisZ = new System.Windows.Forms.RadioButton();
            this.obliqueShiftAlongAxisX = new System.Windows.Forms.RadioButton();
            this.obliqueShiftAlongAxisY = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.obliqueShiftFactor = new System.Windows.Forms.TextBox();
            this.obliqueShiftAxisZ = new System.Windows.Forms.RadioButton();
            this.obliqueShiftAxisY = new System.Windows.Forms.RadioButton();
            this.obliqueShiftAxisX = new System.Windows.Forms.RadioButton();
            this.obliqueShiftButton = new System.Windows.Forms.Button();
            this.oppGroup = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.oppTextBox = new System.Windows.Forms.TextBox();
            this.oppAxisRadioZ = new System.Windows.Forms.RadioButton();
            this.oppAxisRadioY = new System.Windows.Forms.RadioButton();
            this.oppAxisRadioX = new System.Windows.Forms.RadioButton();
            this.oppButton = new System.Windows.Forms.Button();
            this.fitIntoFrameButton = new System.Windows.Forms.Button();
            this.scaleAxisRadioAll = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.parallelTransferGroup.SuspendLayout();
            this.scaleGroup.SuspendLayout();
            this.rotateGroup.SuspendLayout();
            this.obliqueShiftGroup.SuspendLayout();
            this.panel1.SuspendLayout();
            this.oppGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(705, 702);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(838, 12);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(135, 23);
            this.openButton.TabIndex = 1;
            this.openButton.Text = "Открыть файл";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.OpenButtonClick);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Lines|*.txt";
            // 
            // drawTimer
            // 
            this.drawTimer.Interval = 20;
            this.drawTimer.Tick += new System.EventHandler(this.DrawTimerTick);
            // 
            // parallelTransferButton
            // 
            this.parallelTransferButton.Location = new System.Drawing.Point(6, 51);
            this.parallelTransferButton.Name = "parallelTransferButton";
            this.parallelTransferButton.Size = new System.Drawing.Size(97, 23);
            this.parallelTransferButton.TabIndex = 2;
            this.parallelTransferButton.Text = "Применить";
            this.parallelTransferButton.UseVisualStyleBackColor = true;
            this.parallelTransferButton.Click += new System.EventHandler(this.ParallelTransferButtonClick);
            // 
            // parallelTransferX
            // 
            this.parallelTransferX.Location = new System.Drawing.Point(29, 22);
            this.parallelTransferX.Name = "parallelTransferX";
            this.parallelTransferX.Size = new System.Drawing.Size(80, 23);
            this.parallelTransferX.TabIndex = 3;
            // 
            // parallelTransferGroup
            // 
            this.parallelTransferGroup.Controls.Add(this.label3);
            this.parallelTransferGroup.Controls.Add(this.parallelTransferButton);
            this.parallelTransferGroup.Controls.Add(this.parallelTransferZ);
            this.parallelTransferGroup.Controls.Add(this.label2);
            this.parallelTransferGroup.Controls.Add(this.parallelTransferY);
            this.parallelTransferGroup.Controls.Add(this.label1);
            this.parallelTransferGroup.Controls.Add(this.parallelTransferX);
            this.parallelTransferGroup.Location = new System.Drawing.Point(723, 52);
            this.parallelTransferGroup.Name = "parallelTransferGroup";
            this.parallelTransferGroup.Size = new System.Drawing.Size(352, 81);
            this.parallelTransferGroup.TabIndex = 4;
            this.parallelTransferGroup.TabStop = false;
            this.parallelTransferGroup.Text = "Параллельный перенос";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Z:";
            // 
            // parallelTransferZ
            // 
            this.parallelTransferZ.Location = new System.Drawing.Point(247, 22);
            this.parallelTransferZ.Name = "parallelTransferZ";
            this.parallelTransferZ.Size = new System.Drawing.Size(80, 23);
            this.parallelTransferZ.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y:";
            // 
            // parallelTransferY
            // 
            this.parallelTransferY.Location = new System.Drawing.Point(138, 22);
            this.parallelTransferY.Name = "parallelTransferY";
            this.parallelTransferY.Size = new System.Drawing.Size(80, 23);
            this.parallelTransferY.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "X:";
            // 
            // scaleGroup
            // 
            this.scaleGroup.Controls.Add(this.scaleAxisRadioAll);
            this.scaleGroup.Controls.Add(this.label6);
            this.scaleGroup.Controls.Add(this.label4);
            this.scaleGroup.Controls.Add(this.scaleTextBox);
            this.scaleGroup.Controls.Add(this.scaleAxisRadioZ);
            this.scaleGroup.Controls.Add(this.scaleAxisRadioY);
            this.scaleGroup.Controls.Add(this.scaleAxisRadioX);
            this.scaleGroup.Controls.Add(this.scaleButton);
            this.scaleGroup.Location = new System.Drawing.Point(723, 139);
            this.scaleGroup.Name = "scaleGroup";
            this.scaleGroup.Size = new System.Drawing.Size(352, 105);
            this.scaleGroup.TabIndex = 7;
            this.scaleGroup.TabStop = false;
            this.scaleGroup.Text = "Масштабирование";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ось:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Множитель:";
            // 
            // scaleTextBox
            // 
            this.scaleTextBox.Location = new System.Drawing.Point(247, 25);
            this.scaleTextBox.Name = "scaleTextBox";
            this.scaleTextBox.Size = new System.Drawing.Size(80, 23);
            this.scaleTextBox.TabIndex = 7;
            // 
            // scaleAxisRadioZ
            // 
            this.scaleAxisRadioZ.AutoSize = true;
            this.scaleAxisRadioZ.Location = new System.Drawing.Point(119, 26);
            this.scaleAxisRadioZ.Name = "scaleAxisRadioZ";
            this.scaleAxisRadioZ.Size = new System.Drawing.Size(32, 19);
            this.scaleAxisRadioZ.TabIndex = 5;
            this.scaleAxisRadioZ.TabStop = true;
            this.scaleAxisRadioZ.Text = "Z";
            this.scaleAxisRadioZ.UseVisualStyleBackColor = true;
            // 
            // scaleAxisRadioY
            // 
            this.scaleAxisRadioY.AutoSize = true;
            this.scaleAxisRadioY.Location = new System.Drawing.Point(81, 26);
            this.scaleAxisRadioY.Name = "scaleAxisRadioY";
            this.scaleAxisRadioY.Size = new System.Drawing.Size(32, 19);
            this.scaleAxisRadioY.TabIndex = 4;
            this.scaleAxisRadioY.TabStop = true;
            this.scaleAxisRadioY.Text = "Y";
            this.scaleAxisRadioY.UseVisualStyleBackColor = true;
            // 
            // scaleAxisRadioX
            // 
            this.scaleAxisRadioX.AutoSize = true;
            this.scaleAxisRadioX.Checked = true;
            this.scaleAxisRadioX.Location = new System.Drawing.Point(43, 26);
            this.scaleAxisRadioX.Name = "scaleAxisRadioX";
            this.scaleAxisRadioX.Size = new System.Drawing.Size(32, 19);
            this.scaleAxisRadioX.TabIndex = 3;
            this.scaleAxisRadioX.TabStop = true;
            this.scaleAxisRadioX.Text = "X";
            this.scaleAxisRadioX.UseVisualStyleBackColor = true;
            // 
            // scaleButton
            // 
            this.scaleButton.Location = new System.Drawing.Point(6, 76);
            this.scaleButton.Name = "scaleButton";
            this.scaleButton.Size = new System.Drawing.Size(97, 23);
            this.scaleButton.TabIndex = 2;
            this.scaleButton.Text = "Применить";
            this.scaleButton.UseVisualStyleBackColor = true;
            this.scaleButton.Click += new System.EventHandler(this.ScaleButtonClick);
            // 
            // rotateGroup
            // 
            this.rotateGroup.Controls.Add(this.label5);
            this.rotateGroup.Controls.Add(this.label7);
            this.rotateGroup.Controls.Add(this.rotateTextBox);
            this.rotateGroup.Controls.Add(this.rotateAxisRadioZ);
            this.rotateGroup.Controls.Add(this.rotateAxisRadioY);
            this.rotateGroup.Controls.Add(this.rotateAxisRadioX);
            this.rotateGroup.Controls.Add(this.rotateButton);
            this.rotateGroup.Location = new System.Drawing.Point(723, 250);
            this.rotateGroup.Name = "rotateGroup";
            this.rotateGroup.Size = new System.Drawing.Size(352, 81);
            this.rotateGroup.TabIndex = 11;
            this.rotateGroup.TabStop = false;
            this.rotateGroup.Text = "Поворот";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ось:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(205, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Угол:";
            // 
            // rotateTextBox
            // 
            this.rotateTextBox.Location = new System.Drawing.Point(247, 25);
            this.rotateTextBox.Name = "rotateTextBox";
            this.rotateTextBox.Size = new System.Drawing.Size(80, 23);
            this.rotateTextBox.TabIndex = 7;
            // 
            // rotateAxisRadioZ
            // 
            this.rotateAxisRadioZ.AutoSize = true;
            this.rotateAxisRadioZ.Location = new System.Drawing.Point(119, 26);
            this.rotateAxisRadioZ.Name = "rotateAxisRadioZ";
            this.rotateAxisRadioZ.Size = new System.Drawing.Size(32, 19);
            this.rotateAxisRadioZ.TabIndex = 5;
            this.rotateAxisRadioZ.TabStop = true;
            this.rotateAxisRadioZ.Text = "Z";
            this.rotateAxisRadioZ.UseVisualStyleBackColor = true;
            // 
            // rotateAxisRadioY
            // 
            this.rotateAxisRadioY.AutoSize = true;
            this.rotateAxisRadioY.Location = new System.Drawing.Point(81, 26);
            this.rotateAxisRadioY.Name = "rotateAxisRadioY";
            this.rotateAxisRadioY.Size = new System.Drawing.Size(32, 19);
            this.rotateAxisRadioY.TabIndex = 4;
            this.rotateAxisRadioY.TabStop = true;
            this.rotateAxisRadioY.Text = "Y";
            this.rotateAxisRadioY.UseVisualStyleBackColor = true;
            // 
            // rotateAxisRadioX
            // 
            this.rotateAxisRadioX.AutoSize = true;
            this.rotateAxisRadioX.Checked = true;
            this.rotateAxisRadioX.Location = new System.Drawing.Point(43, 26);
            this.rotateAxisRadioX.Name = "rotateAxisRadioX";
            this.rotateAxisRadioX.Size = new System.Drawing.Size(32, 19);
            this.rotateAxisRadioX.TabIndex = 3;
            this.rotateAxisRadioX.TabStop = true;
            this.rotateAxisRadioX.Text = "X";
            this.rotateAxisRadioX.UseVisualStyleBackColor = true;
            // 
            // rotateButton
            // 
            this.rotateButton.Location = new System.Drawing.Point(6, 51);
            this.rotateButton.Name = "rotateButton";
            this.rotateButton.Size = new System.Drawing.Size(97, 23);
            this.rotateButton.TabIndex = 2;
            this.rotateButton.Text = "Применить";
            this.rotateButton.UseVisualStyleBackColor = true;
            this.rotateButton.Click += new System.EventHandler(this.RotateButtonClick);
            // 
            // obliqueShiftGroup
            // 
            this.obliqueShiftGroup.Controls.Add(this.label10);
            this.obliqueShiftGroup.Controls.Add(this.panel1);
            this.obliqueShiftGroup.Controls.Add(this.label8);
            this.obliqueShiftGroup.Controls.Add(this.label9);
            this.obliqueShiftGroup.Controls.Add(this.obliqueShiftFactor);
            this.obliqueShiftGroup.Controls.Add(this.obliqueShiftAxisZ);
            this.obliqueShiftGroup.Controls.Add(this.obliqueShiftAxisY);
            this.obliqueShiftGroup.Controls.Add(this.obliqueShiftAxisX);
            this.obliqueShiftGroup.Controls.Add(this.obliqueShiftButton);
            this.obliqueShiftGroup.Location = new System.Drawing.Point(723, 337);
            this.obliqueShiftGroup.Name = "obliqueShiftGroup";
            this.obliqueShiftGroup.Size = new System.Drawing.Size(352, 118);
            this.obliqueShiftGroup.TabIndex = 12;
            this.obliqueShiftGroup.TabStop = false;
            this.obliqueShiftGroup.Text = "Косой сдвиг";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 15);
            this.label10.TabIndex = 12;
            this.label10.Text = "По оси:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.obliqueShiftAlongAxisZ);
            this.panel1.Controls.Add(this.obliqueShiftAlongAxisX);
            this.panel1.Controls.Add(this.obliqueShiftAlongAxisY);
            this.panel1.Location = new System.Drawing.Point(61, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(114, 26);
            this.panel1.TabIndex = 11;
            // 
            // obliqueShiftAlongAxisZ
            // 
            this.obliqueShiftAlongAxisZ.AutoSize = true;
            this.obliqueShiftAlongAxisZ.Location = new System.Drawing.Point(79, 3);
            this.obliqueShiftAlongAxisZ.Name = "obliqueShiftAlongAxisZ";
            this.obliqueShiftAlongAxisZ.Size = new System.Drawing.Size(32, 19);
            this.obliqueShiftAlongAxisZ.TabIndex = 13;
            this.obliqueShiftAlongAxisZ.TabStop = true;
            this.obliqueShiftAlongAxisZ.Text = "Z";
            this.obliqueShiftAlongAxisZ.UseVisualStyleBackColor = true;
            // 
            // obliqueShiftAlongAxisX
            // 
            this.obliqueShiftAlongAxisX.AutoSize = true;
            this.obliqueShiftAlongAxisX.Checked = true;
            this.obliqueShiftAlongAxisX.Location = new System.Drawing.Point(3, 3);
            this.obliqueShiftAlongAxisX.Name = "obliqueShiftAlongAxisX";
            this.obliqueShiftAlongAxisX.Size = new System.Drawing.Size(32, 19);
            this.obliqueShiftAlongAxisX.TabIndex = 11;
            this.obliqueShiftAlongAxisX.TabStop = true;
            this.obliqueShiftAlongAxisX.Text = "X";
            this.obliqueShiftAlongAxisX.UseVisualStyleBackColor = true;
            // 
            // obliqueShiftAlongAxisY
            // 
            this.obliqueShiftAlongAxisY.AutoSize = true;
            this.obliqueShiftAlongAxisY.Location = new System.Drawing.Point(41, 3);
            this.obliqueShiftAlongAxisY.Name = "obliqueShiftAlongAxisY";
            this.obliqueShiftAlongAxisY.Size = new System.Drawing.Size(32, 19);
            this.obliqueShiftAlongAxisY.TabIndex = 12;
            this.obliqueShiftAlongAxisY.TabStop = true;
            this.obliqueShiftAlongAxisY.Text = "Y";
            this.obliqueShiftAlongAxisY.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "Оси:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(231, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Коэффициент:";
            // 
            // obliqueShiftFactor
            // 
            this.obliqueShiftFactor.Location = new System.Drawing.Point(238, 53);
            this.obliqueShiftFactor.Name = "obliqueShiftFactor";
            this.obliqueShiftFactor.Size = new System.Drawing.Size(80, 23);
            this.obliqueShiftFactor.TabIndex = 7;
            // 
            // obliqueShiftAxisZ
            // 
            this.obliqueShiftAxisZ.AutoSize = true;
            this.obliqueShiftAxisZ.Location = new System.Drawing.Point(140, 26);
            this.obliqueShiftAxisZ.Name = "obliqueShiftAxisZ";
            this.obliqueShiftAxisZ.Size = new System.Drawing.Size(32, 19);
            this.obliqueShiftAxisZ.TabIndex = 5;
            this.obliqueShiftAxisZ.Text = "Z";
            this.obliqueShiftAxisZ.UseVisualStyleBackColor = true;
            // 
            // obliqueShiftAxisY
            // 
            this.obliqueShiftAxisY.AutoSize = true;
            this.obliqueShiftAxisY.Checked = true;
            this.obliqueShiftAxisY.Location = new System.Drawing.Point(102, 26);
            this.obliqueShiftAxisY.Name = "obliqueShiftAxisY";
            this.obliqueShiftAxisY.Size = new System.Drawing.Size(32, 19);
            this.obliqueShiftAxisY.TabIndex = 4;
            this.obliqueShiftAxisY.TabStop = true;
            this.obliqueShiftAxisY.Text = "Y";
            this.obliqueShiftAxisY.UseVisualStyleBackColor = true;
            // 
            // obliqueShiftAxisX
            // 
            this.obliqueShiftAxisX.AutoSize = true;
            this.obliqueShiftAxisX.Location = new System.Drawing.Point(64, 26);
            this.obliqueShiftAxisX.Name = "obliqueShiftAxisX";
            this.obliqueShiftAxisX.Size = new System.Drawing.Size(32, 19);
            this.obliqueShiftAxisX.TabIndex = 3;
            this.obliqueShiftAxisX.Text = "X";
            this.obliqueShiftAxisX.UseVisualStyleBackColor = true;
            // 
            // obliqueShiftButton
            // 
            this.obliqueShiftButton.Location = new System.Drawing.Point(6, 89);
            this.obliqueShiftButton.Name = "obliqueShiftButton";
            this.obliqueShiftButton.Size = new System.Drawing.Size(97, 23);
            this.obliqueShiftButton.TabIndex = 2;
            this.obliqueShiftButton.Text = "Применить";
            this.obliqueShiftButton.UseVisualStyleBackColor = true;
            this.obliqueShiftButton.Click += new System.EventHandler(this.ObliqueShiftButtonClick);
            // 
            // oppGroup
            // 
            this.oppGroup.Controls.Add(this.label11);
            this.oppGroup.Controls.Add(this.label12);
            this.oppGroup.Controls.Add(this.oppTextBox);
            this.oppGroup.Controls.Add(this.oppAxisRadioZ);
            this.oppGroup.Controls.Add(this.oppAxisRadioY);
            this.oppGroup.Controls.Add(this.oppAxisRadioX);
            this.oppGroup.Controls.Add(this.oppButton);
            this.oppGroup.Location = new System.Drawing.Point(723, 461);
            this.oppGroup.Name = "oppGroup";
            this.oppGroup.Size = new System.Drawing.Size(352, 81);
            this.oppGroup.TabIndex = 12;
            this.oppGroup.TabStop = false;
            this.oppGroup.Text = "ОПП";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 15);
            this.label11.TabIndex = 10;
            this.label11.Text = "Ось:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(197, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 15);
            this.label12.TabIndex = 8;
            this.label12.Text = "Фокусное расстояние:";
            // 
            // oppTextBox
            // 
            this.oppTextBox.Location = new System.Drawing.Point(224, 37);
            this.oppTextBox.Name = "oppTextBox";
            this.oppTextBox.Size = new System.Drawing.Size(80, 23);
            this.oppTextBox.TabIndex = 7;
            // 
            // oppAxisRadioZ
            // 
            this.oppAxisRadioZ.AutoSize = true;
            this.oppAxisRadioZ.Location = new System.Drawing.Point(119, 26);
            this.oppAxisRadioZ.Name = "oppAxisRadioZ";
            this.oppAxisRadioZ.Size = new System.Drawing.Size(32, 19);
            this.oppAxisRadioZ.TabIndex = 5;
            this.oppAxisRadioZ.TabStop = true;
            this.oppAxisRadioZ.Text = "Z";
            this.oppAxisRadioZ.UseVisualStyleBackColor = true;
            // 
            // oppAxisRadioY
            // 
            this.oppAxisRadioY.AutoSize = true;
            this.oppAxisRadioY.Location = new System.Drawing.Point(81, 26);
            this.oppAxisRadioY.Name = "oppAxisRadioY";
            this.oppAxisRadioY.Size = new System.Drawing.Size(32, 19);
            this.oppAxisRadioY.TabIndex = 4;
            this.oppAxisRadioY.TabStop = true;
            this.oppAxisRadioY.Text = "Y";
            this.oppAxisRadioY.UseVisualStyleBackColor = true;
            // 
            // oppAxisRadioX
            // 
            this.oppAxisRadioX.AutoSize = true;
            this.oppAxisRadioX.Checked = true;
            this.oppAxisRadioX.Location = new System.Drawing.Point(43, 26);
            this.oppAxisRadioX.Name = "oppAxisRadioX";
            this.oppAxisRadioX.Size = new System.Drawing.Size(32, 19);
            this.oppAxisRadioX.TabIndex = 3;
            this.oppAxisRadioX.TabStop = true;
            this.oppAxisRadioX.Text = "X";
            this.oppAxisRadioX.UseVisualStyleBackColor = true;
            // 
            // oppButton
            // 
            this.oppButton.Location = new System.Drawing.Point(6, 51);
            this.oppButton.Name = "oppButton";
            this.oppButton.Size = new System.Drawing.Size(97, 23);
            this.oppButton.TabIndex = 2;
            this.oppButton.Text = "Применить";
            this.oppButton.UseVisualStyleBackColor = true;
            this.oppButton.Click += new System.EventHandler(this.OppButtonClick);
            // 
            // fitIntoFrameButton
            // 
            this.fitIntoFrameButton.Location = new System.Drawing.Point(838, 564);
            this.fitIntoFrameButton.Name = "fitIntoFrameButton";
            this.fitIntoFrameButton.Size = new System.Drawing.Size(135, 23);
            this.fitIntoFrameButton.TabIndex = 13;
            this.fitIntoFrameButton.Text = "Вписать в кадр";
            this.fitIntoFrameButton.UseVisualStyleBackColor = true;
            this.fitIntoFrameButton.Click += new System.EventHandler(this.FitIntoFrameButtonClick);
            // 
            // scaleAxisRadioAll
            // 
            this.scaleAxisRadioAll.AutoSize = true;
            this.scaleAxisRadioAll.Location = new System.Drawing.Point(43, 51);
            this.scaleAxisRadioAll.Name = "scaleAxisRadioAll";
            this.scaleAxisRadioAll.Size = new System.Drawing.Size(102, 19);
            this.scaleAxisRadioAll.TabIndex = 11;
            this.scaleAxisRadioAll.TabStop = true;
            this.scaleAxisRadioAll.Text = "По всем осям";
            this.scaleAxisRadioAll.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 726);
            this.Controls.Add(this.fitIntoFrameButton);
            this.Controls.Add(this.oppGroup);
            this.Controls.Add(this.obliqueShiftGroup);
            this.Controls.Add(this.rotateGroup);
            this.Controls.Add(this.scaleGroup);
            this.Controls.Add(this.parallelTransferGroup);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.pictureBox);
            this.Name = "MainForm";
            this.Text = "Computer Graphics";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.parallelTransferGroup.ResumeLayout(false);
            this.parallelTransferGroup.PerformLayout();
            this.scaleGroup.ResumeLayout(false);
            this.scaleGroup.PerformLayout();
            this.rotateGroup.ResumeLayout(false);
            this.rotateGroup.PerformLayout();
            this.obliqueShiftGroup.ResumeLayout(false);
            this.obliqueShiftGroup.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.oppGroup.ResumeLayout(false);
            this.oppGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Timer drawTimer;
        private System.Windows.Forms.Button parallelTransferButton;
        private System.Windows.Forms.TextBox parallelTransferX;
        private System.Windows.Forms.GroupBox parallelTransferGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox parallelTransferZ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox parallelTransferY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox scaleGroup;
        private System.Windows.Forms.Button scaleButton;
        private System.Windows.Forms.RadioButton scaleAxisRadioZ;
        private System.Windows.Forms.RadioButton scaleAxisRadioY;
        private System.Windows.Forms.RadioButton scaleAxisRadioX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox scaleTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox rotateGroup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox rotateTextBox;
        private System.Windows.Forms.RadioButton rotateAxisRadioZ;
        private System.Windows.Forms.RadioButton rotateAxisRadioY;
        private System.Windows.Forms.RadioButton rotateAxisRadioX;
        private System.Windows.Forms.Button rotateButton;
        private System.Windows.Forms.GroupBox obliqueShiftGroup;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox obliqueShiftFactor;
        private System.Windows.Forms.RadioButton obliqueShiftAxisZ;
        private System.Windows.Forms.RadioButton obliqueShiftAxisY;
        private System.Windows.Forms.RadioButton obliqueShiftAxisX;
        private System.Windows.Forms.Button obliqueShiftButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton obliqueShiftAlongAxisZ;
        private System.Windows.Forms.RadioButton obliqueShiftAlongAxisX;
        private System.Windows.Forms.RadioButton obliqueShiftAlongAxisY;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox oppGroup;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox oppTextBox;
        private System.Windows.Forms.RadioButton oppAxisRadioZ;
        private System.Windows.Forms.RadioButton oppAxisRadioY;
        private System.Windows.Forms.RadioButton oppAxisRadioX;
        private System.Windows.Forms.Button oppButton;
        private System.Windows.Forms.Button fitIntoFrameButton;
        private System.Windows.Forms.RadioButton scaleAxisRadioAll;
    }
}