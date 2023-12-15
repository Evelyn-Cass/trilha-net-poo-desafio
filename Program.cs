using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Realizando testes com o Smartphone Nokia...");
Nokia n = new Nokia("948113156","x202","123456789",64);
n.Ligar();
n.InstalarAplicativo("Warcraft Rumble");


Console.WriteLine("Realizando teste com o Smartphone Iphone...");
Iphone i = new Iphone("984111365","i304","987654321",128);
i.ReceberLigacao();
i.InstalarAplicativo("Candy Crush");





