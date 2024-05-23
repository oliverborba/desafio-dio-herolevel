using System;
class Program
{

    public static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Informe o nome do herói: ");
            string nome = Console.ReadLine();

            Console.Write("Informe a quantidade de XP do herói: ");
            string xpNivel = Console.ReadLine();
            int xp;

            if (!int.TryParse(xpNivel, out xp))
            {
                Console.WriteLine("Por favor, insira um valor numérico válido para XP.");
                continue; // Recomeça o loop
            }

            string nivel = xpNivel(xp);

            Console.WriteLine("O Herói de nome " + nome + " está no nível de " + nivel);

            Console.Write("Deseja inserir outro herói? (sim/não): ");
            string continuar = Console.ReadLine().ToLower();
            if (continuar != "sim")
            {
                break; // Encerra o loop se o usuário não quiser continuar
            }
        }
        static string xpNivel(int xp)
        {
            if (xp < 1000)
            {
                return "Ferro";
            }
            else if (xp <= 2000)
            {
                return "Bronze";
            }
            else if (xp <= 5000)
            {
                return "Prata";
            }
            else if (xp <= 7000)
            {
                return "Ouro";
            }
            else if (xp <= 8000)
            {
                return "Platina";
            }
            else if (xp <= 9000)
            {
                return "Ascendente";
            }
            else if (xp <= 10000)
            {
                return "Imortal";
            }
            else
            {
                return "Radiante";
            }
        }
    }

}
