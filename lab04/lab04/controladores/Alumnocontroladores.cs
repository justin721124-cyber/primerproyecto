using lab04.entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Security.Policy;
using System.Text;

namespace lab04.controladores
{
    internal class Alumnocontroladores
    {
        private Alumnos[] alumno = new Alumnos[100];
        private int contador = 0;

        public Alumnos[] Listartodo() { return alumno; }

        public void Registrar(Alumnos alumnos)
        {
            alumno[contador] = alumnos;
            contador++;
        }

        public void Eliminar(String codigo)
        {
            int posicion = Array.FindIndex(alumno, alumnos => alumnos.Codigo == codigo);

            for (int i = 0; i < contador; i++)
            {
                if (i >= posicion)
                {
                    alumno[i] = alumno[i + 1];
                }

            }
            contador--;
        
        }
        
        private class MetodoComparacion : IComparer 
        {
            int IComparer.Compare(object x, object y)
            {
                if (((Alumnos)x).Promedio < ((Alumnos)y).Promedio) return -1;
                else if (((Alumnos)x).Promedio > ((Alumnos)y).Promedio) return 0;
                else return 1;
            }
        
        }
        public Alumnos[] Ordenar() 
        {
            Array.Sort(alumno, 0, contador, new MetodoComparacion());
            return alumno;
        }   
        
        public Alumnos[] BuscarPorCodigo(String codigo)
        {
            return Array.FindAll(alumno, alumnos => alumnos != null && alumnos.Codigo.Contains(codigo));
         
        }
    }   

}
