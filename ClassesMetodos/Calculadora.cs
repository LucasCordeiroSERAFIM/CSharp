namespace Program;

public class Calculadora{

    public double Somar(Calculo calculo){
        return calculo.Numero1 + calculo.Numero2; 
    }

    public double Subtrair(Calculo calculo){
        return calculo.Numero1 - calculo.Numero2; 
    }
    public double Dividir(Calculo calculo){
        return calculo.Numero1 / calculo.Numero2; 
        
    }

      public double Multiplicar(Calculo calculo){
        return calculo.Numero1 * calculo.Numero2; 
}
}