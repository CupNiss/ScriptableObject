using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public EnemyObject enemyAtributes;
    
    public string name;
    public float health;
    public float speed;
    public float attack;

    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
        anim.runtimeAnimatorController = enemyAtributes.animaController;

        name = enemyAtributes.name;
        health = enemyAtributes.health;
        speed = enemyAtributes.speed;
        attack = enemyAtributes.attack;
    }
}
