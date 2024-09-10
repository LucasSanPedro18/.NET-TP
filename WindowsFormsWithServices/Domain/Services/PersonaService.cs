using Domain.Model;

namespace Domain.Services
{
    public class PersonaService 
    {
        public void Add(Persona persona)
        {
            using var context = new PersonaContext();

            context.Personas.Add(persona);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new PersonaContext();

            Persona? personaToDelete = context.Personas.Find(id);

            if (personaToDelete != null)
            {
                context.Personas.Remove(personaToDelete);
                context.SaveChanges();
            }
        }

        public Persona? Get(int id)
        {
            using var context = new PersonaContext();

            return context.Personas.Find(id);
        }

        public IEnumerable<Persona> GetAll()
        {
            using var context = new PersonaContext();

            return context.Personas.ToList();
        }

        public void Update(Persona persona)
        {
            using var context = new PersonaContext();

            Persona? personaToUpdate = context.Personas.Find(persona.Id);

            if (personaToUpdate != null)
            {
                if (persona.Nombre != null) personaToUpdate.Nombre = persona.Nombre;
                if (persona.Apellido != null) personaToUpdate.Apellido = persona.Apellido;
                if (persona.Direccion != null) personaToUpdate.Direccion = persona.Direccion;
                if (persona.Email != null) personaToUpdate.Email = persona.Email;
                if (persona.Telefono != null) personaToUpdate.Telefono = persona.Telefono;
                if (persona.Legajo != null) personaToUpdate.Legajo = persona.Legajo;
                if (persona.TipoPersona != null) personaToUpdate.TipoPersona = persona.TipoPersona;
                if (persona.FechaNac != null) personaToUpdate.FechaNac = persona.FechaNac;
                context.SaveChanges();
            }
        }
    }
}
