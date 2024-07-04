using Petshop.Modelos;

//instancia Dono
Dono dono1 = new Dono();
dono1.Nome = "giovanna";

//instancia Pet
Pet pet1 = new Pet("pucca", "shitzu","fêmea", 12);
dono1.AdicionarPet(pet1);

pet1.AdicionarPet(pet1);
pet1.ExibirPet();
dono1.MostrarDetalhesDono();
