using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{
    public Text instructionsText;
    // Start is called before the first frame update
    void Start()
     {
         Time.timeScale = 0;
     }
 
     void Update () 
     {
         if(Input.anyKeyDown)
         {
             Time.timeScale = 1;
             Destroy(gameObject);
         }
     }
}
