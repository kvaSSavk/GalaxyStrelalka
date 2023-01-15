using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KamekadzeShip : MonoBehaviour
{
    // Start is called before the first frame update
    public MoveDirections direction;
    private float speed = 0.1f;

    void Start()
    {
        
    }

    // Update is called once per frame
    public void FixedUpdate()
    {
        switch(direction) {
            case MoveDirections.right:
                Vector3 newPosition = new Vector3(transform.position.x + speed, transform.position.y, 0);
                bool isOnScreen = ScreenHelpers.ObjectNah(newPosition);
                if (isOnScreen == true) {
                    transform.position = newPosition;
                }   else {
                    direction = MoveDirections.down;
                }
                break;
            case MoveDirections.left:
                //left
                break;
            case MoveDirections.up:
                //up
                break;
            case MoveDirections.down:
                //down
                break;


        }
    }
}
