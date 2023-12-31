using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    #region Stats
    [Header("- Health Type")]
    public static float maxHealth = 10000f;
    public static float defensivePower = 5f;
    public static int dodgeChance = 10;

    [Header("- Move Type")]
    public static float walkSpeed = 14f;

    [Header("- Attack Type")]
    public static float bulletDamage = 15f;
    public static float bulletSpeed = 3000f;
    public static float shotSpeed = 1.5f;
    public static int criticalChance = 10;
    public static float criticalDamage = 55f;

    [Header("- etc. Type")]
    public static int level = 1;
    public static float haveExperience = 0f;
    public static int timeLevel = 1;
    public static float playTimes = 0f;
    #endregion
}
