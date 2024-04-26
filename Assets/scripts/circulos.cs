using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleProperties : MonoBehaviour
{
    public char letter;

    private void OnMouseDown()
    {
        if (Input.inputString == letter.ToString())
        {
            Destroy(gameObject);
        }
    }
}
