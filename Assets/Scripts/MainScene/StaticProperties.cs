using Assets.Scripts.ExtensionMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.MainScene
{
    public sealed class StaticProperties
    {
        public AnimalData CurrentAnimal { get; private set; }

        public List<AnimalData> Animais = new List<AnimalData>
        {
            new AnimalData(1, "Borboleta", "Pertence a classe dos insetos.", "Possui asas", "Alimenta-se de néctar"),
            new AnimalData(2, "Vaca", "É um mamífero de grande porte", "Possui pelagem curta.", "Alimenta-se de pastagem, capins e fenos."),
            new AnimalData(3, "Caranguejo", "É um crustáceo.", "Habita regiões litorâneas e mangues.", "Possui uma carapaça."),
            new AnimalData(4, "Rato", "É um animal roedor.", "É um mamífero.", "Tem quatro patas e uma longa cauda."),
            new AnimalData(5, "Caracol", "Pertence ao filo dos moluscos.", "É encontrado em jardins, hortas e pomares.", "Carrega em seu corpo um esqueleto externo que chamamos de concha."),
            new AnimalData(6, "Peixe", "Habita ambientes aquáticos de água doce ou salgada.", "Possui corpo alongado e fino.", "Possui escamas."),
            new AnimalData(7, "Escorpião", "É um animal invertebrado da classe dos aracnídeos.", "Possui 8 patas.", "Possui pinças."),
            new AnimalData(8, "Sapo", "É um anfÍbio.", "Suas patas traseiras estão adaptadas para nadar e pular.", "Alimenta-se de insetos."),
            new AnimalData(9, "Bode", "Mamífero dotado de chifre.", "É ruminante.", "Pertence à espécie Capra."),
            new AnimalData(10, "Lobo", "Vive em grupos liderados por um macho alfa.", "É um animal carnívoro.", "É um mamíferos de pelagem longa."),
            new AnimalData(11, "Pato", "É uma ave.", "Se alimenta preferencialmente de vegetais, grãos e sementes.", "É um dos poucos animais que podem: andar, nadar e voar."),
            new AnimalData(12, "Jacaré", "É um réptil.", "É carnívoro.", "Vive tanto no meio terrestre quanto no meio aquático (água doce)."),
            new AnimalData(13, "Urso", "É um mamífero de grande porte.", "Este animal hiberna durante o inverno.", "Come o que encontra disponível, desde frutos, folhas, raízes e até outros animais."),
            new AnimalData(14, "Tucano", "É uma ave.", "Possui cores bem vivas.", "Possui um bico bem comprido."),
            new AnimalData(15, "Baleia", "Quando jovem apresenta uma fina camada de pelos.", "Mamífero que ocupa todos os oceanos do mundo.", "É um animal grande, podendo pesar até 180 toneladas."),
            new AnimalData(16, "Tigre", "É o maior felino encontrado na natureza.", "É um mamífero.", "Possui pelagem curta e listrada."),
            new AnimalData(17, "Porco", "É um mamífero e seu tamanho pode variar muito.", "Possui um focinho alongado e redondo.", "Possui uma pelagem curta."),
            new AnimalData(18, "Polvo", "Se alimenta de peixes e crustáceos", "Vive na água dos oceanos escondidos entre rochas", "Possui um corpo mole coberto por uma pele sensível a luz "),
            new AnimalData(19, "Tubarão", "Alimenta-se de peixes, tartarugas, lulas e raias.", "É um vertebrado aquático.", "Possui mais de 1.000 dentes triangulares."),
            new AnimalData(20, "Coelho", "É um mamífero.", "Possui orelhas longas e largas.", "Possui pelagem curta."),
            new AnimalData(21, "Galinha", "Alimenta-se de milho e outros grãos.", "É um ave doméstica.", "É um animal de médio porte que não voa.")
        };

        public List<AnimalData> AnimaisJogados { get; set; }

        private static StaticProperties _instance;

        public static StaticProperties Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new StaticProperties();

                return _instance;
            }
        }

        private StaticProperties()
        {
            AnimaisJogados = new List<AnimalData>();
        }

        public void SetCurrentAnimal()
        {
            Debug.Log("SetCurrentAnimal");
            var animaisDisponiveis = Animais.Except(AnimaisJogados).ToList();
            animaisDisponiveis.Shuffle();
            CurrentAnimal = animaisDisponiveis.FirstOrDefault(/*a => a.Id == 20*/);
        }

        public void AddAnimalJogado()
        {
            AnimaisJogados.Add(CurrentAnimal);
        }

        public void ClearAnimaisJogados()
        {
            AnimaisJogados.Clear();
            CurrentAnimal = null;
        }
    }
}
