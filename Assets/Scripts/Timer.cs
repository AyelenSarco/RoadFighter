using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] TMP_Text textTimer;

    void Update()
    {
        textTimer.text = GameManager.timeElapsed.ToString("f1") ; //Variable tiempo en el game manager    
    }
}
