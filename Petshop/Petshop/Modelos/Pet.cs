namespace Petshop.Modelos;

internal class Pet
{
    private List<Pet> pets = new();
    public Pet(string nomeDoPet, string racaDoPet, string sexoDoPet, int idadeDoPet, Dono dono)
    {
        nomeDoPet = Nome;
        racaDoPet = Raca;
        sexoDoPet = Sexo;
        idadeDoPet = Idade;
        dono = new Dono();
    }

    public string Nome { get; }
    public string Raca { get; }
    public string Sexo { get; }
    public int Idade { get; }
    public Dono DonoDoPet { get; }
    public Medico MedicoDoPet { get; }

    public void AdicionarPet(Pet pet) {
        pets.Add(pet);
    }

    public void ExibirPet() {
       Console.WriteLine($"Nome do pet: {this.Nome}\n" +
                $"Raça do Pet: {this.Raca}\n" +
                $"Idade do Pet: {this.Raca}\n" +
                $"Sexo do Pet: {this.Sexo}\n" +
                $"Dono do Pet: {DonoDoPet}\n" +
                $"Médico do Pet: {MedicoDoPet}\n");
    }
}
