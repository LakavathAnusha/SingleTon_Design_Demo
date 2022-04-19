using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //Using navmesh and Ray cast game any Game
  
    public GameObject healthPrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            RaycastHit hitInformation;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray.origin,ray.direction,out hitInformation))
            {
              GameObject temp =  Instantiate(healthPrefab, hitInformation.point, Quaternion.identity);
                //GameManager.Instance.AddTransCan(temp);
            }
        }
        
    }
   
}
