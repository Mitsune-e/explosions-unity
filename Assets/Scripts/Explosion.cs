using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
  public AnimatedSpriteRender start;
  public AnimatedSpriteRender middle;
  public AnimatedSpriteRender end;

  public void SetActiveRendered(AnimatedSpriteRender renderer)
  {
    start.enabled = renderer == start;
    middle.enabled = renderer == middle;
    end.enabled = renderer == end;
  }

  public void SetDirection(Vector2 direction)
  {
    //
    float angle = Mathf.Atan2(direction.y, direction.x);
    transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

  }

  public void DestroyAfter(float seconds)
  {
    Destroy(gameObject, seconds);
  }
}
