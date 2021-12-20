namespace CSharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            Pessoa person = new();
            person.Id = 1;
            person.Nome = "Cristian";
            person.Idade = 25;
            person.Cpf = "030-300-458-15";
            Console.WriteLine(person.Cpf);

            Animal animal = new();

            animal.Nome = "Gatito";
            animal.Dono = "Maria";

            ReajusteFuncionario objReajusteFuncionario = new ReajusteFuncionario();

            objReajusteFuncionario.nomeFuncionario = "Cristian Brum";
            objReajusteFuncionario.salarioFuncionario = 2078.00;

            Console.WriteLine("Antes do Reajuste: ");
            Console.WriteLine("\nNome: " + objReajusteFuncionario.nomeFuncionario);
            Console.WriteLine("\nSalário: R$ " + objReajusteFuncionario.salarioFuncionario);

            objReajusteFuncionario.Reajuste();
            Console.WriteLine("\nDepois do Reajuste: ");
            Console.WriteLine("\nNome: " + objReajusteFuncionario.nomeFuncionario);
            Console.WriteLine("\nSalário: R$ " + objReajusteFuncionario.salarioFuncionario);
        }
    }
}