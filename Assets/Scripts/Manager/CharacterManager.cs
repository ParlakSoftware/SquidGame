using Assets.Scripts.Class;
using Assets.Scripts.Class.DeviceController;
using Assets.Scripts.Interface;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    public string name;
    public float speed;
    public bool stop;
    public ICharacter character;

    IDeviceController deviceController;
    // Start is called before the first frame update
    void Start()
    {
        character = new Character(name, speed, GetComponent<Rigidbody>(),GetComponent<Animator>());
        deviceController = new DesktopController();
    }

    // Update is called once per frame
    void Update()
    {
        stop = character.isStop;
        deviceController.Walk(character);
        deviceController.TryAgain();
    }
}
