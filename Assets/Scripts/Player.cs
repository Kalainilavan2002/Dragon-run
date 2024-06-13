using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float movespeed = 4f;
    public float sidespeed = 7f;
    public float jumpHeight = 2f;
    public float jumpDuration = 0.6f; // Total time for the jump
    public GameObject player;
    LevelBoundary levelBoundary=new LevelBoundary();
    

    static public bool canMove = false;
    static public bool canMove1 = true;
    static public bool canMove2 = false;
    private bool isJumping = false;
    private float originalY;

    private void Start()
    {
        originalY = transform.position.y;
       
    }

    void Update()
    {


        if (canMove2 == true)
        {
            if (canMove1 == true)
            {

                transform.Translate(Vector3.forward * movespeed * Time.deltaTime, Space.World);

                if (canMove == true)
                {
                    if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
                    {
                        if (this.gameObject.transform.position.x > levelBoundary.leftside)
                        {
                            transform.Translate(Vector3.left * sidespeed * Time.deltaTime);
                        }
                    }
                    if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
                    {
                        if (this.gameObject.transform.position.x < levelBoundary.rightside)
                        {
                            transform.Translate(Vector3.right * sidespeed * Time.deltaTime);

                        }

                    }
                    if ((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.Space)) && !isJumping)
                    {
                        isJumping = true;
                        player.GetComponent<Animator>().Play("Jump");
                        StartCoroutine(JumpSequence());
                    }
                }
            }
        }
    }

    IEnumerator JumpSequence()
    {
        float jumpSpeed = (2 * jumpHeight) / (jumpDuration / 2); // Speed needed to reach the jumpHeight
        float halfJumpDuration = jumpDuration / 2;

        // Ascend
        for (float t = 0; t < halfJumpDuration; t += Time.deltaTime)
        {
            transform.Translate(Vector3.up * jumpSpeed * Time.deltaTime, Space.World);
            transform.Translate(Vector3.forward * 6 * Time.deltaTime, Space.World);
            yield return null;
        }

        // Descend
        for (float t = 0; t < halfJumpDuration; t += Time.deltaTime)
        {
            transform.Translate(Vector3.up * -jumpSpeed * Time.deltaTime, Space.World);
            yield return null;
        }

        // Reset Y position to original value to avoid drift
        Vector3 position = transform.position;
        position.y = originalY;
        transform.position = position;

        isJumping = false;

        if (Player.canMove1)
        {
            player.GetComponent<Animator>().Play("Standard Run");
        }
    }
}
