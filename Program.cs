namespace T03_Eje5
{
    class T03_Eje5
    {
        static void Main()
        {
            int A = 1;
            int B = 2;
            int C = 3;  
            int D = 4;
            int Aux;

            Console.WriteLine("Valores iniciales: A={0}, B={1}, C={2} y D={3}", A, B, C, D);

            Aux = A;
            A = D;
            D = B;
            B = C;
            C = Aux;

            Console.WriteLine("Valores finales: A={0}, B={1}, C={2} y D={3}", A, B, C, D);

            Console.WriteLine("Pulse cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}