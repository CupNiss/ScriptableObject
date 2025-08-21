using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "EnemyAttributes", menuName = "Enemy/New Enemy")]

public class EnemyObject : ScriptableObject
{
    public string name;
    public float health;
    public float speed;
    public float attack;

    public RuntimeAnimatorController animaController;
}
