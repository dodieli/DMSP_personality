using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderMove : MonoBehaviour
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
        if(obj.tag=="Player"){
            //GetComponent<ParticleSystem>().Play();
            Debug.Log("success");
            this.transform.Translate(Vector3.up * Time.deltaTime * 10);
        } 
    }

    void OnTriggerExit(Collider collision) { }
    void OnTriggerStay(Collider collision) { }
}
