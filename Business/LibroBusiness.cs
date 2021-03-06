﻿using Data;
using Entity;
using System;
using System.Collections.Generic;

namespace Business
{
    public class LibroBusiness
    {
        LibroData libroData = new LibroData();

        public List<LibroEntity> LIS_LibroBusiness()
        {
            return libroData.LIS_LibroData();
        }

        public List<LibroEntity> LIS_LibroFiltroBusiness(LibroEntity objLibrosEnt)
        {
            return libroData.LIS_LibroFiltroData(objLibrosEnt);
        }

        public List<LibroEntity> LIS_LibroUnicoBusiness(int id_libro)
        {
            return libroData.LIS_LibroUnicoData(id_libro);
        }

        public String CREATE_LibroBusiness(LibroEntity objLibrosEnt)
        {
            return libroData.CREATE_LibroData(objLibrosEnt);
        }

        public String UPDATE_LibroBusiness(int id_libro, LibroEntity objLibrosEnt)
        {
            return libroData.UPDATE_LibroData(id_libro, objLibrosEnt);
        }

        public bool DELETE_LibroBusiness(int id_libro)
        {
            return libroData.DELETE_LibroData(id_libro);
        }

    }
}
