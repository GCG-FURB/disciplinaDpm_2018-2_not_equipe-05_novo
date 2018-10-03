using Assets.Scripts.ExtensionMethods;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text TextoForca;

    private char[] Palavra { get; set; }

    private List<AnimalData> Animais = new List<AnimalData>
    {
        new AnimalData(1, "Borboleta", "Pertence à classe dos insetos\r\nPossui asas\r\nAlimenta-se de néctar"),
        new AnimalData(2, "Vaca", "É um mamífero de grande porte\r\nÉ um animal ruminante\r\nAlimenta-se de pastagem, capins e fenos"),
        new AnimalData(3, "Caranguejo", "É um crustáceo\r\nHabita regiões litorâneas\r\nPossui uma carapaça"),
        new AnimalData(4, "Rato", "É um animal roedor\r\nTem o olfato aguçado\r\nTem quatro patas e uma longa cauda"),
        new AnimalData(5, "Caracol", "Pertence ao filo dos moluscos\r\nÉ encontrado em jardins, hortas e pomares\r\nCarrega em seu corpo um esqueleto externo que chamamos de concha"),
        new AnimalData(6, "Peixe", "Encontrado nos mais variados ambientes aquáticos\r\nPossui o corpo alongado e fino\r\nPossui escamas"),
        new AnimalData(7, "Escorpião", "É um animal terrestre invertebrado\r\nPassa o dia escondido em lugares escuros\r\nPossui pinças"),
        new AnimalData(8, "Sapo", "É um anfíbio\r\nAs patas traseiras do sapo estão adaptadas para nadar e pular\r\nAlimenta-se de insetos"),
        new AnimalData(9, "Bode", "Mamífero dotado de chifre\r\nÉ ruminante\r\nSeu habitat geralmente são montanhas"),
        new AnimalData(10, "Lobo", "Vive em grupos liderados por um macho alfa\r\nÉ um animal carnívoro\r\nOs uivos são usados como forma de comunicação entre eles"),
        new AnimalData(11, "Pato", "É uma ave\r\nSe alimenta preferencialmente de vegetais, grãos e sementes\r\nÉ um dos poucos animais que andam, nadam e voam"),
        new AnimalData(12, "Jacaré", "Vive em grupos\r\nÉ carnívoro\r\nPrefere o meio aquático, vivendo em rios, lagos e pântanos"),
        new AnimalData(13, "Urso", "A coloração da pele muda de espécie para espécie\r\nEsse animal hiberna durante o inverno\r\nCome o que encontra disponível, desde frutos, folhas e raízes a outros animais"),
        new AnimalData(14, "Tucano", "É um animal relativamente grande e possui cores bem vivas\r\nTem um temperamento dócil e é inteligentíssimo\r\nPossui um bico bem comprido"),
        new AnimalData(15, "Baleia", "Quando mergulha, consegue ficar longos períodos sem respirar\r\nMamífero que ocupa todos os oceanos do mundo\r\nÉ um animal grande, podendo pesar até 180 toneladas"),
        new AnimalData(16, "Tigre", "Animal imponente e muito perigoso\r\nÉ o maior felino encontrado na natureza\r\nClassificado como mamífero e carnívoro"),
        new AnimalData(17, "Porco", "É um mamífero\r\nPossui quatro patas com quatro dedos\r\nAlimenta-se de verduras, legumes, grãos e restos de alimentos"),
        new AnimalData(18, "Polvo", "Se alimenta de peixes e crustáceos\r\nVive na água dos oceanos escondido entre rochas\r\nPossui um corpo mole coberto por uma pele sensível à luz"),
        new AnimalData(19, "Tubarão", "Alimenta-se de peixes, tartarugas, lulas e raias\r\nÉ um vertebrado aquático\r\nRespira por meio de guelras e nada graças às barbatanas que têm"),
        new AnimalData(20, "Coelho", "É um animal noturno\r\nPossui corpo arredondado, cabeça e olhos grandes, orelhas longas e largas\r\nVive em buracos e tocos de árvores"),
        new AnimalData(21, "Galinha", "Alimenta-se de milho e outros grãos\r\nÉ uma ave doméstica\r\nÉ um animal de médio porte que não voa")
    };

    // Use this for initialization
    void Start()
    {
        Debug.Log("AR Camera Loaded");
        Animais.Shuffle();
        var primeiroAnimal = Animais.FirstOrDefault();
        SetPalavra(primeiroAnimal);
    }

    void SetPalavra(AnimalData animal)
    {
        Debug.Log(animal.Nome);
        Palavra = new char[animal.Nome.Length];
        for (int i = 0; i < Palavra.Length; i++)
            Palavra[i] = '_';

        var textoLetras = new char[animal.Nome.Length * 2];
        for (int i = 0; i < textoLetras.Length; i = i + 2)
        {
            textoLetras[i] = '_';
            textoLetras[i + 1] = ' ';
        }

        TextoForca.text = new string(textoLetras);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
