namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo" 
        public Nokia(string numero, string modelo, string imei, int memória) : base(numero, modelo, imei, memória)
        {
           
        }
        public  override  void  InstalarAplicativo ( string NomeApp ) 
        {
            
            Console.WriteLine ( $" instalando App { NomeApp } no número: { Numero } " );
        }
        
    }
}