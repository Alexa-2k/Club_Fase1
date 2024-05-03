﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Club
{
   public class Disciplina
    {
        private string nomDisciplina;
        private Profesor profe;
        //private Alumno alumno;
        private const byte cantAlumnos = 30;
        private List<Alumno> alumnos;
        private double valorCuotaSocio;
        private double valorCuotaNoSocio;
        private byte vacante = cantAlumnos;
        private bool cupo;
       
        public string NomDisciplina { get => nomDisciplina; set => nomDisciplina = value; }
        public static byte CantAlumnos => cantAlumnos;

        internal List<Alumno> Alumnos { get => alumnos; set => alumnos = value; }
        internal Profesor Profe { get => profe; set => profe = value; }
        public double ValorCuotaSocio { get => valorCuotaSocio; set => valorCuotaSocio = value; }
        public double ValorCuotaNoSocio { get => valorCuotaNoSocio; set => valorCuotaNoSocio = value; }
        public byte Vacante { get => vacante; set => vacante = value; }
        public bool Cupo { get => cupo; set => cupo = value; }
       
        //public Alumno Alumno { get => alumno; set => alumno = value; }

        public Disciplina( string nomDis, Profesor profe, double valSocio, double valNoSoc, byte vacantes, bool cupo)
        {
            NomDisciplina = nomDis;
            Profe = profe;
            ValorCuotaSocio = valSocio;
            ValorCuotaNoSocio = valNoSoc;
            Vacante = vacantes;
            Cupo = cupo;
            Alumnos = new List<Alumno>();


    }


    public override string ToString()
        {
            return "Actvidad: " + NomDisciplina + "Profesor a cargo: " + Profe + "Valor mensual: " + ValorCuotaSocio + "Valor clase única: " + ValorCuotaNoSocio + "Vacantes disponibles: " + Vacante
             ;

        }

        
        
    }
     

}
       

   
