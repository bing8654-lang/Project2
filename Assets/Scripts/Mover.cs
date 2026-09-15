using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float MoveSpeed = 3f;
    [SerializeField] float Movelimit = 5f;

    InputHandler inputHandler;

    private void Awake()
    {
        inputHandler = GetComponent<InputHandler>();
    }

    private void Update()
    {
        Vector2 CurrentInput = inputHandler.MoveInput;

        if(CurrentInput != Vector2.zero)
        {
            Vector3 MoveDir = new Vector3(CurrentInput.x, 0, 0);
            MoveDir.Normalize();
            transform.Translate(MoveDir *  MoveSpeed * Time.deltaTime);

            float climpedX = Mathf.Clamp(transform.position.x, -Movelimit, Movelimit);

            transform.position = new Vector3(climpedX,transform.position.y, transform.position.z);
        }

    }
}
