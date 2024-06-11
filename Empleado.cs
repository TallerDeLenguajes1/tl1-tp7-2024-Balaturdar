
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
    public void Info()
    {
        Console.WriteLine("nombre: "+Nombre);
        Console.WriteLine("apellido: "+Apellido);
        Console.WriteLine("fecha de nacimiento: "+FecNacimiento);
        Console.WriteLine("estado civil: "+EstadoCivil);
        Console.WriteLine("fecha de ingreso a la empresa: "+IngresoEmpresa);
        Console.WriteLine("sueldo básico: "+SueldoBasico);
        Console.WriteLine("cargo: "+cargo);
    }
}

public enum Cargos{
    auxiliar,
    administrativo,
    ingeniero,
    especialista,
    investigador    
}