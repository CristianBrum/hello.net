namespace CSharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
           Pessoa person = new();
            person.Id = 1;
            person.Nome = "Cristian";
            person.Idade = 25;
            person.Cpf = "030-300-458-15";
            Console.Write(person.Cpf);

        }
    }
}