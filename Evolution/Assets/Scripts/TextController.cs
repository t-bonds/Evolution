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
         instructionsText.text = "Evolution " +
                                 "Use the left and right keys to move forward and backwards. " +
                                 "Use the space bar to jump. To defend enemies, jump on top of them. " +
                                 "Collect tokens to move to the next level and evolve.";
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
