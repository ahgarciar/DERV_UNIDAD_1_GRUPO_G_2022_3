using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P_4_Rotacion : MonoBehaviour
{
    [SerializeField]
    float angulo = 90f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Codigo Ejecuta una vez");
    }

    // Update is called once per frame
    void Update()
    {         
        if (Input.GetKey(KeyCode.F))
        {
            Quaternion origen = transform.rotation;
            Quaternion destino = Quaternion.Euler(new Vector3(0, angulo, 0));

            transform.transform.rotation = Quaternion.Slerp(origen,
                destino, 0.1f * Time.deltaTime);
        
        }
        if (Input.GetKey(KeyCode.G))
        {
            Quaternion origen = transform.rotation;
            Quaternion destino = Quaternion.Euler(new Vector3(0, -1f * angulo, 0));

            transform.transform.rotation = Quaternion.Slerp(origen,
                destino, 100.0f * Time.deltaTime);
        }

        Debug.Log(transform.rotation.y);
    }
}
