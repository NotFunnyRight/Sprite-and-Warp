using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] int score = 0;

    private void Awake()
    {
        int numGameCtrl = FindObjectsOfType<GameController>().Length;
        if (numGameCtrl > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    public void addScore()
    {
        score = score + 1;
    }
}
