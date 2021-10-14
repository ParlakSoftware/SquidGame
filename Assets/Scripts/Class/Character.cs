using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour, ICharacter
{
    private float speed;
    private string name;
    private bool stop;
    private Rigidbody rigidbody;
    public Color renk { get; set; }

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

    public Character(string name, float speed, Rigidbody rigidbody)
    {
        this.Name = name;
        this.Speed = speed;
        this.rigidbody = rigidbody;
    }

    public void Dead()
    {
        this.Name = "Öldüm";
        Debug.Log(Name);
    }

    public void Idle()
    {
        isStop = true;
    }

    public void Walk()
    {
        rigidbody.velocity = new Vector3(0, 0, Speed);
        isStop = false;
    }
}