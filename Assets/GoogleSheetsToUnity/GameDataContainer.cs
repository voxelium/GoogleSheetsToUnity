using NorskaLib.Spreadsheets;
using System;
using System.Collections.Generic;
using UnityEngine;


[Serializable]
public class SpreadshetContent
{
    [SpreadsheetPage("Units")]
    public List<UnitData> Units;
    [SpreadsheetPage("Skills")]
    public List<SkillData> Skills;
    [SpreadsheetPage("UnitsSkills")]
    public List<UnitSkillData> UnitsSkills;
}

[CreateAssetMenu(fileName = "GameData", menuName = "GameData")]
public class GameDataContainer : SpreadsheetsContainerBase
{
    [SpreadsheetContent]
    [SerializeField] SpreadshetContent content;
    public SpreadshetContent Content => content;
}


[Serializable]
public class UnitData
{
    public string id;

    public int Health;
    public int Damage;
}

[Serializable]
public class UnitSkillData
{
    public string idUnit;

    public string idSkill;
}

[Serializable]
public class SkillData
{
    public string Id;

    public float Cost;
    public float Cooldown;
}