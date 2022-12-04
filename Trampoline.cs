using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    // увеличение силы прыжка
    void OnTriggerEnter(Collider other)
    {

        other.GetComponent<Jump>().jumpStrength = 10;

    }

    // уменьшение силы прыжка
    void OnTriggerExit(Collider other)
    {

        other.GetComponent<Jump>().jumpStrength = 2;

    }

}
