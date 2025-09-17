//Programa principal
List<IPago> ListPagos = new List<IPago>();
Console.WriteLine("Ingresa el monto a pagar");
string montoTexto = Console.ReadLine() ?? "";
if(double.TryParse(montoTexto,out double monto))
{
    Console.WriteLine("El pago es con tarjeta? (s/n)"); 
    string opcion = Console.ReadLine() ?? "";
    if (opcion == "s")
    {
        Console.WriteLine("Ingresa el numero de tarjeta");
        string numeroTarjeta = Console.ReadLine() ?? "";
        //Crear objeto de pago con tarjeta
        IPago pago = new PagoTarjeta(monto,numeroTarjeta);
        ListPagos.Add(pago);

    }
    else
    {
        //Crear objeto de pago en efectivo
        IPago pago = new PagoEfectivo(monto);
        ListPagos.Add(pago);
    }
    foreach(IPago p in ListPagos)
    {
        PagoTarjeta pagoTarjeta = p as PagoTarjeta;
        if (pagoTarjeta !=null)
        {
            Console.WriteLine("Se pagó con tarjeta");
            pagoTarjeta.ProcesarPago();

        }
        //TODO : Completar el casteo para pago en efectivo
    }
}
//TODO: Hacer el pago hasta que ya no haya mas pagos
interface IPago
{
   public void ProcesarPago();
}
//Clase que implementa la interfaz

//Clase para pago en efectivo
public class PagoEfectivo : IPago
{
    //Atributo
    public double Monto { get; set; }
    //Constructor
    public PagoEfectivo(double monto)
    {
        Monto = monto;
    }
    //Metodo de la interfaz
    public void ProcesarPago()
    {
        Console.WriteLine($"Pago en efectivo de {Monto} pesos.");
    }
}
//Clase para pago con tarjeta
public class PagoTarjeta: IPago
{
    //Atributo
    public double Monto { get; set; }
    public string NumeroTarjeta { get; set; }
    //Constructor
    public PagoTarjeta(double monto, string numeroTarjeta)
    {
        Monto = monto;
        NumeroTarjeta = numeroTarjeta;
    }
    //Metodo de la interfaz
    public void ProcesarPago()
    {
       if (NumeroTarjeta.Length == 16)
       {
            Console.WriteLine($"Pago con tarjeta de {Monto} pesos. Tarjeta: **** **** **** {NumeroTarjeta.Substring(12)}");
       }
       else
       {
            Console.WriteLine("Número de tarjeta inválido.");
        }
    }
}