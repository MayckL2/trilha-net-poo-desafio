namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) :base(numero, modelo, imei, memoria){
            Console.WriteLine($"Fabricando {modelo} n°{imei}, {memoria}GB de memoria e numero {numero}.");
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp){
            Console.WriteLine($"Instalando {nomeApp}...");
            Console.WriteLine($"{nomeApp} Instalado com suceso!");
        }
    }
}