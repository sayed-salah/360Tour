using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine;

public class Pointer : MonoBehaviour
{
    public GameObject player;
    public LayerMask wallsfloorlayer;
    private RaycastHit hit;
    private EventSystem eventSystem;

   
    

    // Start is called before the first frame update
    void Start()
    {

        eventSystem = EventSystem.current;
       

    }

    // Update is called once per frame
    void Update()
    {
       

        if (Physics.Raycast(transform.position, transform.forward, out hit,100, wallsfloorlayer))
        {
            if (hit.collider.tag == "Floor")
            {
                if ( Input.GetMouseButtonDown(0))
                {
                    Vector3 position = player.transform.position;

                    Vector3 newposition = hit.point;

                    position.x = newposition.x;
                    position.z = newposition.z;
                    player.transform.position = position;
                }
            }

        }
        
    }
}
