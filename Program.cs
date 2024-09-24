using NumeradoresVeiculo;

Motor motor = new Motor("Honda", 150);


Veiculo veiculo = new Veiculo("Honda", "Civic", 2020, TipoVeiculo.Carro, motor);


veiculo.ImprimirDetalhes();