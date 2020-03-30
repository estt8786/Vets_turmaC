﻿ using ClinicaVet.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicaVet.Data
{
    /// <summary>
    /// Representa a BD do nosso sistema (clinica veterinaria)
    /// á custa de um ORM (object relation Model) - Entity FrameWork Core (mais uma camada sobre o nosso serviço)
    /// </summary>
    public class VetsDB : DbContext
    {

        /// <summary>
        /// construtor que define e configura a Base de Dados
        /// </summary>
        /// <param name="options">parametros de configuracao</param>

        public VetsDB(DbContextOptions<VetsDB> options) : base(options) { }


            //adicionar as "tabelas" à Base de Dados
            public DbSet<Animais> Animais { get; set; }
            public DbSet<Donos> Donos { get; set; }
            public DbSet<Veterinarios> Veterinarios { get; set; }
            public DbSet<Consultas> Consultas { get; set; }

        }
    }

