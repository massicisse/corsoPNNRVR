using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // asset del proiettile
    [SerializeField]
    private gameobject proiettile;

    //il punto da dove inizio a sparare
    [SerializeField]
     private transform firepoint;

    //l'azione che l'utente fa per sparare
    [SerializeField]
    private InputActionReference shootAction; 

   
    // Update is called once per frame
    void Update()
    {   

        //shootAction.action.WassPressedThisFrame-->
        // se ho premuto in questo frame da come valore 0 altrimenti da ome valore falso 
        
        if(shootAction.action.WassPressedThisFrame()){
            
           // instantiate= > Crea
           // Crea il proiettile nella posizione firepoint.position,con rotazione firepoint.rotation
 
            instantiate(proiettile,firepoint.position,firepoint.rotation)

         }
    }
}
