using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms;
using GMap.NET;
using GMap.NET.MapProviders;

namespace Threats
{
    public partial class Threats : Form
    {
        public Threats()
        {
            InitializeComponent();
        }

        private void Threats_Load(object sender, EventArgs e)
        {
            /*Ping ping = new Ping();
            //ping.Send("http://maps.google.com");
            PingOptions ops = new PingOptions();
            ops.DontFragment = true;
            string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            byte[] buff = Encoding.ASCII.GetBytes (data);
            int timeout = 10;
            PingReply reply = ping.Send ("http://maps.google.com", timeout, buff, ops);
            if (reply.Status == IPStatus.Success)
            {*/
                gmap.DragButton = MouseButtons.Left;
                gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
                GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
                gmap.EmptyMapBackground = System.Drawing.Color.DarkGray;
                gmap.SetPositionByKeywords("Shipka, Bulgaria");
            //}
            gmap.ShowCenter = false;
            GMapOverlay markersOverlay = new GMapOverlay("markers");
            GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(42.696552, 23.32601), GMarkerGoogleType.blue_pushpin);
            gmap.Overlays.Add(markersOverlay);
            markersOverlay.Markers.Add(marker);
            gmap.FillEmptyTiles = true;
        }
        
        
    }
}
