using System;
using System.Globalization;
using System.Linq;
using System.Text;

[Serializable]
public class AnimalData {
    public int Id { get; set; }
    public string Nome { get; set; }
    public string PrimeiraDica { get; set; }
    public string SegundaDica { get; set; }
    public string TerceiraDica { get; set; }

    public string NomeSemAcento
    {
        get
        {
            var nomeNormalizado = Nome.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            nomeNormalizado.Where(c => CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark).ToList()
                .ForEach(c => stringBuilder.Append(c));

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }
    }

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
