using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Skill : MonoBehaviour
{
   
    public abstract void ExcutSkill(PlayerState ps, GameObject Character);
    public abstract void SkillLevelUp();
    public abstract int GetSkillLevel();
    public abstract float GetCoolTime();


    
}
