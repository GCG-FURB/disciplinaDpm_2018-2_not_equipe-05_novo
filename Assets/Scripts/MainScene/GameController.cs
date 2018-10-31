using Assets.Scripts.ExtensionMethods;
using Assets.Scripts.MainScene;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Vuforia;

public class GameController : MonoBehaviour
{
    public Text TextoForca;

    public Text LetrasCertas;

    public Text LetrasErradas;

    private char[] Palavra { get; set; }

    private List<char> LetrasLidas { get; set; }

    private List<char> LetrasCorretas { get; set; }

    private List<char> LetrasIncorretas { get; set; }

    private int CountLetrasErradas { get; set; }

    // Use this for initialization
    void Start()
    {
        LetrasLidas = new List<char>();
        LetrasCorretas = new List<char>();
        LetrasIncorretas = new List<char>();
        StaticProperties.Instance.SetCurrentAnimal();
        SetPalavra();
    }

    void SetPalavra()
    {
        Debug.Log(StaticProperties.Instance.CurrentAnimal.Nome);
        Palavra = new char[StaticProperties.Instance.CurrentAnimal.Nome.Length];
        for (int i = 0; i < Palavra.Length; i++)
            Palavra[i] = '_';

        UpdateTextoForca();
        CountLetrasErradas = 0;
    }

    public void UpdatePalavra(char letra)
    {
        if (!LetrasLidas.Contains(letra))
        {
            if (StaticProperties.Instance.CurrentAnimal.NomeSemAcento.ToUpper().Contains(letra))
            {
                var listaIndices = StaticProperties.Instance.CurrentAnimal.NomeSemAcento.ToUpper().Select((l, i) => l.Equals(letra) ? i : -1).Where(i => i >= 0);
                foreach (var indice in listaIndices)
                    Palavra[indice] = StaticProperties.Instance.CurrentAnimal.Nome.ToUpper()[indice];

                LetrasCorretas.Add(letra);
                UpdateTextoForca();
                UpdateTextoLetras(LetrasCertas, LetrasCorretas, letra);
            }
            else
            {
                CountLetrasErradas++;
                LetrasIncorretas.Add(letra);
                UpdateTextoLetras(LetrasErradas, LetrasIncorretas, letra);
            }

            VerificarCondicoesFimJogo();
        }
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

    void UpdateTextoLetras(Text textUI, List<char> letras, char letra)
    {
        LetrasLidas.Add(letra);

        int i = 0;
        string texto = string.Empty;

        letras.ForEach(l =>
        {
            if (i < 5)
                texto += l + " ";
            else
            {
                texto += "\r\n" + l + " ";
                i = 0;
            }

            i++;
        });

        textUI.text = texto;
        Debug.Log(texto);
    }

    private void VerificarCondicoesFimJogo()
    {
        Debug.Log(Palavra.Count(letra => letra.Equals('_')));

        if (CountLetrasErradas >= 5)
        {
            //VuforiaBehaviour.Instance.enabled = false;
            //VuforiaRuntime.Instance.Deinit();

            SceneManager.LoadScene("LostScene");
        }
        else if (Palavra.Count(letra => letra.Equals('_')) == 0)
        {
            //VuforiaBehaviour.Instance.enabled = false;
            //VuforiaRuntime.Instance.Deinit();

            if (StaticProperties.Instance.AnimaisJogados.Count < StaticProperties.Instance.Animais.Count - 1)
                SceneManager.LoadScene("WinScene");
            else
                SceneManager.LoadScene("FinalScene");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
