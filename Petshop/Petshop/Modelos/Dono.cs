namespace Petshop.Modelos;

internal class Dono
{
    public string Nome { get; set; }
    private List<Pet> pets = new();

    public void AdicionarPet(Pet pet)
    {
        pets.Add(pet);
    }

    public void MostrarDetalhesDono()
    {
        Console.WriteLine($"Dono: {this.Nome}");
        foreach (Pet pet in pets) {
            Console.WriteLine($"Pet: {pet.Nome}\n");
        }
    }
}
