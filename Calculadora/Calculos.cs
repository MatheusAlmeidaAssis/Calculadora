namespace Calculadora
{
    public class Calculos
    {
        public int Fatorial(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            else
            {
                return Fatorial(n - 1) * n;
            }
        }

        public int Soma(int n1, int n2)
        {
            return n1 + n2; 
        }

        public int Subtracao(int n1, int n2)
        {
            return n1 - n2;
        }

        public int Divisao(int n1, int n2)
        {
            return n1 / n2;
        }

        public int Multiplicacao(int n1, int n2)
        {
            return n1 * n2;
        }        
    }
}