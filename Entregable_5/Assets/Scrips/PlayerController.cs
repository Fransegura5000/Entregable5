using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector3 initialPos = Vector3.zero;
    private float speed = 10.0f;
    private float turnSpeed = 60.0f;
    private float verticalInput;
    private int zMax = 450;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = initialPos; //hacemos que vaya a la posición 0,0,0 (ya que no le hemos asignado un valor a esa variable).






    }

    // Update is called once per frame
    void Update()
    {

        
        verticalInput = Input.GetAxis("Vertical");           //con esto hacemos hacía donde van a estar los ejes
  



        transform.Translate(Vector3.forward * Time.deltaTime * speed); //con esta variable hacemos que se mueva en el eje Z con la variable velocidad y con el tiempo.

        transform.Rotate(Vector3.right * turnSpeed * Time.deltaTime * verticalInput); // Con este hacemos que rote hacia la derecha o izquierda.



        if (transform.position.z >= zMax)
        {
            Debug.Log(message: "THE END!");

            Time.timeScale = 0;





        }













    }

}
