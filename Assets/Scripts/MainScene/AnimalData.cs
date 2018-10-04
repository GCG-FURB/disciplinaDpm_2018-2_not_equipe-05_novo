using System;

[Serializable]
public class AnimalData {
    public int Id { get; set; }
    public string Nome { get; set; }
    public string PrimeiraDica { get; set; }
    public string SegundaDica { get; set; }
    public string TerceiraDica { get; set; }

    public AnimalData() { }

    public AnimalData(int id, string nome, string primeiraDica, string segundaDica, string terceiraDica)
    {
        Id = id;
        Nome = nome;
        PrimeiraDica = primeiraDica;
        SegundaDica = segundaDica;
        TerceiraDica = terceiraDica;
    }
}
