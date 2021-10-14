using Assets.Scripts.Class;
using Assets.Scripts.Interface;
using Assets.Scripts.Manager;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class ControlCenter : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject character;

    public float time;
    public float timer;
    public bool isTurn;
    public bool stop;
    CharacterManager characterScript;
    UserInterfaceManager userInterfaceScript;
    IDelay Delay;
    // Start is called before the first frame update
    void Start()
    {
        characterScript = character.GetComponent<CharacterManager>();
        userInterfaceScript = GetComponent<UserInterfaceManager>();
        Delay = new Delay();
        ZeroTime(0);
    }

    // Update is called once per frame
    void Update()
    {
        stop = characterScript.character.isStop;
        GameControl();
        TimeControl();
    }   
    void TimeControl()
    {
        if (!isTurn && timer < time)
        {
            timer += Time.deltaTime;
        }
        else
        {
            isTurn = true;
            audioSource.Pause();
            ZeroTime(Random.Range(1, 4));
        }
    }
    void GameControl()
    {
        if (isTurn)
        {
            if (Delay.Wait(1))
            {
                if(!stop)
                {
                    userInterfaceScript.userInterface.TryAgain();
                    characterScript.character.Dead();
                    this.enabled = false;
                }
            }
        }
    }
    void ZeroTime(float t)
    {
        timer = 0;
        if (Delay.Wait(t))
        {
            time = Random.Range(5, 8);
            isTurn = false;
            audioSource.Play();
        }
    }
    
}
