﻿using BlogCore.AccesoDatos.Data.Repository.IRepository;
using Curso_de_Modelado.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogCore.AccesoDatos.Data.Repository
{
    public class ContenedorTrabajo : IContenedorTrabajo
    {
        private readonly ApplicationDbContext _db;

        public ContenedorTrabajo(ApplicationDbContext db)
        {
            _db = db;
            Categoria = new CategoriaRepository(_db);

        }

        public ICategoriaRepository Categoria {  get; private set; }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void save()
        {
           _db.SaveChanges();  
        }
    }
}
