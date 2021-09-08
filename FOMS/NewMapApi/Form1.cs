using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET.MapProviders;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Data.SqlClient;
using System.Net;
using System.IO;
using System.Xml;

namespace NewMapApi
{
    public partial class Form1 : Form
    {
        GMapControl position = new GMapControl();
        private List<PointLatLng> positionList = new List<PointLatLng>();
        private List<PointLatLng> fairWayList = new List<PointLatLng>();

        int year, month, day;
        string monthstring, daystring;

        DateTime dt;

        public Form1()
        {
            InitializeComponent();
            gMapControl1.DragButton = MouseButtons.Left;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Manager.Mode = AccessMode.ServerOnly;
            gMapControl1.Position = new PointLatLng(35.24, 128.2);
            gMapControl1.Zoom = 7;
        }

        private void gMapControl1_OnMapDrag()
        {
            //gMapControl1.Refresh();
            //gMapControl1.Position = position.Position;
        }

        private void gMapControl1_OnPositionChanged(PointLatLng point)
        {
            position.Position = point;

        }

        private void btnMarker_Click(object sender, EventArgs e)
        {
            GMapOverlay markers = new GMapOverlay();
            GMapMarker marker = new GMarkerGoogle(new PointLatLng(gMapControl1.Position.Lat, gMapControl1.Position.Lng), GMarkerGoogleType.blue_dot);
            markers.Markers.Add(marker);
            gMapControl1.Overlays.Add(markers);

            gMapControl1.Position = position.Position;
            gMapControl1.Refresh();

            positionList.Add(gMapControl1.Position);
        }

        private void btnDistance_Click(object sender, EventArgs e)
        {
            GMapOverlay routes = new GMapOverlay();
            GMapRoute route = new GMapRoute(positionList,"a");
            routes.Routes.Add(route);
            gMapControl1.Overlays.Add(routes);

            gMapControl1.Position = position.Position;
            gMapControl1.Refresh();
            
            double distance = route.Distance;
            MessageBox.Show(distance.ToString());
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            gMapControl1.Overlays.Clear();
            positionList.Clear();
            fairWayList.Clear();
            gMapControl1.Refresh();
            comboBox1.Text = "항로 선택";
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            if (tbLat.Text == "" || tbLng.Text == "") {
                MessageBox.Show("빈칸을 입력해 주세요.");
            }
            else
            {
                var insert = new PointLatLng();
                insert.Lat = Convert.ToDouble(tbLat.Text);
                insert.Lng = Convert.ToDouble(tbLng.Text);

                gMapControl1.Position = insert;
                gMapControl1.Refresh();
            }
        }

        private void gMapControl1_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            MessageBox.Show("좌표 : " + item.Position.ToString());
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            position.SetPositionByKeywords(tbSearch.Text);

            gMapControl1.Position = position.Position;
        }

        private void btnZoomP_Click(object sender, EventArgs e)
        {
            gMapControl1.Zoom = ((int)gMapControl1.Zoom) + 1;
        }

        private void btnZoomM_Click(object sender, EventArgs e)
        {
            gMapControl1.Zoom = ((int)(gMapControl1.Zoom + 0.99)) - 1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GMapOverlay routes = new GMapOverlay("routes");

            switch (comboBox1.Text)
            {
                case "1항로":
                    gMapControl1.Overlays.Clear();
                    GMapOverlay point1 = new GMapOverlay("markers");

                    fairWayList.Clear();

                    GMarkerGoogle p1 = new GMarkerGoogle(new PointLatLng(34.9976333, 128.4639194), GMarkerGoogleType.green_pushpin);
                    GMarkerGoogle p2 = new GMarkerGoogle(new PointLatLng(34.97354167, 128.4814028), GMarkerGoogleType.green_pushpin);
                    GMarkerGoogle p3 = new GMarkerGoogle(new PointLatLng(35.02056389, 128.6297972), GMarkerGoogleType.green_pushpin);
                    GMarkerGoogle p4 = new GMarkerGoogle(new PointLatLng(35.05329444, 128.6965389), GMarkerGoogleType.green_pushpin);
                    GMarkerGoogle p5 = new GMarkerGoogle(new PointLatLng(35.02176111, 128.7906333), GMarkerGoogleType.green_pushpin);
                    GMarkerGoogle p6 = new GMarkerGoogle(new PointLatLng(34.81855278, 128.8614861), GMarkerGoogleType.green_pushpin);
                    GMarkerGoogle p7 = new GMarkerGoogle(new PointLatLng(34.60358889, 128.6940722), GMarkerGoogleType.green_pushpin);
                    GMarkerGoogle p8 = new GMarkerGoogle(new PointLatLng(33.70414722, 127.1455694), GMarkerGoogleType.green_pushpin);
                    GMarkerGoogle p9 = new GMarkerGoogle(new PointLatLng(33.54196944, 126.1568111), GMarkerGoogleType.green_pushpin);
                    GMarkerGoogle p10 = new GMarkerGoogle(new PointLatLng(33.3496, 126.1224667), GMarkerGoogleType.green_pushpin);

                    point1.Markers.Add(p1);
                    fairWayList.Add(p1.Position);
                    point1.Markers.Add(p2);
                    fairWayList.Add(p2.Position);
                    point1.Markers.Add(p3);
                    fairWayList.Add(p3.Position);
                    point1.Markers.Add(p4);
                    fairWayList.Add(p4.Position);
                    point1.Markers.Add(p5);
                    fairWayList.Add(p5.Position);
                    point1.Markers.Add(p6);
                    fairWayList.Add(p6.Position);
                    point1.Markers.Add(p7);
                    fairWayList.Add(p7.Position);
                    point1.Markers.Add(p8);
                    fairWayList.Add(p8.Position);
                    point1.Markers.Add(p9);
                    fairWayList.Add(p9.Position);
                    point1.Markers.Add(p10);
                    fairWayList.Add(p10.Position);

                    GMapRoute route1 = new GMapRoute(fairWayList, "1항로");
                    route1.Stroke = new Pen(Color.Red, 3);
                    routes.Routes.Add(route1);
                    gMapControl1.Overlays.Add(routes);
                    gMapControl1.Overlays.Add(point1);

                    gMapControl1.Position = new PointLatLng(34.14, 127.47);

                    gMapControl1.Zoom = 8;

                    break;
                case "2항로":
                    gMapControl1.Overlays.Clear();

                    fairWayList.Clear();

                    GMapOverlay point2 = new GMapOverlay("markers");
                    GMarkerGoogle o1 = new GMarkerGoogle(new PointLatLng(34.99763333, 128.4639194), GMarkerGoogleType.red_pushpin);
                    GMarkerGoogle o2 = new GMarkerGoogle(new PointLatLng(34.97354167, 128.4814028), GMarkerGoogleType.red_pushpin);
                    GMarkerGoogle o3 = new GMarkerGoogle(new PointLatLng(34.922175, 128.47735), GMarkerGoogleType.red_pushpin);
                    GMarkerGoogle o4 = new GMarkerGoogle(new PointLatLng(34.91025556, 128.4815444), GMarkerGoogleType.red_pushpin);
                    GMarkerGoogle o5 = new GMarkerGoogle(new PointLatLng(34.89288889, 128.4782444), GMarkerGoogleType.red_pushpin);
                    GMarkerGoogle o6 = new GMarkerGoogle(new PointLatLng(34.87413056, 128.4696056), GMarkerGoogleType.red_pushpin);
                    GMarkerGoogle o7 = new GMarkerGoogle(new PointLatLng(34.85554722, 128.4724611), GMarkerGoogleType.red_pushpin);
                    GMarkerGoogle o8 = new GMarkerGoogle(new PointLatLng(34.83441389, 128.4480111), GMarkerGoogleType.red_pushpin);
                    GMarkerGoogle o9 = new GMarkerGoogle(new PointLatLng(34.47875833, 128.4072528), GMarkerGoogleType.red_pushpin);
                    GMarkerGoogle o10 = new GMarkerGoogle(new PointLatLng(33.70414722, 127.1455694), GMarkerGoogleType.red_pushpin);
                    GMarkerGoogle o11 = new GMarkerGoogle(new PointLatLng(33.54196944, 126.1568111), GMarkerGoogleType.red_pushpin);
                    GMarkerGoogle o12 = new GMarkerGoogle(new PointLatLng(33.3496, 126.1224667), GMarkerGoogleType.red_pushpin);

                    point2.Markers.Add(o1);
                    fairWayList.Add(o1.Position);
                    point2.Markers.Add(o2);
                    fairWayList.Add(o2.Position);
                    point2.Markers.Add(o3);
                    fairWayList.Add(o3.Position);
                    point2.Markers.Add(o4);
                    fairWayList.Add(o4.Position);
                    point2.Markers.Add(o5);
                    fairWayList.Add(o5.Position);
                    point2.Markers.Add(o6);
                    fairWayList.Add(o6.Position);
                    point2.Markers.Add(o7);
                    fairWayList.Add(o7.Position);
                    point2.Markers.Add(o8);
                    fairWayList.Add(o8.Position);
                    point2.Markers.Add(o9);
                    fairWayList.Add(o9.Position);
                    point2.Markers.Add(o10);
                    fairWayList.Add(o10.Position);
                    point2.Markers.Add(o11);
                    fairWayList.Add(o11.Position);
                    point2.Markers.Add(o12);
                    fairWayList.Add(o12.Position);

                    gMapControl1.Overlays.Add(point2);

                    GMapRoute route2 = new GMapRoute(fairWayList, "2항로");
                    route2.Stroke = new Pen(Color.Yellow, 3);
                    routes.Routes.Add(route2);
                    gMapControl1.Overlays.Add(routes);
                    gMapControl1.Position = new PointLatLng(34.2231580253797, 127.339782714844);
                    gMapControl1.Zoom = 8;
                    break;
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (cbLastTime.Text == "시간")
            {
                MessageBox.Show("시간을 선택하세요.");
            }
            else
            {
                string time = cbLastTime.Text.Substring(0, 2);

                SqlConnection conn = new SqlConnection("Server=1.220.15.197; Database=TEST; uid=TEST; pwd=p@ssw0rd!123");

                conn.Open();

                string strSql_Select = "select year,month,day,currentSpeed, currentDirect from dbo.sample1 where month=" + month + " and day=" + day + "and time=" + time + " order by year asc";
                string strSql_avg = "select avg(case when currentSpeed is null then 0 else currentSpeed END)평균유속 from dbo.sample1 where month=" + month + " and day=" + day + " and time=" + time + "";

                SqlCommand cmd = new SqlCommand(strSql_Select, conn);
                SqlCommand cmd2 = new SqlCommand(strSql_avg, conn);

                SqlDataReader dr = cmd.ExecuteReader();

                int n = 0;

                lvLast.Items.Clear();
                while (dr.Read())
                {
                    n++;
                    ListViewItem item = new ListViewItem(n.ToString());
                    item.SubItems.Add(dr["year"].ToString());
                    item.SubItems.Add(dr["month"].ToString());
                    item.SubItems.Add(dr["day"].ToString());
                    item.SubItems.Add(dr["currentSpeed"].ToString() + " cm/s");
                    item.SubItems.Add(dr["currentDirect"].ToString() + " deg");

                    lvLast.Items.Add(item);
                }
                dr.Close();

                tbAvgSpeed.Text = cmd2.ExecuteScalar().ToString() + " cm/s";
                conn.Close();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dt = dateTimePicker1.Value;
            year = dt.Year;
            month = dt.Month;
            day = dt.Day;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dt = dateTimePicker2.Value;
            year = dt.Year;
            month = dt.Month;
            day = dt.Day;
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            tbLat2.Text = gMapControl1.Position.Lat.ToString();
            tbLng2.Text = gMapControl1.Position.Lng.ToString();
        }

        private void cbToday_SelectedIndexChanged(object sender, EventArgs e)
        {
            gMapControl1.Overlays.Clear();
            GMapOverlay point = new GMapOverlay();
            switch (cbToday.Text)
            {
                case "마산항":
                    GMarkerGoogle p1 = new GMarkerGoogle(new PointLatLng(35.10319, 128.6318), GMarkerGoogleType.green_big_go);
                    point.Markers.Add(p1);
                    break;

                case "부산항신항":
                    GMarkerGoogle p2 = new GMarkerGoogle(new PointLatLng(35.04378, 128.7618), GMarkerGoogleType.green_big_go);
                    point.Markers.Add(p2);
                    break;

                case "남해동부":
                    GMarkerGoogle p3 = new GMarkerGoogle(new PointLatLng(34.22247, 128.419), GMarkerGoogleType.green_big_go);
                    point.Markers.Add(p3);
                    break;

                case "제주해협":
                    GMarkerGoogle p4 = new GMarkerGoogle(new PointLatLng(33.91181, 126.4921), GMarkerGoogleType.green_big_go);
                    point.Markers.Add(p4);
                    break;

                case "통영항":
                    GMarkerGoogle p5 = new GMarkerGoogle(new PointLatLng(34.77333, 128.46), GMarkerGoogleType.green_big_go);
                    point.Markers.Add(p5);
                    break;

                case "중문해수욕장":
                    GMarkerGoogle p6 = new GMarkerGoogle(new PointLatLng(33.23444, 126.4097), GMarkerGoogleType.green_big_go);
                    point.Markers.Add(p6);
                    break;
            }
            gMapControl1.Overlays.Add(point);
            gMapControl1.Position = new PointLatLng(34.2231580253797, 127.539782714844);
            gMapControl1.Zoom = 8;
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            string ServiceKey = "488cpMHiLM5jeDssAcQug==";
            string ObcCode = "";

            switch (cbToday.Text)
            {
                case "마산항":
                    ObcCode = "TW_0085"; break;
                case "부산항신항":
                    ObcCode = "TW_0086"; break;
                case "남해동부":
                    ObcCode = "KG_0025"; break;
                case "제주해협":
                    ObcCode = "KG_0028"; break;
                case "통영항":
                    ObcCode = "TW_0084"; break;
                case "중문해수욕장":
                    ObcCode = "TW_0075"; break;
            }

            string query = "http://www.khoa.go.kr/oceangrid/grid/api/buObsRecent/search.do?ServiceKey=" + ServiceKey + "&ObsCode=" + ObcCode + "&ResultType=xml";

            WebRequest wr = WebRequest.Create(query);
            wr.Method = "GET";
            WebResponse wrs = wr.GetResponse();
            Stream s = wrs.GetResponseStream();
            StreamReader sr = new StreamReader(s);
            string response = sr.ReadToEnd();

            XmlDocument xd = new XmlDocument();
            xd.LoadXml(response);

            XmlNode xn = xd["result"]["data"];
            ListViewItem lvi = new ListViewItem();

            lvi.Text = cbToday.Text;
            lvi.SubItems.Add(xn["record_time"].InnerText);//관측시간
            lvi.SubItems.Add(xn["wind_dir"].InnerText + " deg");//풍향
            lvi.SubItems.Add(xn["wind_speed"].InnerText + " m/s");//풍속
            lvi.SubItems.Add(xn["current_dir"].InnerText + " deg");//유향
            lvi.SubItems.Add(xn["current_speed"].InnerText + " m/s");//유속
            lvi.SubItems.Add(xn["wave_height"].InnerText);//파고

            lvToday.Items.Add(lvi);
        }

        private void btnFuture_Click(object sender, EventArgs e)
        {
            if (tbLng2.Text == "" || tbLat2.Text == "")
            {
                MessageBox.Show("위치를 입력해 주세요.");
                return;
            }
            else if (cbFuture.Text == "시간")
            {
                MessageBox.Show("시간을 선택해 주세요.");
                return;
            }
            else
            {
                string ObsLon = tbLng2.Text;
                string ObsLat = tbLat2.Text;

                string query = "http://www.khoa.go.kr/oceangrid/grid/api/romsCurrent/search.do?" +
                    "ServiceKey=488cpMHiLM5jeDssAcQug==" +
                    "&ObsLon=" + ObsLon + "&ObsLat=" + ObsLat +
                    "&ResultType=xml";

                WebRequest wr = WebRequest.Create(query);
                wr.Method = "GET";
                WebResponse wrs = wr.GetResponse();
                Stream s = wrs.GetResponseStream();
                StreamReader sr = new StreamReader(s);
                string response = sr.ReadToEnd();

                XmlDocument xd = new XmlDocument();
                xd.LoadXml(response);

                XmlNode xn = xd["result"];

                int n = 0;
                int num = 0;
                for (int i = 1; i < xn.ChildNodes.Count; i++)
                {
                    n++;
                    string date = xn.ChildNodes[i]["date"].InnerText;
                    string hour = xn.ChildNodes[i]["hour"].InnerText;

                    if (month >= 1 && month <= 9)
                    {
                        monthstring = "0" + month.ToString();
                    }

                    if (day >= 1 && day <= 9)
                    {
                        daystring = "0" + day.ToString();
                    }

                    if (date.Equals(year.ToString() + monthstring + daystring))
                    {
                        if (hour == cbFuture.Text)
                        {
                            num++;
                            ListViewItem lvi = new ListViewItem(num.ToString());
                            lvi.SubItems.Add(xn.ChildNodes[i]["date"].InnerText);
                            lvi.SubItems.Add(xn.ChildNodes[i]["hour"].InnerText);
                            lvi.SubItems.Add(xn.ChildNodes[i]["current_speed"].InnerText);
                            lvi.SubItems.Add(xn.ChildNodes[i]["current_direct"].InnerText);

                            lvFuture.Items.Add(lvi);
                        }
                    }
                }

                GMapOverlay point1 = new GMapOverlay("markers");
                GMarkerGoogle p1 = new GMarkerGoogle(new PointLatLng(double.Parse(tbLat2.Text), double.Parse(tbLng2.Text)), GMarkerGoogleType.lightblue_pushpin);
                point1.Markers.Add(p1);
                gMapControl1.Overlays.Add(point1);
                gMapControl1.Position = new PointLatLng(double.Parse(tbLat2.Text), double.Parse(tbLng2.Text));
                gMapControl1.Zoom = 9;
            }
        }
    }
}
