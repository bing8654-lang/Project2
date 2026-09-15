using UnityEngine;

public class Jumper : MonoBehaviour
{
    [SerializeField] float JumpPower = 3.0f;

    InputHandler inputHandler;

    public void Awake()
    {
        inputHandler = GetComponent<InputHandler>();
    }

    private void Update()
    {

        if (inputHandler.JumpInput)
        {
            transform.Translate(Vector3.up * JumpPower * Time.deltaTime);
        }
       
    }
}
