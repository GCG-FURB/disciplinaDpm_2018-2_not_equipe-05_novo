using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class AnimalData {
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }

    public AnimalData() { }

    public AnimalData(int id, string nome, string descricao)
    {
        Id = id;
        Nome = nome;
        Descricao = descricao;
    }
}
