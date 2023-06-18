using JuegoDeLudo;
using JuegoDeLudo.Properties;
using System.Resources;

namespace JuegoDeLudo
{
    partial class Form2
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
            pantallaJuego1 = new pantallaJuego();
            pantallaPrincipal1 = new pantallaPrincipal();
            button1 = new Button();
            SuspendLayout();
            // 
            // pantallaJuego1
            // 
            pantallaJuego1.AutoSize = true;
            pantallaJuego1.Location = new Point(0, 0);
            pantallaJuego1.Margin = new Padding(0);
            pantallaJuego1.Name = "pantallaJuego1";
            pantallaJuego1.Size = new Size(1080, 720);
            pantallaJuego1.TabIndex = 1;
            pantallaJuego1.Visible = false;
            // 
            // pantallaPrincipal1
            // 
            pantallaPrincipal1.AutoSize = true;
            pantallaPrincipal1.Location = new Point(0, 0);
            pantallaPrincipal1.Margin = new Padding(0);
            pantallaPrincipal1.Name = "pantallaPrincipal1";
            pantallaPrincipal1.Size = new Size(1080, 720);
            pantallaPrincipal1.TabIndex = 1;
            pantallaPrincipal1.Load += pantallaPrincipal1_Load;
            // 
            // button1
            // 
            button1.Location = new Point(330, 425);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(161, 42);
            button1.TabIndex = 2;
            button1.Text = "EMPEZAR JUEGO";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1100, 720);
            Controls.Add(button1);
            Controls.Add(pantallaPrincipal1);
            Controls.Add(pantallaJuego1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        private pantallaJuego pantallaJuego1;
        private pantallaPrincipal pantallaPrincipal1;
        private Button button1;

        #endregion

        /*
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel11 = new TableLayoutPanel();
            pictureBox59 = new PictureBox();
            pictureBox66 = new PictureBox();
            pictureBox73 = new PictureBox();
            pictureBox80 = new PictureBox();
            tableLayoutPanel10 = new TableLayoutPanel();
            pictureBox79 = new PictureBox();
            pictureBox44 = new PictureBox();
            pictureBox33 = new PictureBox();
            pictureBox34 = new PictureBox();
            pictureBox35 = new PictureBox();
            pictureBox36 = new PictureBox();
            pictureBox37 = new PictureBox();
            pictureBox38 = new PictureBox();
            pictureBox39 = new PictureBox();
            pictureBox40 = new PictureBox();
            pictureBox41 = new PictureBox();
            pictureBox42 = new PictureBox();
            pictureBox43 = new PictureBox();
            pictureBox74 = new PictureBox();
            pictureBox75 = new PictureBox();
            pictureBox76 = new PictureBox();
            pictureBox77 = new PictureBox();
            pictureBox78 = new PictureBox();
            tableLayoutPanel9 = new TableLayoutPanel();
            pictureBox85 = new PictureBox();
            pictureBox86 = new PictureBox();
            pictureBox87 = new PictureBox();
            pictureBox88 = new PictureBox();
            tableLayoutPanel8 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            tableLayoutPanel7 = new TableLayoutPanel();
            pictureBox81 = new PictureBox();
            pictureBox82 = new PictureBox();
            pictureBox83 = new PictureBox();
            pictureBox84 = new PictureBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            pictureBox72 = new PictureBox();
            pictureBox26 = new PictureBox();
            pictureBox25 = new PictureBox();
            pictureBox24 = new PictureBox();
            pictureBox23 = new PictureBox();
            pictureBox22 = new PictureBox();
            pictureBox21 = new PictureBox();
            pictureBox27 = new PictureBox();
            pictureBox28 = new PictureBox();
            pictureBox29 = new PictureBox();
            pictureBox30 = new PictureBox();
            pictureBox31 = new PictureBox();
            pictureBox32 = new PictureBox();
            pictureBox67 = new PictureBox();
            pictureBox68 = new PictureBox();
            pictureBox69 = new PictureBox();
            pictureBox70 = new PictureBox();
            pictureBox71 = new PictureBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            pictureBox58 = new PictureBox();
            pictureBox57 = new PictureBox();
            pictureBox56 = new PictureBox();
            pictureBox55 = new PictureBox();
            pictureBox54 = new PictureBox();
            pictureBox53 = new PictureBox();
            pictureBox52 = new PictureBox();
            pictureBox45 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox46 = new PictureBox();
            pictureBox47 = new PictureBox();
            pictureBox48 = new PictureBox();
            pictureBox49 = new PictureBox();
            pictureBox50 = new PictureBox();
            pictureBox51 = new PictureBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            pictureBox65 = new PictureBox();
            pictureBox64 = new PictureBox();
            pictureBox63 = new PictureBox();
            pictureBox62 = new PictureBox();
            pictureBox61 = new PictureBox();
            pictureBox16 = new PictureBox();
            pictureBox15 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox10 = new PictureBox();
            pictureBox11 = new PictureBox();
            pictureBox12 = new PictureBox();
            pictureBox13 = new PictureBox();
            pictureBox14 = new PictureBox();
            pictureBox19 = new PictureBox();
            pictureBox18 = new PictureBox();
            pictureBox17 = new PictureBox();
            pictureBox20 = new PictureBox();
            pictureBox60 = new PictureBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            pictureBox89 = new PictureBox();
            pictureBox90 = new PictureBox();
            pictureBox91 = new PictureBox();
            pictureBox92 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel12 = new TableLayoutPanel();
            btnTirarDado = new Button();
            label1 = new Label();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox59).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox66).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox73).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox80).BeginInit();
            tableLayoutPanel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox79).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox44).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox33).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox34).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox35).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox36).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox37).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox38).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox39).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox40).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox41).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox42).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox43).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox74).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox75).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox76).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox77).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox78).BeginInit();
            tableLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox85).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox86).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox87).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox88).BeginInit();
            tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox81).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox82).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox83).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox84).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox72).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox26).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox25).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox24).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox23).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox22).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox21).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox27).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox28).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox29).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox30).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox31).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox32).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox67).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox68).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox69).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox70).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox71).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox58).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox57).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox56).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox55).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox54).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox53).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox52).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox45).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox46).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox47).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox48).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox49).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox50).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox51).BeginInit();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox65).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox64).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox63).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox62).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox61).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox19).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox18).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox17).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox20).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox60).BeginInit();
            tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox89).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox90).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox91).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox92).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel12.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.Transparent;
            tableLayoutPanel3.BackgroundImage = Resources.Background;
            tableLayoutPanel3.BackgroundImageLayout = ImageLayout.Stretch;
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel11, 1, 1);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel10, 1, 2);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel9, 2, 2);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel8, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel7, 2, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel2, 2, 1);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel5, 1, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel6, 0, 2);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(4, 3);
            tableLayoutPanel3.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel3.Size = new Size(581, 555);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.ColumnCount = 3;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel11.Controls.Add(pictureBox59, 0, 1);
            tableLayoutPanel11.Controls.Add(pictureBox66, 1, 0);
            tableLayoutPanel11.Controls.Add(pictureBox73, 2, 1);
            tableLayoutPanel11.Controls.Add(pictureBox80, 1, 2);
            tableLayoutPanel11.Dock = DockStyle.Fill;
            tableLayoutPanel11.Location = new Point(236, 225);
            tableLayoutPanel11.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 3;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel11.Size = new Size(108, 105);
            tableLayoutPanel11.TabIndex = 5;
            // 
            // pictureBox59
            // 
            pictureBox59.Location = new Point(3, 38);
            pictureBox59.Name = "pictureBox59";
            pictureBox59.Size = new Size(30, 29);
            pictureBox59.TabIndex = 17;
            pictureBox59.TabStop = false;
            // 
            // pictureBox66
            // 
            pictureBox66.Location = new Point(39, 3);
            pictureBox66.Name = "pictureBox66";
            pictureBox66.Size = new Size(30, 29);
            pictureBox66.TabIndex = 18;
            pictureBox66.TabStop = false;
            // 
            // pictureBox73
            // 
            pictureBox73.Location = new Point(75, 38);
            pictureBox73.Name = "pictureBox73";
            pictureBox73.Size = new Size(30, 29);
            pictureBox73.TabIndex = 19;
            pictureBox73.TabStop = false;
            // 
            // pictureBox80
            // 
            pictureBox80.Location = new Point(39, 73);
            pictureBox80.Name = "pictureBox80";
            pictureBox80.Size = new Size(30, 29);
            pictureBox80.TabIndex = 20;
            pictureBox80.TabStop = false;
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.ColumnCount = 3;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel10.Controls.Add(pictureBox79, 1, 0);
            tableLayoutPanel10.Controls.Add(pictureBox44, 0, 0);
            tableLayoutPanel10.Controls.Add(pictureBox33, 2, 0);
            tableLayoutPanel10.Controls.Add(pictureBox34, 2, 1);
            tableLayoutPanel10.Controls.Add(pictureBox35, 2, 2);
            tableLayoutPanel10.Controls.Add(pictureBox36, 2, 3);
            tableLayoutPanel10.Controls.Add(pictureBox37, 2, 4);
            tableLayoutPanel10.Controls.Add(pictureBox38, 2, 5);
            tableLayoutPanel10.Controls.Add(pictureBox39, 1, 5);
            tableLayoutPanel10.Controls.Add(pictureBox40, 0, 5);
            tableLayoutPanel10.Controls.Add(pictureBox41, 0, 3);
            tableLayoutPanel10.Controls.Add(pictureBox42, 0, 2);
            tableLayoutPanel10.Controls.Add(pictureBox43, 0, 1);
            tableLayoutPanel10.Controls.Add(pictureBox74, 0, 4);
            tableLayoutPanel10.Controls.Add(pictureBox75, 1, 4);
            tableLayoutPanel10.Controls.Add(pictureBox76, 1, 3);
            tableLayoutPanel10.Controls.Add(pictureBox77, 1, 2);
            tableLayoutPanel10.Controls.Add(pictureBox78, 1, 1);
            tableLayoutPanel10.Dock = DockStyle.Fill;
            tableLayoutPanel10.Location = new Point(236, 336);
            tableLayoutPanel10.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 6;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel10.Size = new Size(108, 216);
            tableLayoutPanel10.TabIndex = 3;
            // 
            // pictureBox79
            // 
            pictureBox79.Location = new Point(39, 3);
            pictureBox79.Name = "pictureBox79";
            pictureBox79.Size = new Size(30, 29);
            pictureBox79.TabIndex = 46;
            pictureBox79.TabStop = false;
            // 
            // pictureBox44
            // 
            pictureBox44.Location = new Point(3, 3);
            pictureBox44.Name = "pictureBox44";
            pictureBox44.Size = new Size(30, 29);
            pictureBox44.TabIndex = 40;
            pictureBox44.TabStop = false;
            // 
            // pictureBox33
            // 
            pictureBox33.Location = new Point(75, 3);
            pictureBox33.Name = "pictureBox33";
            pictureBox33.Size = new Size(30, 29);
            pictureBox33.TabIndex = 29;
            pictureBox33.TabStop = false;
            // 
            // pictureBox34
            // 
            pictureBox34.Location = new Point(75, 39);
            pictureBox34.Name = "pictureBox34";
            pictureBox34.Size = new Size(30, 29);
            pictureBox34.TabIndex = 30;
            pictureBox34.TabStop = false;
            // 
            // pictureBox35
            // 
            pictureBox35.Location = new Point(75, 75);
            pictureBox35.Name = "pictureBox35";
            pictureBox35.Size = new Size(30, 29);
            pictureBox35.TabIndex = 31;
            pictureBox35.TabStop = false;
            // 
            // pictureBox36
            // 
            pictureBox36.Location = new Point(75, 111);
            pictureBox36.Name = "pictureBox36";
            pictureBox36.Size = new Size(30, 29);
            pictureBox36.TabIndex = 32;
            pictureBox36.TabStop = false;
            // 
            // pictureBox37
            // 
            pictureBox37.Location = new Point(75, 147);
            pictureBox37.Name = "pictureBox37";
            pictureBox37.Size = new Size(30, 29);
            pictureBox37.TabIndex = 33;
            pictureBox37.TabStop = false;
            // 
            // pictureBox38
            // 
            pictureBox38.Location = new Point(75, 183);
            pictureBox38.Name = "pictureBox38";
            pictureBox38.Size = new Size(30, 29);
            pictureBox38.TabIndex = 34;
            pictureBox38.TabStop = false;
            // 
            // pictureBox39
            // 
            pictureBox39.Location = new Point(39, 183);
            pictureBox39.Name = "pictureBox39";
            pictureBox39.Size = new Size(30, 29);
            pictureBox39.TabIndex = 35;
            pictureBox39.TabStop = false;
            // 
            // pictureBox40
            // 
            pictureBox40.Location = new Point(3, 183);
            pictureBox40.Name = "pictureBox40";
            pictureBox40.Size = new Size(30, 29);
            pictureBox40.TabIndex = 36;
            pictureBox40.TabStop = false;
            // 
            // pictureBox41
            // 
            pictureBox41.Location = new Point(3, 111);
            pictureBox41.Name = "pictureBox41";
            pictureBox41.Size = new Size(30, 29);
            pictureBox41.TabIndex = 37;
            pictureBox41.TabStop = false;
            // 
            // pictureBox42
            // 
            pictureBox42.Location = new Point(3, 75);
            pictureBox42.Name = "pictureBox42";
            pictureBox42.Size = new Size(30, 29);
            pictureBox42.TabIndex = 38;
            pictureBox42.TabStop = false;
            // 
            // pictureBox43
            // 
            pictureBox43.Location = new Point(3, 39);
            pictureBox43.Name = "pictureBox43";
            pictureBox43.Size = new Size(30, 29);
            pictureBox43.TabIndex = 39;
            pictureBox43.TabStop = false;
            // 
            // pictureBox74
            // 
            pictureBox74.Location = new Point(3, 147);
            pictureBox74.Name = "pictureBox74";
            pictureBox74.Size = new Size(30, 29);
            pictureBox74.TabIndex = 41;
            pictureBox74.TabStop = false;
            // 
            // pictureBox75
            // 
            pictureBox75.Location = new Point(39, 147);
            pictureBox75.Name = "pictureBox75";
            pictureBox75.Size = new Size(30, 29);
            pictureBox75.TabIndex = 42;
            pictureBox75.TabStop = false;
            // 
            // pictureBox76
            // 
            pictureBox76.Location = new Point(39, 111);
            pictureBox76.Name = "pictureBox76";
            pictureBox76.Size = new Size(30, 29);
            pictureBox76.TabIndex = 43;
            pictureBox76.TabStop = false;
            // 
            // pictureBox77
            // 
            pictureBox77.Location = new Point(39, 75);
            pictureBox77.Name = "pictureBox77";
            pictureBox77.Size = new Size(30, 29);
            pictureBox77.TabIndex = 44;
            pictureBox77.TabStop = false;
            // 
            // pictureBox78
            // 
            pictureBox78.Location = new Point(39, 39);
            pictureBox78.Name = "pictureBox78";
            pictureBox78.Size = new Size(30, 29);
            pictureBox78.TabIndex = 45;
            pictureBox78.TabStop = false;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 6;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel9.Controls.Add(pictureBox85, 1, 1);
            tableLayoutPanel9.Controls.Add(pictureBox86, 4, 1);
            tableLayoutPanel9.Controls.Add(pictureBox87, 1, 4);
            tableLayoutPanel9.Controls.Add(pictureBox88, 4, 4);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(352, 336);
            tableLayoutPanel9.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 6;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel9.Size = new Size(225, 216);
            tableLayoutPanel9.TabIndex = 4;
            // 
            // pictureBox85
            // 
            pictureBox85.Location = new Point(40, 39);
            pictureBox85.Name = "pictureBox85";
            pictureBox85.Size = new Size(31, 29);
            pictureBox85.TabIndex = 1;
            pictureBox85.TabStop = false;
            // 
            // pictureBox86
            // 
            pictureBox86.Location = new Point(151, 39);
            pictureBox86.Name = "pictureBox86";
            pictureBox86.Size = new Size(31, 29);
            pictureBox86.TabIndex = 2;
            pictureBox86.TabStop = false;
            // 
            // pictureBox87
            // 
            pictureBox87.Location = new Point(40, 147);
            pictureBox87.Name = "pictureBox87";
            pictureBox87.Size = new Size(31, 29);
            pictureBox87.TabIndex = 3;
            pictureBox87.TabStop = false;
            // 
            // pictureBox88
            // 
            pictureBox88.Location = new Point(151, 147);
            pictureBox88.Name = "pictureBox88";
            pictureBox88.Size = new Size(31, 29);
            pictureBox88.TabIndex = 4;
            pictureBox88.TabStop = false;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 6;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel8.Controls.Add(pictureBox1, 1, 1);
            tableLayoutPanel8.Controls.Add(pictureBox2, 4, 1);
            tableLayoutPanel8.Controls.Add(pictureBox3, 1, 4);
            tableLayoutPanel8.Controls.Add(pictureBox4, 4, 4);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(4, 3);
            tableLayoutPanel8.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 6;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel8.Size = new Size(224, 216);
            tableLayoutPanel8.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Resources.Pieza_roja;
            pictureBox1.Location = new Point(40, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = Resources.Pieza_roja;
            pictureBox2.Location = new Point(151, 39);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox3.Image = Resources.Pieza_roja;
            pictureBox3.Location = new Point(40, 147);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(31, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox4.Image = Resources.Pieza_roja;
            pictureBox4.Location = new Point(151, 147);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(31, 30);
            pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 6;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel7.Controls.Add(pictureBox81, 1, 1);
            tableLayoutPanel7.Controls.Add(pictureBox82, 4, 1);
            tableLayoutPanel7.Controls.Add(pictureBox83, 1, 4);
            tableLayoutPanel7.Controls.Add(pictureBox84, 4, 4);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(352, 3);
            tableLayoutPanel7.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 6;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel7.Size = new Size(225, 216);
            tableLayoutPanel7.TabIndex = 4;
            // 
            // pictureBox81
            // 
            pictureBox81.Location = new Point(40, 39);
            pictureBox81.Name = "pictureBox81";
            pictureBox81.Size = new Size(31, 29);
            pictureBox81.TabIndex = 1;
            pictureBox81.TabStop = false;
            // 
            // pictureBox82
            // 
            pictureBox82.Location = new Point(151, 39);
            pictureBox82.Name = "pictureBox82";
            pictureBox82.Size = new Size(31, 29);
            pictureBox82.TabIndex = 2;
            pictureBox82.TabStop = false;
            // 
            // pictureBox83
            // 
            pictureBox83.Location = new Point(40, 147);
            pictureBox83.Name = "pictureBox83";
            pictureBox83.Size = new Size(31, 29);
            pictureBox83.TabIndex = 3;
            pictureBox83.TabStop = false;
            // 
            // pictureBox84
            // 
            pictureBox84.Location = new Point(151, 147);
            pictureBox84.Name = "pictureBox84";
            pictureBox84.Size = new Size(31, 29);
            pictureBox84.TabIndex = 4;
            pictureBox84.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 6;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66666F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66666F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66666F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66666F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66666F));
            tableLayoutPanel2.Controls.Add(pictureBox72, 0, 1);
            tableLayoutPanel2.Controls.Add(pictureBox26, 5, 0);
            tableLayoutPanel2.Controls.Add(pictureBox25, 4, 0);
            tableLayoutPanel2.Controls.Add(pictureBox24, 3, 0);
            tableLayoutPanel2.Controls.Add(pictureBox23, 2, 0);
            tableLayoutPanel2.Controls.Add(pictureBox22, 1, 0);
            tableLayoutPanel2.Controls.Add(pictureBox21, 0, 0);
            tableLayoutPanel2.Controls.Add(pictureBox27, 5, 1);
            tableLayoutPanel2.Controls.Add(pictureBox28, 5, 2);
            tableLayoutPanel2.Controls.Add(pictureBox29, 3, 2);
            tableLayoutPanel2.Controls.Add(pictureBox30, 2, 2);
            tableLayoutPanel2.Controls.Add(pictureBox31, 1, 2);
            tableLayoutPanel2.Controls.Add(pictureBox32, 0, 2);
            tableLayoutPanel2.Controls.Add(pictureBox67, 4, 2);
            tableLayoutPanel2.Controls.Add(pictureBox68, 4, 1);
            tableLayoutPanel2.Controls.Add(pictureBox69, 3, 1);
            tableLayoutPanel2.Controls.Add(pictureBox70, 2, 1);
            tableLayoutPanel2.Controls.Add(pictureBox71, 1, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(352, 225);
            tableLayoutPanel2.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(225, 105);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // pictureBox72
            // 
            pictureBox72.Location = new Point(3, 38);
            pictureBox72.Name = "pictureBox72";
            pictureBox72.Size = new Size(31, 29);
            pictureBox72.TabIndex = 34;
            pictureBox72.TabStop = false;
            // 
            // pictureBox26
            // 
            pictureBox26.Location = new Point(188, 3);
            pictureBox26.Name = "pictureBox26";
            pictureBox26.Size = new Size(31, 29);
            pictureBox26.TabIndex = 22;
            pictureBox26.TabStop = false;
            // 
            // pictureBox25
            // 
            pictureBox25.Location = new Point(151, 3);
            pictureBox25.Name = "pictureBox25";
            pictureBox25.Size = new Size(31, 29);
            pictureBox25.TabIndex = 21;
            pictureBox25.TabStop = false;
            // 
            // pictureBox24
            // 
            pictureBox24.Location = new Point(114, 3);
            pictureBox24.Name = "pictureBox24";
            pictureBox24.Size = new Size(31, 29);
            pictureBox24.TabIndex = 20;
            pictureBox24.TabStop = false;
            // 
            // pictureBox23
            // 
            pictureBox23.Location = new Point(77, 3);
            pictureBox23.Name = "pictureBox23";
            pictureBox23.Size = new Size(31, 29);
            pictureBox23.TabIndex = 19;
            pictureBox23.TabStop = false;
            // 
            // pictureBox22
            // 
            pictureBox22.Location = new Point(40, 3);
            pictureBox22.Name = "pictureBox22";
            pictureBox22.Size = new Size(31, 29);
            pictureBox22.TabIndex = 18;
            pictureBox22.TabStop = false;
            // 
            // pictureBox21
            // 
            pictureBox21.Location = new Point(3, 3);
            pictureBox21.Name = "pictureBox21";
            pictureBox21.Size = new Size(31, 29);
            pictureBox21.TabIndex = 17;
            pictureBox21.TabStop = false;
            // 
            // pictureBox27
            // 
            pictureBox27.Location = new Point(188, 38);
            pictureBox27.Name = "pictureBox27";
            pictureBox27.Size = new Size(31, 29);
            pictureBox27.TabIndex = 23;
            pictureBox27.TabStop = false;
            // 
            // pictureBox28
            // 
            pictureBox28.Location = new Point(188, 73);
            pictureBox28.Name = "pictureBox28";
            pictureBox28.Size = new Size(31, 29);
            pictureBox28.TabIndex = 24;
            pictureBox28.TabStop = false;
            // 
            // pictureBox29
            // 
            pictureBox29.Location = new Point(114, 73);
            pictureBox29.Name = "pictureBox29";
            pictureBox29.Size = new Size(31, 29);
            pictureBox29.TabIndex = 25;
            pictureBox29.TabStop = false;
            // 
            // pictureBox30
            // 
            pictureBox30.Location = new Point(77, 73);
            pictureBox30.Name = "pictureBox30";
            pictureBox30.Size = new Size(31, 29);
            pictureBox30.TabIndex = 26;
            pictureBox30.TabStop = false;
            // 
            // pictureBox31
            // 
            pictureBox31.Location = new Point(40, 73);
            pictureBox31.Name = "pictureBox31";
            pictureBox31.Size = new Size(31, 29);
            pictureBox31.TabIndex = 27;
            pictureBox31.TabStop = false;
            // 
            // pictureBox32
            // 
            pictureBox32.Location = new Point(3, 73);
            pictureBox32.Name = "pictureBox32";
            pictureBox32.Size = new Size(31, 29);
            pictureBox32.TabIndex = 28;
            pictureBox32.TabStop = false;
            // 
            // pictureBox67
            // 
            pictureBox67.Location = new Point(151, 73);
            pictureBox67.Name = "pictureBox67";
            pictureBox67.Size = new Size(31, 29);
            pictureBox67.TabIndex = 29;
            pictureBox67.TabStop = false;
            // 
            // pictureBox68
            // 
            pictureBox68.Location = new Point(151, 38);
            pictureBox68.Name = "pictureBox68";
            pictureBox68.Size = new Size(31, 29);
            pictureBox68.TabIndex = 30;
            pictureBox68.TabStop = false;
            // 
            // pictureBox69
            // 
            pictureBox69.Location = new Point(114, 38);
            pictureBox69.Name = "pictureBox69";
            pictureBox69.Size = new Size(31, 29);
            pictureBox69.TabIndex = 31;
            pictureBox69.TabStop = false;
            // 
            // pictureBox70
            // 
            pictureBox70.Location = new Point(77, 38);
            pictureBox70.Name = "pictureBox70";
            pictureBox70.Size = new Size(31, 29);
            pictureBox70.TabIndex = 32;
            pictureBox70.TabStop = false;
            // 
            // pictureBox71
            // 
            pictureBox71.Location = new Point(40, 38);
            pictureBox71.Name = "pictureBox71";
            pictureBox71.Size = new Size(31, 29);
            pictureBox71.TabIndex = 33;
            pictureBox71.TabStop = false;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel4.ColumnCount = 6;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66666F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66666F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66666F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66666F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66666F));
            tableLayoutPanel4.Controls.Add(pictureBox58, 5, 1);
            tableLayoutPanel4.Controls.Add(pictureBox57, 4, 1);
            tableLayoutPanel4.Controls.Add(pictureBox56, 3, 1);
            tableLayoutPanel4.Controls.Add(pictureBox55, 2, 1);
            tableLayoutPanel4.Controls.Add(pictureBox54, 1, 1);
            tableLayoutPanel4.Controls.Add(pictureBox53, 1, 0);
            tableLayoutPanel4.Controls.Add(pictureBox52, 0, 0);
            tableLayoutPanel4.Controls.Add(pictureBox45, 5, 2);
            tableLayoutPanel4.Controls.Add(pictureBox5, 2, 0);
            tableLayoutPanel4.Controls.Add(pictureBox6, 3, 0);
            tableLayoutPanel4.Controls.Add(pictureBox7, 4, 0);
            tableLayoutPanel4.Controls.Add(pictureBox8, 5, 0);
            tableLayoutPanel4.Controls.Add(pictureBox46, 4, 2);
            tableLayoutPanel4.Controls.Add(pictureBox47, 3, 2);
            tableLayoutPanel4.Controls.Add(pictureBox48, 2, 2);
            tableLayoutPanel4.Controls.Add(pictureBox49, 1, 2);
            tableLayoutPanel4.Controls.Add(pictureBox50, 0, 2);
            tableLayoutPanel4.Controls.Add(pictureBox51, 0, 1);
            tableLayoutPanel4.Location = new Point(4, 225);
            tableLayoutPanel4.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(224, 105);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // pictureBox58
            // 
            pictureBox58.Location = new Point(188, 38);
            pictureBox58.Name = "pictureBox58";
            pictureBox58.Size = new Size(31, 29);
            pictureBox58.TabIndex = 54;
            pictureBox58.TabStop = false;
            // 
            // pictureBox57
            // 
            pictureBox57.Location = new Point(151, 38);
            pictureBox57.Name = "pictureBox57";
            pictureBox57.Size = new Size(31, 29);
            pictureBox57.TabIndex = 53;
            pictureBox57.TabStop = false;
            // 
            // pictureBox56
            // 
            pictureBox56.Location = new Point(114, 38);
            pictureBox56.Name = "pictureBox56";
            pictureBox56.Size = new Size(31, 29);
            pictureBox56.TabIndex = 52;
            pictureBox56.TabStop = false;
            // 
            // pictureBox55
            // 
            pictureBox55.Location = new Point(77, 38);
            pictureBox55.Name = "pictureBox55";
            pictureBox55.Size = new Size(31, 29);
            pictureBox55.TabIndex = 51;
            pictureBox55.TabStop = false;
            // 
            // pictureBox54
            // 
            pictureBox54.Location = new Point(40, 38);
            pictureBox54.Name = "pictureBox54";
            pictureBox54.Size = new Size(31, 29);
            pictureBox54.TabIndex = 50;
            pictureBox54.TabStop = false;
            // 
            // pictureBox53
            // 
            pictureBox53.Location = new Point(40, 3);
            pictureBox53.Name = "pictureBox53";
            pictureBox53.Size = new Size(31, 29);
            pictureBox53.TabIndex = 49;
            pictureBox53.TabStop = false;
            // 
            // pictureBox52
            // 
            pictureBox52.Location = new Point(3, 3);
            pictureBox52.Name = "pictureBox52";
            pictureBox52.Size = new Size(31, 29);
            pictureBox52.TabIndex = 48;
            pictureBox52.TabStop = false;
            // 
            // pictureBox45
            // 
            pictureBox45.Location = new Point(188, 73);
            pictureBox45.Name = "pictureBox45";
            pictureBox45.Size = new Size(31, 29);
            pictureBox45.TabIndex = 41;
            pictureBox45.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(77, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(31, 29);
            pictureBox5.TabIndex = 1;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Location = new Point(114, 3);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(31, 29);
            pictureBox6.TabIndex = 2;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Location = new Point(151, 3);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(31, 29);
            pictureBox7.TabIndex = 3;
            pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Location = new Point(188, 3);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(31, 29);
            pictureBox8.TabIndex = 4;
            pictureBox8.TabStop = false;
            // 
            // pictureBox46
            // 
            pictureBox46.Location = new Point(151, 73);
            pictureBox46.Name = "pictureBox46";
            pictureBox46.Size = new Size(31, 29);
            pictureBox46.TabIndex = 42;
            pictureBox46.TabStop = false;
            // 
            // pictureBox47
            // 
            pictureBox47.Location = new Point(114, 73);
            pictureBox47.Name = "pictureBox47";
            pictureBox47.Size = new Size(31, 29);
            pictureBox47.TabIndex = 43;
            pictureBox47.TabStop = false;
            // 
            // pictureBox48
            // 
            pictureBox48.Location = new Point(77, 73);
            pictureBox48.Name = "pictureBox48";
            pictureBox48.Size = new Size(31, 29);
            pictureBox48.TabIndex = 44;
            pictureBox48.TabStop = false;
            // 
            // pictureBox49
            // 
            pictureBox49.Location = new Point(40, 73);
            pictureBox49.Name = "pictureBox49";
            pictureBox49.Size = new Size(31, 29);
            pictureBox49.TabIndex = 45;
            pictureBox49.TabStop = false;
            // 
            // pictureBox50
            // 
            pictureBox50.Location = new Point(3, 73);
            pictureBox50.Name = "pictureBox50";
            pictureBox50.Size = new Size(31, 29);
            pictureBox50.TabIndex = 46;
            pictureBox50.TabStop = false;
            // 
            // pictureBox51
            // 
            pictureBox51.Location = new Point(3, 38);
            pictureBox51.Name = "pictureBox51";
            pictureBox51.Size = new Size(31, 29);
            pictureBox51.TabIndex = 47;
            pictureBox51.TabStop = false;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 3;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel5.Controls.Add(pictureBox65, 1, 5);
            tableLayoutPanel5.Controls.Add(pictureBox64, 1, 4);
            tableLayoutPanel5.Controls.Add(pictureBox63, 1, 3);
            tableLayoutPanel5.Controls.Add(pictureBox62, 1, 2);
            tableLayoutPanel5.Controls.Add(pictureBox61, 1, 1);
            tableLayoutPanel5.Controls.Add(pictureBox16, 2, 0);
            tableLayoutPanel5.Controls.Add(pictureBox15, 1, 0);
            tableLayoutPanel5.Controls.Add(pictureBox9, 0, 5);
            tableLayoutPanel5.Controls.Add(pictureBox10, 0, 4);
            tableLayoutPanel5.Controls.Add(pictureBox11, 0, 3);
            tableLayoutPanel5.Controls.Add(pictureBox12, 0, 2);
            tableLayoutPanel5.Controls.Add(pictureBox13, 0, 1);
            tableLayoutPanel5.Controls.Add(pictureBox14, 0, 0);
            tableLayoutPanel5.Controls.Add(pictureBox19, 2, 4);
            tableLayoutPanel5.Controls.Add(pictureBox18, 2, 3);
            tableLayoutPanel5.Controls.Add(pictureBox17, 2, 2);
            tableLayoutPanel5.Controls.Add(pictureBox20, 2, 5);
            tableLayoutPanel5.Controls.Add(pictureBox60, 2, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(236, 3);
            tableLayoutPanel5.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 6;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel5.Size = new Size(108, 216);
            tableLayoutPanel5.TabIndex = 2;
            // 
            // pictureBox65
            // 
            pictureBox65.Location = new Point(39, 183);
            pictureBox65.Name = "pictureBox65";
            pictureBox65.Size = new Size(30, 29);
            pictureBox65.TabIndex = 22;
            pictureBox65.TabStop = false;
            // 
            // pictureBox64
            // 
            pictureBox64.Location = new Point(39, 147);
            pictureBox64.Name = "pictureBox64";
            pictureBox64.Size = new Size(30, 29);
            pictureBox64.TabIndex = 21;
            pictureBox64.TabStop = false;
            // 
            // pictureBox63
            // 
            pictureBox63.Location = new Point(39, 111);
            pictureBox63.Name = "pictureBox63";
            pictureBox63.Size = new Size(30, 29);
            pictureBox63.TabIndex = 20;
            pictureBox63.TabStop = false;
            // 
            // pictureBox62
            // 
            pictureBox62.Location = new Point(39, 75);
            pictureBox62.Name = "pictureBox62";
            pictureBox62.Size = new Size(30, 29);
            pictureBox62.TabIndex = 19;
            pictureBox62.TabStop = false;
            // 
            // pictureBox61
            // 
            pictureBox61.Location = new Point(39, 39);
            pictureBox61.Name = "pictureBox61";
            pictureBox61.Size = new Size(30, 29);
            pictureBox61.TabIndex = 18;
            pictureBox61.TabStop = false;
            // 
            // pictureBox16
            // 
            pictureBox16.Location = new Point(75, 3);
            pictureBox16.Name = "pictureBox16";
            pictureBox16.Size = new Size(30, 29);
            pictureBox16.TabIndex = 12;
            pictureBox16.TabStop = false;
            // 
            // pictureBox15
            // 
            pictureBox15.Location = new Point(39, 3);
            pictureBox15.Name = "pictureBox15";
            pictureBox15.Size = new Size(30, 29);
            pictureBox15.TabIndex = 11;
            pictureBox15.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Location = new Point(3, 183);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(30, 29);
            pictureBox9.TabIndex = 5;
            pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            pictureBox10.Location = new Point(3, 147);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(30, 29);
            pictureBox10.TabIndex = 6;
            pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            pictureBox11.Location = new Point(3, 111);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(30, 29);
            pictureBox11.TabIndex = 7;
            pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            pictureBox12.Location = new Point(3, 75);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(30, 29);
            pictureBox12.TabIndex = 8;
            pictureBox12.TabStop = false;
            // 
            // pictureBox13
            // 
            pictureBox13.Location = new Point(3, 39);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(30, 29);
            pictureBox13.TabIndex = 9;
            pictureBox13.TabStop = false;
            // 
            // pictureBox14
            // 
            pictureBox14.Location = new Point(3, 3);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(30, 29);
            pictureBox14.TabIndex = 10;
            pictureBox14.TabStop = false;
            // 
            // pictureBox19
            // 
            pictureBox19.Location = new Point(75, 147);
            pictureBox19.Name = "pictureBox19";
            pictureBox19.Size = new Size(30, 29);
            pictureBox19.TabIndex = 15;
            pictureBox19.TabStop = false;
            // 
            // pictureBox18
            // 
            pictureBox18.Location = new Point(75, 111);
            pictureBox18.Name = "pictureBox18";
            pictureBox18.Size = new Size(30, 29);
            pictureBox18.TabIndex = 14;
            pictureBox18.TabStop = false;
            // 
            // pictureBox17
            // 
            pictureBox17.Location = new Point(75, 75);
            pictureBox17.Name = "pictureBox17";
            pictureBox17.Size = new Size(30, 29);
            pictureBox17.TabIndex = 13;
            pictureBox17.TabStop = false;
            // 
            // pictureBox20
            // 
            pictureBox20.Location = new Point(75, 183);
            pictureBox20.Name = "pictureBox20";
            pictureBox20.Size = new Size(30, 29);
            pictureBox20.TabIndex = 16;
            pictureBox20.TabStop = false;
            // 
            // pictureBox60
            // 
            pictureBox60.Location = new Point(75, 39);
            pictureBox60.Name = "pictureBox60";
            pictureBox60.Size = new Size(30, 29);
            pictureBox60.TabIndex = 17;
            pictureBox60.TabStop = false;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 6;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.9642849F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.9642849F));
            tableLayoutPanel6.Controls.Add(pictureBox89, 1, 1);
            tableLayoutPanel6.Controls.Add(pictureBox90, 4, 1);
            tableLayoutPanel6.Controls.Add(pictureBox91, 1, 4);
            tableLayoutPanel6.Controls.Add(pictureBox92, 4, 4);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(4, 336);
            tableLayoutPanel6.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 6;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel6.Size = new Size(224, 216);
            tableLayoutPanel6.TabIndex = 3;
            // 
            // pictureBox89
            // 
            pictureBox89.Location = new Point(40, 39);
            pictureBox89.Name = "pictureBox89";
            pictureBox89.Size = new Size(31, 29);
            pictureBox89.TabIndex = 5;
            pictureBox89.TabStop = false;
            // 
            // pictureBox90
            // 
            pictureBox90.Location = new Point(151, 39);
            pictureBox90.Name = "pictureBox90";
            pictureBox90.Size = new Size(31, 29);
            pictureBox90.TabIndex = 6;
            pictureBox90.TabStop = false;
            // 
            // pictureBox91
            // 
            pictureBox91.Location = new Point(40, 147);
            pictureBox91.Name = "pictureBox91";
            pictureBox91.Size = new Size(31, 29);
            pictureBox91.TabIndex = 7;
            pictureBox91.TabStop = false;
            // 
            // pictureBox92
            // 
            pictureBox92.Location = new Point(151, 147);
            pictureBox92.Name = "pictureBox92";
            pictureBox92.Size = new Size(31, 29);
            pictureBox92.TabIndex = 8;
            pictureBox92.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.66778F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33222F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel12, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.Size = new Size(884, 561);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel12
            // 
            tableLayoutPanel12.ColumnCount = 2;
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.Controls.Add(btnTirarDado, 0, 0);
            tableLayoutPanel12.Controls.Add(label1, 0, 1);
            tableLayoutPanel12.Location = new Point(592, 3);
            tableLayoutPanel12.Name = "tableLayoutPanel12";
            tableLayoutPanel12.RowCount = 2;
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.Size = new Size(200, 100);
            tableLayoutPanel12.TabIndex = 2;
            // 
            // btnTirarDado
            // 
            btnTirarDado.Location = new Point(3, 3);
            btnTirarDado.Name = "btnTirarDado";
            btnTirarDado.Size = new Size(75, 23);
            btnTirarDado.TabIndex = 3;
            btnTirarDado.Text = "Tirar dado";
            btnTirarDado.UseVisualStyleBackColor = true;
            btnTirarDado.Click += btnTirarDado_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 50);
            label1.MinimumSize = new Size(30, 15);
            label1.Name = "label1";
            label1.Size = new Size(94, 50);
            label1.TabIndex = 4;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(884, 561);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form2";
            Text = "Form2";
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox59).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox66).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox73).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox80).EndInit();
            tableLayoutPanel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox79).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox44).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox33).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox34).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox35).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox36).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox37).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox38).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox39).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox40).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox41).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox42).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox43).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox74).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox75).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox76).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox77).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox78).EndInit();
            tableLayoutPanel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox85).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox86).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox87).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox88).EndInit();
            tableLayoutPanel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            tableLayoutPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox81).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox82).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox83).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox84).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox72).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox26).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox25).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox24).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox23).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox22).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox21).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox27).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox28).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox29).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox30).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox31).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox32).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox67).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox68).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox69).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox70).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox71).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox58).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox57).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox56).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox55).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox54).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox53).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox52).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox45).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox46).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox47).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox48).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox49).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox50).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox51).EndInit();
            tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox65).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox64).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox63).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox62).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox61).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox19).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox18).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox17).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox20).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox60).EndInit();
            tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox89).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox90).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox91).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox92).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel12.ResumeLayout(false);
            tableLayoutPanel12.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel11;
        private TableLayoutPanel tableLayoutPanel10;
        private TableLayoutPanel tableLayoutPanel9;
        private TableLayoutPanel tableLayoutPanel8;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private TableLayoutPanel tableLayoutPanel7;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel12;
        private Button btnTirarDado;
        private Label label1;
        private PictureBox pictureBox59;
        private PictureBox pictureBox66;
        private PictureBox pictureBox73;
        private PictureBox pictureBox80;
        private PictureBox pictureBox79;
        private PictureBox pictureBox44;
        private PictureBox pictureBox33;
        private PictureBox pictureBox34;
        private PictureBox pictureBox35;
        private PictureBox pictureBox36;
        private PictureBox pictureBox37;
        private PictureBox pictureBox38;
        private PictureBox pictureBox39;
        private PictureBox pictureBox40;
        private PictureBox pictureBox41;
        private PictureBox pictureBox42;
        private PictureBox pictureBox43;
        private PictureBox pictureBox74;
        private PictureBox pictureBox75;
        private PictureBox pictureBox76;
        private PictureBox pictureBox77;
        private PictureBox pictureBox78;
        private PictureBox pictureBox85;
        private PictureBox pictureBox86;
        private PictureBox pictureBox87;
        private PictureBox pictureBox88;
        private PictureBox pictureBox81;
        private PictureBox pictureBox82;
        private PictureBox pictureBox83;
        private PictureBox pictureBox84;
        private PictureBox pictureBox72;
        private PictureBox pictureBox26;
        private PictureBox pictureBox25;
        private PictureBox pictureBox24;
        private PictureBox pictureBox23;
        private PictureBox pictureBox22;
        private PictureBox pictureBox21;
        private PictureBox pictureBox27;
        private PictureBox pictureBox28;
        private PictureBox pictureBox29;
        private PictureBox pictureBox30;
        private PictureBox pictureBox31;
        private PictureBox pictureBox32;
        private PictureBox pictureBox67;
        private PictureBox pictureBox68;
        private PictureBox pictureBox69;
        private PictureBox pictureBox70;
        private PictureBox pictureBox71;
        private PictureBox pictureBox58;
        private PictureBox pictureBox57;
        private PictureBox pictureBox56;
        private PictureBox pictureBox55;
        private PictureBox pictureBox54;
        private PictureBox pictureBox53;
        private PictureBox pictureBox52;
        private PictureBox pictureBox45;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox46;
        private PictureBox pictureBox47;
        private PictureBox pictureBox48;
        private PictureBox pictureBox49;
        private PictureBox pictureBox50;
        private PictureBox pictureBox51;
        private PictureBox pictureBox65;
        private PictureBox pictureBox64;
        private PictureBox pictureBox63;
        private PictureBox pictureBox62;
        private PictureBox pictureBox61;
        private PictureBox pictureBox16;
        private PictureBox pictureBox15;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private PictureBox pictureBox11;
        private PictureBox pictureBox12;
        private PictureBox pictureBox13;
        private PictureBox pictureBox14;
        private PictureBox pictureBox19;
        private PictureBox pictureBox18;
        private PictureBox pictureBox17;
        private PictureBox pictureBox20;
        private PictureBox pictureBox60;
        private PictureBox pictureBox89;
        private PictureBox pictureBox90;
        private PictureBox pictureBox91;
        private PictureBox pictureBox92;

        */
    }
}