using static System.Console;

namespace FirstPractice.Practices
{
    internal class Practice2
    {
        public void Start()
        {
            int dato1, dato2, dato3, resultado;
            Write("First datum: ");
            dato1 = int.Parse(ReadLine());

            Write("Second datum: ");
            dato2 = int.Parse(ReadLine());

            Write("Third datum: ");
            dato3 = int.Parse(ReadLine());

            resultado = dato1 + dato2 + dato3;
            WriteLine("{0} + {1} + {2} = {3}", dato1, dato2, dato3, resultado);
            
            resultado = dato1 - dato2 - dato3;
            WriteLine("{0} - {1} - {2} = {3}", dato1, dato2, dato3, resultado);

            resultado = dato1 * dato2 * dato3;
            WriteLine("{0} * {1} * {2} = {3}", dato1, dato2, dato3, resultado);

            resultado = dato1 / dato2 / dato3;
            WriteLine("{0} / {1} / {2} = {3}\n", dato1, dato2, dato3, resultado);
        }
    }
}
