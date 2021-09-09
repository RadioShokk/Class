using Infraestructure.Productos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductosM1.Forms
{
    public partial class FrmProductManage : Form
    {
        private ProductoModel productoModel;
        public FrmProductManage()
        {
            productoModel = new ProductoModel();
            InitializeComponent();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbFinder.SelectedIndex)
            {
                case 0:
                    pnlID.Visible = true;
                    pnlCaducity.Visible = false;
                    pnlUM.Visible = false;
                    pnlRankprice.Visible = false;
                    break;
                case 1:
                    pnlID.Visible = false;
                    pnlCaducity.Visible = false;
                    pnlUM.Visible = true;
                    pnlRankprice.Visible = false;
                    break;
                case 2:
                    pnlID.Visible = false;
                    pnlCaducity.Visible = false;
                    pnlUM.Visible = false;
                    pnlRankprice.Visible = true;
                    break;
                case 3:
                    pnlID.Visible = false;
                    pnlCaducity.Visible = true;
                    pnlUM.Visible = false;
                    pnlRankprice.Visible = false;
                    break;
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            FrmProducto frmProducto = new FrmProducto();
            frmProducto.PModel = productoModel;
            frmProducto.ShowDialog();

            rtb
        }
    }
}
