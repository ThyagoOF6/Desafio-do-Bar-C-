namespace BAR {
class Program {
        static void Main(string[] args) {
            Bill bill = new Bill();

            Console.WriteLine("Sexo: ");
            bill.gender = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Quantidade de cervejas: ");
            bill.beer = Console.ReadLine();

            Console.WriteLine("Quantidade de refrigerante: ");
            bill.softDrink = Console.ReadLine();

            Console.WriteLine("Quantidade de espetinhos: ");
            bill.barbecue = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("RELATÓRIO");
            Console.WriteLine("Consumo = R$ " + bill.Feeding());
            Console.WriteLine("Couvert = R$ " + bill.Couvert());
            Console.WriteLine("Ingresso = R$ " + bill.Ticket());
            Console.WriteLine();
            Console.WriteLine("Valor a pagar = R$" + bill.Total());
        }
    }
}