using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour
{
    public GameObject player; //此時須定義player身分
    private Vector3 offset = new Vector3(1149, 1643, 16);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //offset the camera to the right place
        transform.position = player.transform.position + offset;
        //將攝影機位置設在player的位置高5後10的位置(x,y,z)

    }

}
