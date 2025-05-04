namespace PromedioAsignaturas
{
    public class AsignaturaSupletorio : Asignatura
    {
        public double Supletorio { get; set; }

        public AsignaturaSupletorio(string nombre, double nota1, double nota2, double nota3)
            : base(nombre, nota1, nota2, nota3)
        {
            Supletorio = 0;
        }

        public double CalcularPromedioConSupletorio()
        {
            double promedio = CalcularPromedio();
            if (promedio < 7)
            {
                promedio = (promedio + Supletorio) / 2;
            }
            return promedio;
        }
    }
}
