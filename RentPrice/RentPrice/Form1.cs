using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentPrice
{
    public partial class frmRentPrice : Form
    {
        public frmRentPrice()
        {
            InitializeComponent();
        }

        private void btnCalculateRooms_Click(object sender, EventArgs e)
        {
            int[,] rents =
            {{ 400, 450, 510},
            {500, 560, 630},
            {625, 676, 740},
            {1000, 1250, 1600} };
            int floor;
            int bedrooms;

            floor = Convert.ToInt32(txtFloors.Text);
            bedrooms = Convert.ToInt32(txtRooms.Text);
            lblResult.Text = "The rent on that room is $" + rents[floor, bedrooms];
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            txtFloors.Text = "";
            txtRooms.Text = "";
        }
    }
}
