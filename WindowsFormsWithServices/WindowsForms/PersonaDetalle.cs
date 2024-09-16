using Domain.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class PersonaDetalle : Form
    {
        private Persona persona;

        public Persona Persona
        {
            get { return persona; }
            set
            {
                persona = value;
                this.SetPersona();
            }
        }

        //Probablemente un Enum seria mas apropiado        
        public bool EditMode { get; set; } = false;

        public PersonaDetalle()
        {
            InitializeComponent();
        }

        private async void aceptarButton_Click(object sender, EventArgs e)
        {
          
            PersonaApiClient client = new PersonaApiClient();

            if (this.Validatepersona())
            {
                this.Persona.Nombre = nombreTextBox.Text;
                this.Persona.Apellido = apellidoTextBox.Text;
                this.Persona.Email = emailTextBox.Text;
                this.Persona.Telefono = telefonoTextBox.Text;
                this.Persona.Direccion = direccionTextBox.Text;
                this.Persona.Legajo = int.Parse(legajoTextBox.Text); //Probar con el try parse
                this.Persona.TipoPersona = int.Parse(tipoTextBox.Text);
                this.Persona.FechaNac = fechaNacPicker.Text;


                //El Detalle se esta llevando la responsabilidad de llamar al servicio
                //pero tal vez deberia ser solo una vista y que esta responsabilidad quede
                //en la Lista o tal vez en un Presenter o Controler

                if (this.EditMode)
                {
                    await PersonaApiClient.UpdateAsync(this.Persona);
                }
                else
                {
                    await PersonaApiClient.AddAsync(this.Persona);
                }

                this.Close();
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetPersona()
        {
            this.nombreTextBox.Text = this.Persona.Nombre;
        }

        private bool Validatepersona()
        {
            bool isValid = true;

            errorProvider.SetError(nombreTextBox, string.Empty);

            if (this.nombreTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(nombreTextBox, "El Nombre es Requerido");
            }

            return isValid;
        }

    }
}
