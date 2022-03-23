using UnityEngine;

public class ChangeCharacterSptites : MonoBehaviour
{
    private BoxCollider2D collider2D;
    private SpriteRenderer spriteRenderer;

    public Sprite lookUp;
    public Sprite lookDown;
    public Sprite lookRight;
    public Sprite lookLeft;

    private void Start()
    {
        collider2D = GetComponent<BoxCollider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void LookToDirection(Vector2 dir)
    {
        if (dir == new Vector2(0, 2)) spriteRenderer.sprite = lookUp;
        if (dir == new Vector2(0, -2)) spriteRenderer.sprite = lookDown;
        if (dir == new Vector2(2, 0)) spriteRenderer.sprite = lookRight;
        if (dir == new Vector2(-2, 0)) spriteRenderer.sprite = lookLeft;

        if (dir == new Vector2(0, 2) || dir == new Vector2(0, -2)) collider2D.size = new Vector2(3, 5.5f);
        else collider2D.size = new Vector2(7, 3.5f);
    }
}
