public class MathOperations
{
    public double Suma(double num1, double num2) => num1 + num2;
    public double Resta(double num1, double num2) => num1 - num2;
    public double Multiplicacion(double num1, double num2) => num1 * num2;
    public double Division(double num1, double num2)
    {
        if (num2 == 0) throw new DivideByZeroException("No se puede dividir por cero");
        return num1 / num2;
    }
}