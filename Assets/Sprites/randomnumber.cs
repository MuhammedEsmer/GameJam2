using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class randomnumber : MonoBehaviour

{ [Serializefield] TextMeshProUGUI _randomnumber;
    private void Update()
    {
        num1 = Random.Range(1, 10);
        _randomnumber.text = num1;

    }

}