using System.Collections.Generic;

namespace Livraria
{
    public class Cliente(Guid id, string nome, int idade)
    {
        public Guid Id = id;
        public string Nome = nome;
        public int idade = idade;

        public static IList<Cliente> Insert()
        {
            List<Cliente> clientes = [];

            var id = Guid.NewGuid();

            Console.WriteLine("Digite o nome");
            var nome = Console.ReadLine();

            Console.WriteLine("Digite a idade");
            var idade = Console.ReadLine();

            Cliente novoCliente = new Cliente(id, nome, Convert.ToInt32(idade));

            clientes.Add(novoCliente);

            return clientes;
        }
    };
}
