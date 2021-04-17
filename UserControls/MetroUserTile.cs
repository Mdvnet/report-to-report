using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportToReport.UserControls
{
    public partial class MetroUserTile : UserControl
    {
        public MetroUserTile()
        {
            InitializeComponent();
            this.Align = MetroSet_UI.Enums.TileAlign.BottmLeft;
        }
        public string Title
        {
            get { return metroSetTile1.Text; }
            set { metroSetTile1.Text = value; } 
        }
        

        public MetroSet_UI.Enums.TileAlign Align
        {
            get { return metroSetTile1.TileAlign; }
            set { metroSetTile1.TileAlign = value; }
        }

        private void metroSetTile1_Click(object sender, EventArgs e)
        {

        }
    }
}
