namespace programa01
{
    class Bike
    {
        //declarações
        public string? Modelo {  get; set; } //= string.Empty ou ?
        public double Bateria { get; set; } 
        public double PesoCiclista { get; set; }
        public int RecargaMes { get; set; }


        //métodos (Ações)
        public double CalcularAutonomia()
        {
            double autonomiaBase = Bateria / 15;
            bool peso = PesoCiclista > 90;
            // se o peso do ciclista for maior que 90kg, redus a autonomia para 15%, senão autonomia normal
            return peso ? (autonomiaBase * 0.05) : autonomiaBase;
        }
        public double CalcularConsumoMensal()
        {
            double cargaPorKm = Bateria / 1000;
            return cargaPorKm * RecargaMes;
        }
        public double CalcularCustoMensal() { 
            const double PRECO = 0.80;
            return CalcularConsumoMensal() * PRECO;
        }
        public bool BikeEconomica()
        {
            return (CalcularCustoMensal() < 15) || (CalcularAutonomia() > 40);
        }

    }
}
