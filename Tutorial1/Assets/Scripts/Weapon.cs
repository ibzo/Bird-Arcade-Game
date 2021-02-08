using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public float MaxDistance = 3f;
    bool isMouseDown;
    Vector3 initialPosition;
    SpringJoint2D springJoint;
    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
        springJoint = GetComponent<SpringJoint2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isMouseDown)
        {
            var mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            var newPosition = new Vector3(mouseWorldPosition.x, mouseWorldPosition.y, 0);

            var distance = Vector2.Distance(newPosition, initialPosition);

            if(distance < MaxDistance)
            {
                transform.position = newPosition;
            }
            else
            {
                var direction = (newPosition - initialPosition).normalized;
                transform.position = initialPosition + direction * MaxDistance;
            }
        }
        
    }

    private void OnMouseDown()
    {
        isMouseDown = true;
    }

    private void OnMouseUp()
    {
        isMouseDown = false;
        StartCoroutine(LaunchProjectile());
    }

    IEnumerator LaunchProjectile()
    {
        yield return new WaitForSeconds(0.05f);
        springJoint.enabled = false;
    }

    public void ResetPosition()
    {
        transform.position = initialPosition;
        springJoint.enabled = true;
    }
}
