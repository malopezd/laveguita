using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LaVeguita.API.Models;
using LaVeguita.API.Services;
using LaVeguita.API.Configs;
using LaVeguita.API.Services.Implementation;
using LaVeguita.API.Services.Repositorio;
using LaVeguita.API.Services.Servicios;
using LaVeguita.API.DbContextos;
using LaVeguita.API.RepositorioDB;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();


namespace LaVeguita.API
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Creando DB...");
			VentaContext db = new VentaContext();
			db.Database.EnsureCreated();
			Console.WriteLine("Ok");
			Console.ReadKey();
		}
	}
}

