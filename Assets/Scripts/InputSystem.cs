using UnityEngine;

public class InputSystem
{
	public float GetVerticalAxis()
	{
		return Input.GetAxis("Vertical");
	}

	public float GetHorizontalAxis()
	{
		return Input.GetAxis("Horizontal");
	}
}
