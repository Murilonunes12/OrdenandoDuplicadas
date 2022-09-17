namespace Ordenando
{
    public class Resolucao
    {
        static void Main(string[] args)
        {
            string[] letra = {
                "abracadabra", "allottee",
                "assessee","kelless", "keenness" };

            for (int i = 0; i < letra.Length; i++)
            {
                Console.WriteLine(value: RemoverDuplicata(letra[i]));
            }
        }
        static string RemoverDuplicata(string nome)
        {
            char duplicata = ' ';

            string certo = "";

            foreach (char letra in nome)
            {
                if (duplicata != letra)
                {
                    duplicata = letra;
                    certo += letra;
                }
            }

            return certo;
        }
    }
}
