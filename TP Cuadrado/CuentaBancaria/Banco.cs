public class Banco
{
    //Atributos
    private CuentaBancaria[] cuentas;

    //Constructor
    public Banco()
    {
        cuentas = new CuentaBancaria[]
        {
            new CuentaBancaria("AA01",10),
            new CuentaBancaria("AA02",10000),
            new CuentaBancaria("AA03",5000),
            new CuentaBancaria("AA04",(decimal)400.3),
            new CuentaBancaria("AA05",(decimal) 75.5),
        };
    }
    //Metodos
    public CuentaBancaria BuscarCuenta(string numeroCuenta)
    {
        foreach (CuentaBancaria cuenta in cuentas)
        {
            // Sirve para comparar cadenas de texto
            if (cuenta.NumeroCuenta == numeroCuenta)
            {
                return cuenta;
            }
        }
        return null;
    }



}