namespace MesesFuncionesProyecto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("introduce un numero");
                string[] mes = new string[12];

                mes[1] = "Enero";
                mes[2] = "Febrero";
                mes[3] = "Marzo";
                mes[4] = "Abril";
                mes[5] = "Mayo";
                mes[6] = "Junio";
                mes[7] = "Julio";
                mes[8] = "Agosto";
                mes[9] = "Septiembre";
                mes[10] = "Octubre";
                mes[11] = "Noviembre";
                mes[12] = "Diciembre";

                string imput = Console.ReadLine();
                int.TryParse(imput, out int result);

                if (result > 0 && result <= 12)
                {
                    Console.WriteLine(mes[result - 1]);
                }
                else
                {
                    Console.WriteLine("Resultado incorrecto");
                }
                Console.WriteLine();

            } while (true);
        }
    }
}
