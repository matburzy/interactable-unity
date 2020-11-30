using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectable : Interactable
{
    
    private void OnTriggerEnter(Collider other)
    {
        // sprawdza czy gracz wszedl w trigger
        if(other.tag == "Player")
        {
            InteractablePrompt.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // sprawdza czy gracz wyszedł z triggera
        if (other.tag == "Player")
        {
            InteractablePrompt.SetActive(false);
        }
    }


    void Start()
    {     
    }


    void Update()
    {

        if (InteractablePrompt.activeSelf == true)
        {
            if (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Space))
            {
                Player.GetComponent<ScoreSystem>().PointUp();
                // inaczej zniszczy obie kulki a tego nie chcemy
                InteractablePrompt.SetActive(false);
                Destroy(this.gameObject);
            }
        }


        float dist = Vector3.Distance(this.gameObject.transform.position, GameObject.FindGameObjectWithTag("Player").transform.position);

        Debug.Log("Nazwa obiektu: " + this.gameObject.name + " " + dist);
        if (dist < 1.5)
        {
            Debug.Log("Jesteś w okolicy obiektu");
        }
    }
}
