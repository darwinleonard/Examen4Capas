using Entidad;
using Negocio;
using System.Drawing;

namespace Presentacion
{
    public partial class Form1 : Form
    {

        Neg_Regions Nregion = new Neg_Regions();
        Ent_Regions Eregion = new Ent_Regions();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Crear_Click(object sender, EventArgs e)
        {
            try
            {
                Eregion.RegionName = txt_Nombre.Text;
                Nregion.Crear(Eregion);
                MessageBox.Show("Registrado correctamente", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
             

            }
            catch (Exception)
            {

                MessageBox.Show("Comunicarse con OTI");
            }
            dgv_Regions.DataSource = Nregion.Listar(btn_Actualizar.Text);
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Eregion.RegionId = Convert.ToInt32(txt_Id.Text);
                Nregion.Eliminar(Eregion);
                MessageBox.Show("Elimiinado correctamente", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {
                MessageBox.Show("Comunicarse con OTI", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dgv_Regions.DataSource = Nregion.Listar(btn_Actualizar.Text);
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            try
            {
                Eregion.RegionName = txt_Nombre.Text;
                Eregion.RegionId = Convert.ToInt32(txt_Id.Text);
                Nregion.Editar(Eregion);
                MessageBox.Show("Actualizado correctamente", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {

                MessageBox.Show("Comunicarse con OTI", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dgv_Regions.DataSource = Nregion.Listar(btn_Actualizar.Text);
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            dgv_Regions.DataSource = Nregion.Listar(btn_Actualizar.Text);
        }
    }
}
