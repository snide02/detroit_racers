using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cones_Script : MonoBehaviour
{ 
    Vector3 pos;
    Vector3 scale;
    
    // Start is called before the first frame update
    int num, count;
    void Start()
    {
        count = 0;
        num = 2;
        pos = transform.position;
       // transform.position = new Vector3(0, 0, 0);
        scale = transform.localScale;
        
    }

    // Update is called once per frame
    void Update()  
    {  
        Debug.Log(count);
        count = count +1;
        Debug.Log(num); // print number
        if (count >= 1000){
            if(Time.timeScale == 1f){
                //Debug.Log(transform.position.y);
                if (transform.position.y >= -7 )
                {
                    transform.localScale = transform.localScale + new Vector3(.04f, .04f, 0);
                    //transform.position = transform.position + new Vector3(-.01f, -.011f, 0);
                    //transform.position = transform.position + new Vector3(0, -.011f, 0);             
                    if (num == 1)
                    {
                        transform.position = transform.position + new Vector3(-.075f, -.033f, 0);
                    }
                    if (num == 2)
                    {
                        transform.position = transform.position + new Vector3(0, -.033f, 0);
                    }
                    if (num == 3)
                    {
                        transform.position = transform.position + new Vector3(.075f, -.033f, 0);
                    }
                }
                else
                {   //This is once it gets to car (if y IS NOT >= -7)
                    transform.position = transform.position + new Vector3(0, -.60f, 0);
                }
                
                if (transform.position.y <= -10)  //Then it goes back to where it was
                {   
                    transform.position = pos;
                    transform.localScale = scale;
                    
                    //Generate random number 1-3
                    num = Random.Range(1,4); // Numbers between 1-3
                } 
            } 
        }   
    }

}
 