using Assets.Scripts.Class;
using Assets.Scripts.Interface;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour, ICharacter
{
    private float speed;
    private string name;
    private bool stop;
    private Rigidbody rigidbody;
    private Animator anim;
    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            this.name = value;
        }
    }
    public float Speed
    {
        get
        {
            return this.speed;
        }
        set
        {
            if (value < 0) this.speed = 0;
            else this.speed = value;
        }
    }

    public bool isStop
    {
        get { return this.stop; }
        set { this.stop = value; }
    }

    public Character(string name, float speed, Rigidbody rigidbody,Animator anim)
    {
        this.Name = name;
        this.Speed = speed;
        this.rigidbody = rigidbody;
        this.anim = anim;
        isStop = true;
    }

    public void Dead()
    {
        this.Name = "Öldüm";
        Speed = 0;
        anim.SetBool("Dead", true);
    }

    public void Idle()
    {
        isStop = true;
        anim.SetBool("Idle", true);
        anim.SetBool("Walk", false);
        rigidbody.velocity = Vector3.zero;
    }

    public void Walk()
    {
        rigidbody.velocity = new Vector3(0, 0, Speed);
        anim.SetBool("Idle", false);
        anim.SetBool("Walk", true);
        isStop = false;
    }
}