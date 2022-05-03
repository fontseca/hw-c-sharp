using static System.Console;

namespace FirstPractice.Practices
{
    internal class Practice1
    {
        public void Start()
        {
            int dato1, dato2, dato3, resultado;
            dato1 = 20;
            dato2 = 10;
            dato3 = 30;

            resultado = dato1 + dato2 + dato3;
            WriteLine("{0} + {1} + {2} = {3}", dato1, dato2, dato3, resultado);

            resultado = dato1 - dato2 - dato3;
            WriteLine("{0} - {1} - {2} = {3}", dato1, dato2, dato3, resultado);

            resultado = dato1 * dato2 * dato3;
            WriteLine("{0} * {1} * {2} = {3}", dato1, dato2, dato3, resultado);

            resultado = dato1 / dato2 / dato3;
            WriteLine("{0} / {1} / {2} {3}\n", dato1, dato2, dato3, resultado);
        }
    }
}
