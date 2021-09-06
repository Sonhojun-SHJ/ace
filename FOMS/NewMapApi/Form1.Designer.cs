
namespace NewMapApi
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.btnMarker = new System.Windows.Forms.Button();
            this.btnDistance = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tbLat = new System.Windows.Forms.TextBox();
            this.tbLng = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMove = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbLastTime = new System.Windows.Forms.ComboBox();
            this.btnLast = new System.Windows.Forms.Button();
            this.lvLast = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.tbAvgSpeed = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbToday = new System.Windows.Forms.ComboBox();
            this.btnToday = new System.Windows.Forms.Button();
            this.lvToday = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.tbLat2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbLng2 = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.cbFuture = new System.Windows.Forms.ComboBox();
            this.btnFuture = new System.Windows.Forms.Button();
            this.lvFuture = new System.Windows.Forms.ListView();
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnZoomP = new System.Windows.Forms.Button();
            this.btnZoomM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(14, 14);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 18;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(520, 520);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.gMapControl1_OnMarkerClick);
            this.gMapControl1.OnPositionChanged += new GMap.NET.PositionChanged(this.gMapControl1_OnPositionChanged);
            this.gMapControl1.OnMapDrag += new GMap.NET.MapDrag(this.gMapControl1_OnMapDrag);
            // 
            // btnMarker
            // 
            this.btnMarker.Location = new System.Drawing.Point(540, 14);
            this.btnMarker.Name = "btnMarker";
            this.btnMarker.Size = new System.Drawing.Size(152, 75);
            this.btnMarker.TabIndex = 1;
            this.btnMarker.Text = "마커";
            this.btnMarker.UseVisualStyleBackColor = true;
            this.btnMarker.Click += new System.EventHandler(this.btnMarker_Click);
            // 
            // btnDistance
            // 
            this.btnDistance.Location = new System.Drawing.Point(540, 95);
            this.btnDistance.Name = "btnDistance";
            this.btnDistance.Size = new System.Drawing.Size(152, 75);
            this.btnDistance.TabIndex = 2;
            this.btnDistance.Text = "거리";
            this.btnDistance.UseVisualStyleBackColor = true;
            this.btnDistance.Click += new System.EventHandler(this.btnDistance_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(540, 176);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(152, 75);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "화면\r\n\r\n초기화";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // tbLat
            // 
            this.tbLat.Location = new System.Drawing.Point(592, 259);
            this.tbLat.Name = "tbLat";
            this.tbLat.Size = new System.Drawing.Size(100, 21);
            this.tbLat.TabIndex = 4;
            // 
            // tbLng
            // 
            this.tbLng.Location = new System.Drawing.Point(592, 286);
            this.tbLng.Name = "tbLng";
            this.tbLng.Size = new System.Drawing.Size(100, 21);
            this.tbLng.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(548, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "위도";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(548, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "경도";
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(540, 313);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(152, 75);
            this.btnMove.TabIndex = 7;
            this.btnMove.Text = "좌표 이동";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(14, 540);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(520, 21);
            this.tbSearch.TabIndex = 8;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(540, 540);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(152, 23);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1항로",
            "2항로"});
            this.comboBox1.Location = new System.Drawing.Point(540, 423);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 20);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.Text = "항로 선택";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(719, 15);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(169, 21);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // cbLastTime
            // 
            this.cbLastTime.FormattingEnabled = true;
            this.cbLastTime.Items.AddRange(new object[] {
            "00:00",
            "01:00",
            "02:00",
            "03:00",
            "04:00",
            "05:00",
            "06:00",
            "07:00",
            "08:00",
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00",
            "22:00",
            "23:00"});
            this.cbLastTime.Location = new System.Drawing.Point(899, 15);
            this.cbLastTime.Name = "cbLastTime";
            this.cbLastTime.Size = new System.Drawing.Size(95, 20);
            this.cbLastTime.TabIndex = 12;
            this.cbLastTime.Text = "시간";
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(1000, 13);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(241, 23);
            this.btnLast.TabIndex = 13;
            this.btnLast.Text = "과거 유속/유향 데이터";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // lvLast
            // 
            this.lvLast.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvLast.FullRowSelect = true;
            this.lvLast.HideSelection = false;
            this.lvLast.Location = new System.Drawing.Point(719, 42);
            this.lvLast.Name = "lvLast";
            this.lvLast.Size = new System.Drawing.Size(522, 128);
            this.lvLast.TabIndex = 14;
            this.lvLast.UseCompatibleStateImageBehavior = false;
            this.lvLast.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No.";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "년";
            this.columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "월";
            this.columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "일";
            this.columnHeader4.Width = 70;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "유속";
            this.columnHeader5.Width = 90;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "풍향";
            this.columnHeader6.Width = 90;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(987, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "평균 유속";
            // 
            // tbAvgSpeed
            // 
            this.tbAvgSpeed.Enabled = false;
            this.tbAvgSpeed.Location = new System.Drawing.Point(1050, 176);
            this.tbAvgSpeed.Name = "tbAvgSpeed";
            this.tbAvgSpeed.Size = new System.Drawing.Size(100, 21);
            this.tbAvgSpeed.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(717, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 17;
            this.label4.Text = "관측소";
            // 
            // cbToday
            // 
            this.cbToday.FormattingEnabled = true;
            this.cbToday.Items.AddRange(new object[] {
            "마산항",
            "부산항신항",
            "남해동부",
            "제주해협",
            "통영항",
            "중문해수욕장"});
            this.cbToday.Location = new System.Drawing.Point(764, 204);
            this.cbToday.Name = "cbToday";
            this.cbToday.Size = new System.Drawing.Size(230, 20);
            this.cbToday.TabIndex = 18;
            this.cbToday.SelectedIndexChanged += new System.EventHandler(this.cbToday_SelectedIndexChanged);
            // 
            // btnToday
            // 
            this.btnToday.Location = new System.Drawing.Point(1000, 202);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(241, 23);
            this.btnToday.TabIndex = 19;
            this.btnToday.Text = "현재 관측소 별 관측 데이터";
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // lvToday
            // 
            this.lvToday.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13});
            this.lvToday.HideSelection = false;
            this.lvToday.Location = new System.Drawing.Point(719, 230);
            this.lvToday.Name = "lvToday";
            this.lvToday.Size = new System.Drawing.Size(522, 142);
            this.lvToday.TabIndex = 20;
            this.lvToday.UseCompatibleStateImageBehavior = false;
            this.lvToday.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "관측소명";
            this.columnHeader7.Width = 70;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "관측시간";
            this.columnHeader8.Width = 125;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "풍향";
            this.columnHeader9.Width = 75;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "풍속";
            this.columnHeader10.Width = 65;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "유향";
            this.columnHeader11.Width = 70;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "유속";
            this.columnHeader12.Width = 70;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "파고";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.ForeColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(705, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 547);
            this.panel1.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(720, 387);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 22;
            this.label5.Text = "위도";
            // 
            // tbLat2
            // 
            this.tbLat2.Location = new System.Drawing.Point(755, 382);
            this.tbLat2.Name = "tbLat2";
            this.tbLat2.Size = new System.Drawing.Size(111, 21);
            this.tbLat2.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(720, 414);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 22;
            this.label6.Text = "경도";
            // 
            // tbLng2
            // 
            this.tbLng2.Location = new System.Drawing.Point(755, 409);
            this.tbLng2.Name = "tbLng2";
            this.tbLng2.Size = new System.Drawing.Size(111, 21);
            this.tbLng2.TabIndex = 24;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(888, 382);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker2.TabIndex = 25;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // cbFuture
            // 
            this.cbFuture.FormattingEnabled = true;
            this.cbFuture.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cbFuture.Location = new System.Drawing.Point(1094, 382);
            this.cbFuture.Name = "cbFuture";
            this.cbFuture.Size = new System.Drawing.Size(147, 20);
            this.cbFuture.TabIndex = 26;
            this.cbFuture.Text = "시간";
            // 
            // btnFuture
            // 
            this.btnFuture.Location = new System.Drawing.Point(888, 407);
            this.btnFuture.Name = "btnFuture";
            this.btnFuture.Size = new System.Drawing.Size(353, 23);
            this.btnFuture.TabIndex = 27;
            this.btnFuture.Text = "예측 데이터 조회";
            this.btnFuture.UseVisualStyleBackColor = true;
            this.btnFuture.Click += new System.EventHandler(this.btnFuture_Click);
            // 
            // lvFuture
            // 
            this.lvFuture.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18});
            this.lvFuture.HideSelection = false;
            this.lvFuture.Location = new System.Drawing.Point(722, 437);
            this.lvFuture.Name = "lvFuture";
            this.lvFuture.Size = new System.Drawing.Size(519, 123);
            this.lvFuture.TabIndex = 26;
            this.lvFuture.UseCompatibleStateImageBehavior = false;
            this.lvFuture.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "No.";
            this.columnHeader14.Width = 40;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "날짜";
            this.columnHeader15.Width = 120;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "시간";
            this.columnHeader16.Width = 50;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "유속";
            this.columnHeader17.Width = 70;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "유향";
            this.columnHeader18.Width = 70;
            // 
            // btnZoomP
            // 
            this.btnZoomP.Location = new System.Drawing.Point(541, 394);
            this.btnZoomP.Name = "btnZoomP";
            this.btnZoomP.Size = new System.Drawing.Size(70, 23);
            this.btnZoomP.TabIndex = 28;
            this.btnZoomP.Text = "줌 +";
            this.btnZoomP.UseVisualStyleBackColor = true;
            this.btnZoomP.Click += new System.EventHandler(this.btnZoomP_Click);
            // 
            // btnZoomM
            // 
            this.btnZoomM.Location = new System.Drawing.Point(622, 394);
            this.btnZoomM.Name = "btnZoomM";
            this.btnZoomM.Size = new System.Drawing.Size(70, 23);
            this.btnZoomM.TabIndex = 29;
            this.btnZoomM.Text = "줌 -";
            this.btnZoomM.UseVisualStyleBackColor = true;
            this.btnZoomM.Click += new System.EventHandler(this.btnZoomM_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 572);
            this.Controls.Add(this.btnZoomM);
            this.Controls.Add(this.btnZoomP);
            this.Controls.Add(this.lvFuture);
            this.Controls.Add(this.btnFuture);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.tbLng2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbLat2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lvToday);
            this.Controls.Add(this.btnToday);
            this.Controls.Add(this.cbToday);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbAvgSpeed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lvLast);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.cbFuture);
            this.Controls.Add(this.cbLastTime);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbLng);
            this.Controls.Add(this.tbLat);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDistance);
            this.Controls.Add(this.btnMarker);
            this.Controls.Add(this.gMapControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Button btnMarker;
        private System.Windows.Forms.Button btnDistance;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox tbLat;
        private System.Windows.Forms.TextBox tbLng;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbLastTime;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.ListView lvLast;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAvgSpeed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbToday;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.ListView lvToday;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbLat2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbLng2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox cbFuture;
        private System.Windows.Forms.Button btnFuture;
        private System.Windows.Forms.ListView lvFuture;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.Button btnZoomP;
        private System.Windows.Forms.Button btnZoomM;
    }
}

