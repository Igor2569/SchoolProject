using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager1 : MonoBehaviour
{
    public static GameManager1 instance;
    public GameObject keyroom2;
    public GameObject keyroom3;
    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
            instance = this;

        return;

    }
}
