using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTest : MonoBehaviour
{
    // interatable ������Ʈ�� ��ġ�� ����
    public void OnHoverEntered() => print(gameObject.name + " - OnHoverEntered");
    // interatable ������Ʈ�� �и��Ǵ� ����
    public void OnHoverExited() => print(gameObject.name + " - OnHoverExited");
    // Hover ���¿��� interatable ������Ʈ�� ��� ����
    public void OnSelectEntered() => print(gameObject.name + " - OnSelectEntered");
    // Hover ���¿��� interatable ������Ʈ�� ���� ����
    public void OnSelectExited() => print(gameObject.name + " - OnSelectExited");
    // Select���¿��� Ʈ���� ��ư�� ������ ����
    public void OnActivated() => print(gameObject.name + " - OnActivated");
    // Select���¿��� Ʈ���� ��ư�� ���� ����
    public void OnDeactivated() => print(gameObject.name + " - OnDeactivated");
}
