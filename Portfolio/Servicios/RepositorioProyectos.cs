using Portfolio.Interfaces;
using Portfolio.Models;

namespace Portfolio.Servicios
{
    public class RepositorioProyectos : IRepositorioProyectos
    {
        public List<ProyectoDTO> ObtenerProyectos()
        {

            return new List<ProyectoDTO>()
            {
                new ProyectoDTO
                {
                    Titulo = "Recipe App",
                    Descripcion = "Proyecto individual realizado en la primer etapa de labs en Henry. Es una SPA donde se pueden buscar, ordenar, filtrar, crear y eliminar recetas.",
                    Link = "https://github.com/samueltribulo/Foods-proyect",
                    ImageURL = "/imagenes/recipeapp.png",
                    Tecnologias = "React, Redux, NodeJS, ExpressJs, PostgreSQL, Sequelize."
                },                
                new ProyectoDTO
                {
                    Titulo = "Exmine",
                    Descripcion = "Proyecto grupal realizado en la etapa final de labs en Henry. Es un ecommerce enfocado a la venta de insumos para la mineria de criptomonedas.",
                    Link = "https://github.com/ortega-pablo/Final-Project",
                    ImageURL = "/imagenes/exmine.png",
                    Tecnologias = "React, Redux, NodeJS, ExpressJs, PostgreSQL, Sequelize, MaterialUI."
                },                
                new ProyectoDTO
                {
                    Titulo = "Portfolio React (Desactualizado)",
                    Descripcion = "Portfolio personal realizado con el fin de mostrar un poco sobre mi, mis proyectos y para que puedan contactarme.",
                    Link = "https://github.com/samueltribulo/Portfolio",
                    ImageURL = "/imagenes/portfolio.png",
                    Tecnologias = "React, SASS"
                },                
                new ProyectoDTO
                {
                    Titulo = "HeroesApp",
                    Descripcion = "SPA creada con para repasar filtros y ruteo en React.",
                    Link = "https://github.com/samueltribulo/heroes-app",
                    ImageURL = "/imagenes/heroesApp.PNG",
                    Tecnologias = "React, MaterialUI"
                },
                new ProyectoDTO
                {
                    Titulo = "GiphyApp",
                    Descripcion = "Aplicación creada para repasar un poco el consumo de APIs y para aprender buenas practicas como los custom hooks, en este caso consumí la API de giphy.",
                    Link = "https://github.com/samueltribulo/giphyApp",
                    ImageURL = "/imagenes/giphyApp.PNG",
                    Tecnologias = "React"
                },                
                new ProyectoDTO
                {
                    Titulo = "JournalApp",
                    Descripcion = "Aplicación creada para repasar conceptos de Redux, utilizando Redux ToolKit en React.",
                    Link = "https://github.com/samueltribulo/JournalApp",
                    ImageURL = "/imagenes/JournalApp.PNG",
                    Tecnologias = "React, Redux"
                },                
                new ProyectoDTO
                {
                    Titulo = "App manejo de presupuestos",
                    Descripcion = "Aplicación de manejo de presupuestos en ASP.NET MVC (En desarrollo)",
                    Link = "#",
                    ImageURL = "/imagenes/DotNet.png",
                    Tecnologias = "ASP.NET 6, Dapper"
                },                
            };

        }




    }
}
