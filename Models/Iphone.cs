namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public Iphone(string numero, string modelo, string imei, int memória) : base(numero, modelo, imei, memória)
        {

        }

         public  override  void  InstalarAplicativo ( string NomeApp ) 
         {
         Console.WriteLine ( $" Instalando App { NomeApp } no número: { Numero } " );
         }
    }
}