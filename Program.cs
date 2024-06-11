/*
Para utilizar esta clase desde Program.cs, no olvide incorporar al mismo el espacio de
nombres definido en el archivo Calculadora.cs, utilizando la palabra reservada using.
Realice una interfaz de usuario para operar la calculadora que permita continuar
solicitando operaciones hasta que el usuario ingrese un comando de escape
*/
/*
using EspacioCalculadora;

Calculadora calc = new Calculadora();
bool aux;
int opc;
double valor;

do{
    Console.WriteLine("ingrese el valor inicial de la operacion");
    aux = double.TryParse(Console.ReadLine(), out valor);
    if(!aux){
        Console.WriteLine("debe ingresar un numero");
    }
}while(!aux);

calc.Sumar(valor);

do{

    Console.WriteLine("##### MENU CALCULADORA #####");
    Console.WriteLine("##    1 - SUMAR           ##");
    Console.WriteLine("##    2 - RESTAR          ##");
    Console.WriteLine("##    3 - MULTIPLICAR     ##");
    Console.WriteLine("##    4 - DIVIDIR         ##");
    Console.WriteLine("##    5 - LIMPIAR         ##");
    Console.WriteLine("##    6 - SALIR           ##");
    Console.WriteLine("############################");
    do{
        Console.WriteLine("seleccione una opcion");
        aux = int.TryParse(Console.ReadLine(), out opc);
        if(!aux){
            Console.WriteLine("Para seleccionar una opcion debe ingresar un numero");
        }
    }while(!aux);

    if(opc != 6){

        do{
            Console.WriteLine("ingrese el siguiente valor de la operacion");
            aux = double.TryParse(Console.ReadLine(), out valor);
            if(!aux){
                Console.WriteLine("Para seleccionar una opcion debe ingresar un numero");
            }
        }while(!aux);

        switch(opc){
            case 1:
                calc.Sumar(valor);
                break;
            case 2:
                calc.Restar(valor);
                break;
            case 3:
                calc.Multiplicar(valor);
                break;
            case 4:
                if(valor == 0){
                    Console.WriteLine("No se puede dividir en 0\nIngrese un numero valido");
                    break;
                }
                calc.Dividir(valor);
                break;
            case 5:
                calc.Limpiar();
                break;    
        }
        Console.WriteLine("valor actual: "+calc.Resultado); 
    }
    //if(opc == 6){
    //    break;
    //}else{
    //    Console.WriteLine("¿Desea realizar otro calculo? S/N");
    //    opc = ("N".Equals(Console.ReadLine()))? 6 : 0;
    //}
}while(opc != 6);

*/
using System.Reflection.PortableExecutable;

public enum Cargos{
    auxiliar,
    administrativo,
    ingeniero,
    especialista,
    investigador    
}