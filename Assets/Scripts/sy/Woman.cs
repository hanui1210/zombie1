using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Woman : MonoBehaviour
{
 // 캐릭터 이동
 // 쿼터니엄 
    void Start()
    {
     //  this.transform.rotation = Quaternion.AngleAxis(45,Vector3.up);    

    }

    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        var dir = new Vector3(h, 0, v).normalized;
        DrawArrow.ForDebug(this.transform.position, dir, 0, Color.red, ArrowType.Solid);
        if (dir != Vector3.zero)
        {
            var angle = Mathf.Atan2(dir.x, dir.z) * Mathf.Rad2Deg;
            this.transform.rotation = Quaternion.AngleAxis(angle, Vector3.up);
        }

    //    if(Input.GetKeyDown)

    }
}
