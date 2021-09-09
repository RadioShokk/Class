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
    public partial class FrmProducto : Form
    {
        public ProductoModel PModel { get; set; }
        public FrmProducto()
        {

            InitializeComponent();
        }


        private void BtnOK_Click(object sender, EventArgs e)
        {
            Producto p = new Producto()
            {
                Id = PModel.GetLastProductoId() + 1,
                Nombre = txtName.Text,
                Descripcion = txtDesc.Text,
                Existencia = (int)nudExis.Value,
                Precio = nudPrice.Value,
                FechaVencimiento = dtpCaducity.Value,
                UnidadMedida = (UnidadMedida)cmbMeasureUnit.SelectIndex
            };
            PModel.Add
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {

        }
    }
}
