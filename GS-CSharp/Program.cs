using GS_CSharp.Services;

class Program
{
    static void Main(string[] args)
    {
        LoginService loginService = new LoginService();
        if (!loginService.Login()) return;

        FalhaService falhaService = new FalhaService();
        AlertaService alertaService = new AlertaService();
        RelatorioService relatorioService = new RelatorioService();

        bool sair = false;

        while (!sair)
        {
            Console.WriteLine("\n===== MENU PRINCIPAL =====");
            Console.WriteLine("1. Registrar falha");
            Console.WriteLine("2. Gerar alerta");
            Console.WriteLine("3. Ver relatórios");
            Console.WriteLine("0. Sair");
            Console.Write("Escolha uma opção: ");

            string opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":
                    falhaService.RegistrarFalha();
                    break;
                case "2":
                    alertaService.GerarAlerta();
                    break;
                case "3":
                    relatorioService.ExibirRelatorioCompleto();
                    break;
                case "0":
                    sair = true;
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}