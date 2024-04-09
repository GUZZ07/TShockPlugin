﻿using Economics.Skill.Model;
using Newtonsoft.Json;


namespace Economics.Skill.Setting;

public class Config
{
    [JsonProperty("购买主动技能最大数量")]
    public int SkillMaxCount { get; set; }

    [JsonProperty("单武器绑定最大技能数量")]
    public int WeapoeBindMaxCount { get; set; }

    [JsonProperty("禁止拉怪表")]
    public HashSet<int> BanPullNpcs { get; set; }

    [JsonProperty("技能唯一性")]
    public bool SkillUnique { get; set; }

    [JsonProperty("技能列表")]
    public List<SkillContext> SkillContexts { get; set; } = new();

    public SkillContext? GetSkill(int index)
    {
        if (index < 1 || index > SkillContexts.Count)
            return null;
        return SkillContexts[index];
    }
}
