using Mirror;
using UnityEngine;

public class Player : NetworkBehaviour
{
    [SerializeField] float _playerSpeed;


    void HandleMovement()
    {
        if (isLocalPlayer)
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            var movement = new Vector3(moveHorizontal, moveVertical, 0) * _playerSpeed * Time.deltaTime;
            transform.position = transform.position + movement;


        }
    }

    private void Update()
    {
        HandleMovement();
    }


}
