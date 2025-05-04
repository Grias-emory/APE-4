using System;

namespace PromedioAsignaturas
{
    public class Asignatura
    {
        public string Nombre { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }

        public Asignatura(string nombre, double nota1, double nota2, double nota3)
        {
            Nombre = nombre;
            Nota1 = nota1;
            Nota2 = nota2;
            Nota3 = nota3;
        }

        public virtual double CalcularPromedio()
        {
            return (Nota1 + Nota2 + Nota3) / 3;
        }
    }
}
