using UnityEngine;

public class MobileInput : MonoBehaviour
{
    private CharacterMovement movement;

    Vector2 firstPressPos;
    Vector2 secondPressPos;
    Vector2 currentSwipe;
   
    void Start()
    {
        movement = GetComponent<CharacterMovement>();
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch t = Input.GetTouch(0);

            if (t.phase == TouchPhase.Began)
            {
                firstPressPos = new Vector2(t.position.x, t.position.y);
            }

            if (t.phase == TouchPhase.Ended)
            {
                secondPressPos = new Vector2(t.position.x, t.position.y);

                currentSwipe = new Vector3(secondPressPos.x - firstPressPos.x, secondPressPos.y - firstPressPos.y);
                currentSwipe.Normalize();

                Vector2 newDir = new Vector2();

                if (currentSwipe.y > 0 && currentSwipe.x > -0.5f && currentSwipe.x < 0.5f) newDir = new Vector2(0, 2);
                if (currentSwipe.y < 0 && currentSwipe.x > -0.5f && currentSwipe.x < 0.5f) newDir = new Vector2(0, -2);
                if (currentSwipe.x < 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f) newDir = new Vector2(-2, 0);
                if (currentSwipe.x > 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f) newDir = new Vector2(2, 0);

                if (movement.lastDirection != newDir) movement.ChangeDirection(newDir);
            }
        }
    }
}
