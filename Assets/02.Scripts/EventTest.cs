using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTest : MonoBehaviour
{
    // interatable 오브젝트와 겹치는 순간
    public void OnHoverEntered() => print(gameObject.name + " - OnHoverEntered");
    // interatable 오브젝트와 분리되는 순간
    public void OnHoverExited() => print(gameObject.name + " - OnHoverExited");
    // Hover 상태에서 interatable 오브젝트를 잡는 순간
    public void OnSelectEntered() => print(gameObject.name + " - OnSelectEntered");
    // Hover 상태에서 interatable 오브젝트를 놓는 순간
    public void OnSelectExited() => print(gameObject.name + " - OnSelectExited");
    // Select상태에서 트리거 버튼을 누르는 순간
    public void OnActivated() => print(gameObject.name + " - OnActivated");
    // Select상태에서 트리거 버튼을 떼는 순간
    public void OnDeactivated() => print(gameObject.name + " - OnDeactivated");
}
