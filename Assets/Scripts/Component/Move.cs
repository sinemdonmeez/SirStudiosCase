using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    /* ------------------------------------------ */

    public JoyStick JoyStick;

    public CharacterController CharacterController;

    public Transform MeshChar;

    public float Speed;

    /* ------------------------------------------ */
    
    float _inputX, _inputY;

    Vector3 _posMove, _posRotate;

    /* ------------------------------------------ */

    private void Update()
    {
        Rotate();
        Movement();
    }

    /* ------------------------------------------ */

    void Movement()
    {
        _posMove = this.transform.forward*Speed*Time.deltaTime;
        CharacterController.Move(_posMove);
    }

    void Rotate() 
    {
        _inputX = JoyStick.InputHorizontal();
        _inputY = JoyStick.InputVertical();

        _posRotate = new Vector3(_inputX , 0, _inputY);
        MeshChar.rotation = Quaternion.LookRotation(_posRotate);
    }

    /* ------------------------------------------ */

}
