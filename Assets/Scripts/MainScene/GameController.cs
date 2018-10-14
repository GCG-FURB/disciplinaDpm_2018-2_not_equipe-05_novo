using Assets.Scripts.ExtensionMethods;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text TextoForca;

    private char[] Palavra { get; set; }

    public AnimalData CurrentAnimal { get; private set; }

    private List<AnimalData> Animais = new List<AnimalData>
    {
        new AnimalData(1, "Borboleta", "Pertence à classe dos insetos", "Possui asas", "Alimenta-se de néctar"),
        new AnimalData(2, "Vaca", "É um mamífero de grande porte", "É um animal ruminante", "Alimenta-se de pastagem, capins e fenos"),
        new AnimalData(3, "Caranguejo", "É um crustáceo", "Habita regiões litorâneas", "Possui uma carapaça"),
        new AnimalData(4, "Rato", "É um animal roedor", "Tem o olfato aguçado", "Tem quatro patas e uma longa cauda"),
        new AnimalData(5, "Caracol", "Pertence ao filo dos moluscos", "É encontrado em jardins, hortas e pomares", "Carrega em seu corpo um esqueleto externo que chamamos de concha"),
        new AnimalData(6, "Peixe", "Encontrado nos mais variados ambientes aquáticos", "Possui o corpo alongado e fino", "Possui escamas"),
        new AnimalData(7, "Escorpião", "É um animal terrestre invertebrado", "Passa o dia escondido em lugares escuros", "Possui pinças"),
        new AnimalData(8, "Sapo", "É um anfíbio", "As patas traseiras do sapo estão adaptadas para nadar e pular", "Alimenta-se de insetos"),
        new AnimalData(9, "Bode", "Mamífero dotado de chifre", "É ruminante", "Seu habitat geralmente são montanhas"),
        new AnimalData(10, "Lobo", "Vive em grupos liderados por um macho alfa", "É um animal carnívoro", "Os uivos são usados como forma de comunicação entre eles"),
        new AnimalData(11, "Pato", "É uma ave", "Se alimenta preferencialmente de vegetais, grãos e sementes", "É um dos poucos animais que andam, nadam e voam"),
        new AnimalData(12, "Jacaré", "Vive em grupos", "É carnívoro", "Prefere o meio aquático, vivendo em rios, lagos e pântanos"),
        new AnimalData(13, "Urso", "A coloração da pele muda de espécie para espécie", "Esse animal hiberna durante o inverno", "Come o que encontra disponível, desde frutos, folhas e raízes a outros animais"),
        new AnimalData(14, "Tucano", "É um animal relativamente grande e possui cores bem vivas", "Tem um temperamento dócil e é inteligentíssimo", "Possui um bico bem comprido"),
        new AnimalData(15, "Baleia", "Quando mergulha, consegue ficar longos períodos sem respirar", "Mamífero que ocupa todos os oceanos do mundo", "É um animal grande, podendo pesar até 180 toneladas"),
        new AnimalData(16, "Tigre", "Animal imponente e muito perigoso", "É o maior felino encontrado na natureza", "Classificado como mamífero e carnívoro"),
        new AnimalData(17, "Porco", "É um mamífero", "Possui quatro patas com quatro dedos", "Alimenta-se de verduras, legumes, grãos e restos de alimentos"),
        new AnimalData(18, "Polvo", "Se alimenta de peixes e crustáceos", "Vive na água dos oceanos escondido entre rochas", "Possui um corpo mole coberto por uma pele sensível à luz"),
        new AnimalData(19, "Tubarão", "Alimenta-se de peixes, tartarugas, lulas e raias", "É um vertebrado aquático", "Respira por meio de guelras e nada graças às barbatanas que têm"),
        new AnimalData(20, "Coelho", "É um animal noturno", "Possui corpo arredondado, cabeça e olhos grandes, orelhas longas e largas", "Vive em buracos e tocos de árvores"),
        new AnimalData(21, "Galinha", "Alimenta-se de milho e outros grãos", "É uma ave doméstica", "É um animal de médio porte que não voa")
    };

    // Use this for initialization
    void Start()
    {
        Animais.Shuffle();
        var primeiroAnimal = Animais.FirstOrDefault(/*a => a.Id == 1*/);
        SetPalavra(primeiroAnimal);
    }

    void SetPalavra(AnimalData animal)
    {
        CurrentAnimal = animal;
        Debug.Log(animal.Nome);
        Palavra = new char[animal.Nome.Length];
        for (int i = 0; i < Palavra.Length; i++)
            Palavra[i] = '_';

        UpdateTextoForca();
    }

    public void UpdatePalavra(char letra)
    {
        if (CurrentAnimal.NomeSemAcento.ToUpper().Contains(letra))
        {
            var listaIndices = CurrentAnimal.NomeSemAcento.ToUpper().Select((l, i) => l.Equals(letra) ? i : -1).Where(i => i >= 0);
            foreach (var indice in listaIndices)
                Palavra[indice] = CurrentAnimal.Nome.ToUpper()[indice];
            
            UpdateTextoForca();
        }
        //TODO: Dar algum feedback, para o caso de não encontrar a letra...
    }

    void UpdateTextoForca()
    {
        var textoLetras = new char[Palavra.Length * 2];
        var indicePalavra = 0;

        for (int i = 0; i < textoLetras.Length; i = i + 2)
        {
            textoLetras[i] = Palavra[indicePalavra];
            textoLetras[i + 1] = ' ';
            indicePalavra++;
        }

        TextoForca.text = new string(textoLetras);
        Debug.Log(TextoForca.text);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
