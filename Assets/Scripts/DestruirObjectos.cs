using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirObjectos : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Destroy(gameObject);
        }
    }
}
