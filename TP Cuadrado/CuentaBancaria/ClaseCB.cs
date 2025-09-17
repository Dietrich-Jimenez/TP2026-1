public class CuentaBancaria
{
    //Atributos
    public string NumeroCuenta { get; set; }
    public decimal Saldo { get; set; }
    //Cosntructor
    public CuentaBancaria(string numeroCuenta, decimal saldoInicial)
    {
        NumeroCuenta = numeroCuenta;
        Saldo = saldoInicial;

    }
    //Metodos
    public void Depositar(decimal cantidad)
    {
        if(cantidad <0)
        {
            throw new DepositoInvalidoException("No se puede depositar una cantidad negativa");
        }
            Saldo +=cantidad;

    }
    public void Retirar(decimal cantidad)
    {
        if(cantidad > Saldo)
        {
            throw new SaldoInsuficienteException("No hay saldo suficiente para realizar el retiro");
        }
        Saldo -= cantidad;
    }
    public void Transferir(CuentaBancaria destino, decimal cantidad)
    { 
        if (destino == null)
        {
            throw new CuentaNoEncontrada("La cuenta destino no existe");
        }

        Retirar(cantidad);

        destino.Depositar(cantidad);
    }
}