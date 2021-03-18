using System;

namespace DIO.series
{
    class Program
    {
        static SerieRepositorio listarepositorio = new SerieRepositorio();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();
            while (opcaoUsuario != "X")
            {
                switch(opcaoUsuario)
                {
                    case "1":
                        ListarSerie();
                    break;
                    case "2":
                        InsereSerie();
                    break;
                    case "3":
                        // AtualizaSerie();
                    break;
                    case "4":
                        // VisualizarSerie();
                    break;
                    case "C":
                        Console.Clear();
                    break;
                    case "X":
                    break;

                    // default:
                        // throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = ObterOpcaoUsuario();
            }
            Console.WriteLine(";-) '\'o/");
        }

        private static void InsereSerie()
        {
            Console.WriteLine("Insserir Serie.");

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.Write("Digite o genero entre as opções acima.");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o título da serie.");
            string entradaTitulo = Console.ReadLine();
            
            Console.Write("Digite o ano de inicio da serie.");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a descrição da serie.");
            string entradaDescricao = Console.ReadLine();

            Serie novaSerie = new Serie(id: listarepositorio.ProximoId(), genero: (Genero) entradaGenero,
                                        titulo: entradaTitulo, ano: entradaAno, descricao: entradaDescricao);

            listarepositorio.Insere(novaSerie);                            
            }

        private static void ListarSerie()
        {
            Console.WriteLine("Listar séries.");
            Console.WriteLine();

            var lista = listarepositorio.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhhunha serie cadastrada");
                return;
            }

            foreach(var serie in lista)
            {
                Console.WriteLine($"#ID {serie.retornaId()} : {serie.retornaTitulo()}");
            }
        }

        public static string ObterOpcaoUsuario()
        {
            Console.WriteLine("Séries ao seu dispor!!!");
            Console.WriteLine("Informe Opção desejada.");
            Console.WriteLine("----------------------------\n");
            Console.WriteLine("1- Lista Serie.");
            Console.WriteLine("2- Insere nova série.");
            Console.WriteLine("3- Atualiza série.");
            Console.WriteLine("4- Visualiza série.");
            Console.WriteLine("C- Limpar Tela.");
            Console.WriteLine("X- Sair.");
            Console.WriteLine("");

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
