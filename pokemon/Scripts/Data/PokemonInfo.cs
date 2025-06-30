using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PokemonInfo
{
    public readonly string Id;
    public string originId { get; set; }
    public string ownerId { get; set; }
    public string name { get; set; }
    public string originName { get; set; }
    public string desc { get; set; }
    public NatureTypeEnum natureType { get; set; }
    public float height { get; set; }
    public float weight { get; set; }
    public ExpTypeEnum expType { get; set; }
    public string sexRatio { get; set; }
    public int catchRatio { get; set; }

    public PokemonInfo(string id, string originId, string ownerId, string name, string originName, string desc,
        NatureTypeEnum natureType, float height, float weight, ExpTypeEnum expType, string sexRatio, int catchRatio)
    {
        Id = id;
        this.originId = originId;
        this.ownerId = ownerId;
        this.name = name;
        this.originName = originName;
        this.desc = desc;
        this.natureType = natureType;
        this.height = height;
        this.weight = weight;
        this.expType = expType;
        this.sexRatio = sexRatio;
        this.catchRatio = catchRatio;
    }
}