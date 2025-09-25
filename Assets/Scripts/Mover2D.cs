using UnityEngine;
using UnityEngine.InputSystem;

public class Mover2D : MonoBehaviour
{
    //Variables publicas aparecen en inspector Unity
    //Float es decimal (f al final del numero si te coma)
    public float velocidad = 0.1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 direccio = new Vector3(0, 0, 0);

        if (Keyboard.current.wKey.isPressed)
        {
            direccio.y = 1;
        }

        if (Keyboard.current.dKey.isPressed)
        {
            direccio.x = 1;
        }

        if (Keyboard.current.sKey.isPressed)
        {
            direccio.y = -1;
        }

        if (Keyboard.current.aKey.isPressed)
        {
            direccio.x = -1;
        }

        transform.position = transform.position + direccio * velocidad * Time.deltaTime;

    }
}
