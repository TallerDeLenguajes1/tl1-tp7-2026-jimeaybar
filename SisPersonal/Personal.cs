namespace Personal
{
    public enum Cargos
    {
        auxiliar, Administrativo, Ingeniero, Especialista, Investigador
    }

    public class Empleado
    {
        private string? nombre;
        private string? apellido;
        private DateTime fechadenac;
        private char estadocivil;
        private DateTime ingresoEmpresa;
        private double sueldobasico;
        private Cargos cargo;

        public string? Nombre { get => nombre; set => nombre = value; }
        public string? Apellido { get => apellido; set => apellido = value; }
        public DateTime Fechadenac { get => fechadenac; set => fechadenac = value; }
        public char Estadocivil { get => estadocivil; set => estadocivil = value; }
        public DateTime IngresoEmpresa { get => ingresoEmpresa; set => ingresoEmpresa = value; }
        public double Sueldobasico { get => sueldobasico; set => sueldobasico = value; }

        public Cargos Cargo{ get => cargo; set => cargo = value; }

        public int Edad()
        {
            DateTime hoy = DateTime.Now;
            int edad = hoy.Year - fechadenac.Year;
            return edad;
        }

        public int Antiguedad()
        {
            DateTime hoy = DateTime.Now;
            int años = hoy.Year - ingresoEmpresa.Year;
            return años;
        }

        public int Jubilacion()
        {
            int EdadActual = this.Edad();
            int jubilacion = 65 - EdadActual;
            return jubilacion;
        }

        // Calcular salario

        public double Salario()
        {
            double Acumulado;
            this.sueldobasico = Sueldobasico;
            double Salario;

            if (this.Antiguedad() >= 20)
            {
                double Adicional = 0.25;
                Acumulado = Sueldobasico * Adicional;
            }
            else
            {
                double Adicional = this.Antiguedad() / 100;
                Acumulado = Sueldobasico * Adicional;
            }

            if (this.cargo == Cargos.Administrativo || this.cargo == Personal.Cargos.Ingeniero)
            {
                double Adicional = 0.50;
                Acumulado += Sueldobasico * Adicional;
            }

            if (this.estadocivil == 'C' || this.estadocivil == 'c')
            {
                Acumulado += 150000;
            }

            Salario = Sueldobasico + Acumulado;

            return Salario;
        }
    }
}