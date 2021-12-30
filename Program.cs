using DIO.Series.Repositories;

namespace DIO.Series // Note: actual namespace depends on the project name.
{
    public class Program
    {

        static SerieRepository _repository = new SerieRepository();
        static void Main(string[] args)
        {
            string optionUser = GetUserChoice();

            while (optionUser.ToUpper() != "X")
            {
                switch (optionUser)
                {
                    case "1":
                        ListSeries();
                        break;

                    case "2":
                        AddSeries();
                        break;

                    case "3":
                        Update();
                        break;

                    case "4":
                        Delete();
                        break;

                    case "5":
                        GetById();
                        break;

                    case "C":
                        Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }
                optionUser = GetUserChoice();
            }
            Console.ReadLine();
        }

        private static void GetById()
        {
            Console.WriteLine();
            Console.Write("Digite o ID da série: ");
            int idSerie = int.Parse(Console.ReadLine());

            var serie = _repository.GetById(idSerie);
            Console.WriteLine(serie);
            Console.WriteLine();
        }


        private static void Delete()
        {
            Console.Write("Digite o ID da série: ");
            int idSerie = int.Parse(Console.ReadLine());

            _repository.Delete(idSerie);
        }

        private static void Update()
        {
            Console.Write("Digite o ID da série: ");
            int idSerie = int.Parse(Console.ReadLine());
            foreach (int n in Enum.GetValues(typeof(Gender)))
            {
                Console.WriteLine("{0} - {1}", n, Enum.GetName(typeof(Gender), n));
            }
            Console.Write("Digite o gênero entre as opções acima: ");
            int inputGender = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título da série: ");
            string inputTitle = Console.ReadLine();

            Console.Write("Digite o ano de lançamento: ");
            int inputYear = int.Parse(Console.ReadLine());

            Console.Write("Digite a descrição da série: ");
            string inputDescription = Console.ReadLine();

            Console.ReadKey();

            Series newSerie = new Series(
                id: idSerie,
                gender: (Gender)inputGender,
                title: inputTitle,
                year: inputYear,
                desription: inputDescription
            );
            _repository.Update(idSerie, newSerie);



        }


        private static void AddSeries()
        {
            foreach (int n in Enum.GetValues(typeof(Gender)))
            {
                Console.WriteLine("{0} - {1}", n, Enum.GetName(typeof(Gender), n));
            }
            Console.Write("Digite o gênero entre as opções acima: ");
            int inputGender = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título da série: ");
            string inputTitle = Console.ReadLine();

            Console.Write("Digite o ano de lançamento: ");
            int inputYear = int.Parse(Console.ReadLine());

            Console.Write("Digite a descrição da série: ");
            string inputDescription = Console.ReadLine();

            Console.ReadKey();

            Series newSerie = new Series(
                id: _repository.NextId(),
                gender: (Gender)inputGender,
                title: inputTitle,
                year: inputYear,
                desription: inputDescription
            );
            _repository.Insert(newSerie);



        }


        private static void ListSeries()
        {
            var list = _repository.GetAll();

            foreach (var serie in list)
            {
                Console.WriteLine("#ID {0}: {1}", serie.ReturnId(), serie.ReturnTitle());
            }
        }



        private static string GetUserChoice()
        {
            Console.WriteLine("Bem-vindo(a) DIO Series");
            Console.WriteLine("Escolha uma opção: ");
            Console.WriteLine("1 - Listar séries");
            Console.WriteLine("2 - Inserir uma série");
            Console.WriteLine("3 - Atualizar série");
            Console.WriteLine("4 - Excluir série");
            Console.WriteLine("5 - Visualizar detalhes");
            Console.WriteLine("C  - Limpar tela");
            Console.WriteLine("X - Sair");

            string optionUser = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return optionUser;
        }
    }
}