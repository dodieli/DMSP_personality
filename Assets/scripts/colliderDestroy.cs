using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerEnter(Collider obj) 
    {
        GameObject root = GameObject.Find("root");
        GameObject split_particle = root.transform.Find("Cylinder_destroy/split_particle").gameObject;

        if(obj.tag=="Player"){
            split_particle.SetActive(true);
            Destroy(this.gameObject);
        } 
    }

    void OnTriggerExit(Collider collision) { }
    void OnTriggerStay(Collider collision) { }
    
}
