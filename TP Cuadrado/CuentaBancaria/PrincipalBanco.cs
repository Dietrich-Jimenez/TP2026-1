//Programa principal Banco
Banco banco = new Banco();
try
{
    Console.WriteLine("Ingrese el numero de cuenta");
    string numeroCuenta = Console.ReadLine()??"";

    CuentaBancaria cuentaOrigen = banco.BuscarCuenta(numeroCuenta);

    //Depositar
    Console.WriteLine("Ingresa la cantidad a transferir");
    double numero = double.Parse(Console.ReadLine()??"");
    cuentaOrigen.Depositar((decimal)numero);
    //Transferir
    Console.WriteLine("Ingrese el numero de cuenta destino");
    string numeroCuentaDestino = Console.ReadLine()??"";
    CuentaBancaria cuentaDestino = banco.BuscarCuenta(numeroCuentaDestino);
    Console.WriteLine("Ingresa la cantidad a transferir");
    double numTransferir = double.Parse(Console.ReadLine()??"");
    cuentaOrigen.Transferir(cuentaDestino, (decimal)numTransferir);
    //Retirar
    Console.WriteLine("Ingresa la cantidad a retirar");
    double numRetirar = double.Parse(Console.ReadLine()??"");
    cuentaOrigen.Retirar((decimal)numRetirar);
}

catch (SaldoInsuficienteException ex)
{
    Console.WriteLine(ex.Message);
}
catch (CuentaNoEncontrada ex)
{
    Console.WriteLine(ex.Message);
}
catch (DepositoInvalidoException ex)
{
    Console.WriteLine(ex.Message);
}
