using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    protected int playerLives;
    protected float playerSpeed;
    protected float playerFireRate;
    protected Vector3 playerMisileOffset;

    private float horizontalInput;
    private float verticalInput;



    public void CharacterMovement()
    {

        horizontalInput = Input.GetAxis("Horizontal") * playerSpeed * Time.deltaTime;
        verticalInput = Input.GetAxis("Vertical") * playerSpeed * Time.deltaTime;
        transform.Translate(new Vector3(horizontalInput, 0, verticalInput));


    }

    public void ShootMisiles()
    {
        GameObject misile = ObjectPooler.SharedInstance.GetPooledObject();
        if (misile != null)
        {
            misile.transform.position = transform.position - new Vector3(-playerMisileOffset.x, playerMisileOffset.y, playerMisileOffset.z);
            misile.transform.rotation = transform.rotation;
            misile.SetActive(true);
        }

        GameObject misile2 = ObjectPooler.SharedInstance.GetPooledObject();
        if (misile != null)
        {
            misile2.transform.position = transform.position - playerMisileOffset;
            misile2.transform.rotation = transform.rotation;
            misile2.SetActive(true);
        }


    }

}
