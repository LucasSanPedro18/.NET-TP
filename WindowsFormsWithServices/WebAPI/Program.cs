using Domain.Services;
using Domain.Model;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpLogging(o => { });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    //Falta configurar de manera correcta        
    app.UseHttpLogging();
}

app.UseHttpsRedirection();

//Actualmente estamos usando los objetos del Domain Model, deberiamos usar ViewModels o DTOs         


app.MapGet("/personas/{id}", (int id) =>
{
    PersonaService personaService = new PersonaService();

    return personaService.Get(id);
})
.WithName("Getpersona")
.WithOpenApi();

app.MapGet("/personas", () =>
{
    PersonaService personaService = new PersonaService();

    return personaService.GetAll();
})
.WithName("GetAllpersonas")
.WithOpenApi();

app.MapPost("/personas", (Persona persona) =>
{
    PersonaService personaService = new PersonaService();

    personaService.Add(persona);
})
.WithName("Addpersona")
.WithOpenApi();

app.MapPut("/personas", (Persona persona) =>
{
    PersonaService personaService = new PersonaService();

    personaService.Update(persona);
})
.WithName("Updatepersona")
.WithOpenApi();

app.MapDelete("/personas/{id}", (int id) =>
{
    PersonaService personaService = new PersonaService();

    personaService.Delete(id);
})
.WithName("Deletepersona")
.WithOpenApi();

app.Run();
