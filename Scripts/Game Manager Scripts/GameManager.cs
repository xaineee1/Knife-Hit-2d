using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private Button shootBtn;

    [SerializeField]
    private GameObject knife;

    private GameObject[] knifes;

    [SerializeField]
    private int howManyKnifes;

    [SerializeField]
    private float knifeDistance;
    private int knifeIndex;

    private void Start()
    {
        
    }

}
