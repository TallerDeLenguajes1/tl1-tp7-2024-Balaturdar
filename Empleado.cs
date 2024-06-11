
public class Empleado{
    private string nombre;
    private string apellido;
    private DateTime fecNacimiento;
    private DateTime ingresoEmpresa;
    private char estadoCivil;
    private double sueldoBasico;
    private Cargos cargo;

    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido { get => apellido; set => apellido = value; }
    public DateTime FecNacimiento { get => fecNacimiento; set => fecNacimiento = value; }
    public DateTime IngresoEmpresa { get => ingresoEmpresa; set => ingresoEmpresa = value; }
    public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
    public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
    public Cargos Cargo { get => cargo; set => cargo = value; }

    public Empleado(string nombre, string apellido, DateTime fecNacimiento, DateTime ingresoEmpresa, char estadoCivil, double sueldoBasico, Cargos cargo)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.fecNacimiento = fecNacimiento;
        this.ingresoEmpresa = ingresoEmpresa;
        this.estadoCivil = estadoCivil;
        this.sueldoBasico = sueldoBasico;
        this.cargo = cargo;
    }

    public int Antiguedad(){
        return DateTime.Now.Year - ingresoEmpresa.Year;
    }
    public int EdadEmpleado(){
        return DateTime.Now.Year-fecNacimiento.Year;
    }
    public int AñosJubilacion(){//65
        return 65-EdadEmpleado();
    }
    public double Salario(){
        return SueldoBasico + adicional();
    }
    private double adicional(){
        double add;
        add = Antiguedad()*sueldoBasico;
        add *= (Antiguedad() <= 20)? 0.01:0.25;
        add *= (cargo == Cargos.ingeniero || cargo == Cargos.especialista)? 1.5:1;
        add += (estadoCivil == 'C')? 150000:0;
        return add;
    }
    public string Info()
    {
        return "\nnombre: " + Nombre + "\napellido: " + Apellido + "\nfecha de nacimiento: " + FecNacimiento + "\nestado civil: " + EstadoCivil + "\nfecha de ingreso a la empresa: " + IngresoEmpresa + "\nsueldo básico: " + SueldoBasico + "\ncargo: " + cargo + "\nAntiguedad: " + Antiguedad() + "\nEdad: " + EdadEmpleado() + "\nAños para la jubilacion: " + AñosJubilacion();
    }
}

public enum Cargos{
    auxiliar,
    administrativo,
    ingeniero,
    especialista,
    investigador    
}