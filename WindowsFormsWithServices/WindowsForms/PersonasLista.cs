using Domain.Model;

namespace WindowsForms
{
    public partial class PersonasLista : Form
    {
        public PersonasLista()
        {
            InitializeComponent();
        }

        private void Personas_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            PersonaDetalle personaDetalle = new PersonaDetalle();

            Persona personaNuevo = new Persona();

            personaDetalle.Persona = personaNuevo;

            personaDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void modificarButton_Click(object sender, EventArgs e)
        {
            PersonaDetalle personaDetalle = new PersonaDetalle();
           
            int id;

            id = this.SelectedItem().Id;

            Persona persona = await PersonaApiClient.GetAsync(id);

            personaDetalle.EditMode = true;
            personaDetalle.Persona = persona;

            personaDetalle.ShowDialog();

            this.GetAllAndLoad();
        }

        private async void eliminarButton_Click(object sender, EventArgs e)
        {
            int id;

            id = this.SelectedItem().Id;
            await PersonaApiClient.DeleteAsync(id);

            this.GetAllAndLoad();
        }

        private async void GetAllAndLoad()
        {
            PersonaApiClient client = new PersonaApiClient();

            this.personasDataGridView.DataSource = null;
            this.personasDataGridView.DataSource = await PersonaApiClient.GetAllAsync();

            if (this.personasDataGridView.Rows.Count > 0)
            {
                this.personasDataGridView.Rows[0].Selected = true;
                this.eliminarButton.Enabled = true;
                this.modificarButton.Enabled = true;
            }
            else
            {
                this.eliminarButton.Enabled = false;
                this.modificarButton.Enabled = false;
            }
        }

        private Persona SelectedItem()
        {
            Persona persona;

            persona = (Persona)personasDataGridView.SelectedRows[0].DataBoundItem;

            return persona;
        }


    }
}