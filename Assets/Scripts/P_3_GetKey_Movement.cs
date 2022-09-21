using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P_3_GetKey_Movement : MonoBehaviour
{
    public float velocidad = 10;

    Vector3 mov;

    [SerializeField]
    float ejemplo = 5;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Codigo Ejecuta una vez");
    }

    // Update is called once per frame
    void Update()
    {
        ///EXPLICACION 1
        mov = transform.forward; //relacion al personaje

        mov = Vector3.forward;  //con relacion a la escena
        mov = Vector3.back;

        mov = new Vector3(10, 10, 10f); //x y z
        ///

        if (Input.GetKey(KeyCode.W)){
            transform.Translate(
                transform.forward * velocidad * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("A");
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(
                transform.forward * -1 * velocidad * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("D");
        }
    }
}
