using UnityEngine;

public class VehicleModel
{
	private const float MovementSpeed = 6;
	private const float AngularSpeed = 3;

	private InputSystem inputSystem;

	public VehicleModel(InputSystem inputSystem)
	{
		this.inputSystem = inputSystem;
	}

	public Vector3 GetMovementVelocity()
	{
		return Vector3.forward * MovementSpeed * inputSystem.GetVerticalAxis();
	}

	public Vector3 GetAngularVelocity()
	{
		return Vector3.up * AngularSpeed * inputSystem.GetHorizontalAxis();
	}
}
