using GestionProyectos.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

using GestionProyectos.Client.Services;
using CurrieTechnologies.Razor.SweetAlert2;
using Blazored.Modal;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5122") });
builder.Services.AddScoped<IUsuario, UsuarioService>();
builder.Services.AddScoped<IProyecto, ProyectoService>();
builder.Services.AddScoped<ITarea, TareaService>();
builder.Services.AddScoped<IAdministrador, AdministradorService>();

builder.Services.AddSweetAlert2();
builder.Services.AddBlazoredModal();

await builder.Build().RunAsync();
