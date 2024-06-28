using ESTACIONAMENTO.Entities;


namespace Pedro
{
    class Program
    {
        static void Main(string[] args)
        {
            Estacionamento ruaDoutorVeloso=new Estacionamento(5.00m,2.50m);
            ruaDoutorVeloso.addVeiculo("HKE-448");
            ruaDoutorVeloso.listarVeiculos();
            ruaDoutorVeloso.removeVeiculo("HKE-448");


        }

    }
}
