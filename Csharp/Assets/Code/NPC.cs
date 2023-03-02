using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    //Здоровье NPC
    public int health = 3;
    //Уровень NPC
    public int level = 2;
    //Скорость NPC
    public float speed = 1.4f;


    // Start is called before the first frame update
    void Start()
    {
       health += level;
        print(health);

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;

    }
}
