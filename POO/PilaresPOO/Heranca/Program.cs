using Heranca;

Carro Fusca = new Carro();
Veiculos Generico = new Veiculos();

Avião Airbus230 = new Avião();
Motos HarleyDavison = new Motos();
HarleyDavison.Marca = "Harley Davison";
HarleyDavison.Modelo = "Fat Boy";
HarleyDavison.Ano = 2028;
HarleyDavison.SomDaMoto();

Airbus230.Marca = "LATAM airlines";
Airbus230.Modelo = "Airbus 320";
Airbus230.Ano = 2025;
Airbus230.QtdAssentos = 67;
Airbus230.Voar();