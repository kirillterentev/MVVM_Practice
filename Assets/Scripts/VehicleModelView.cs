using System;
using UnityEngine;
using Zenject;

public class VehicleModelView : ITickable
{
	private VehicleModel vehicleModel;
	private Action<Vector3> onVelocityChange;
	private Action<Vector3> onAngularVelocityChange;

	public VehicleModelView(VehicleModel vehicleModel)
	{
		this.vehicleModel = vehicleModel;
	}

	public void SubscribeToVelocityChange(Action<Vector3> action)
	{
		onVelocityChange += action;
	}

	public void SubscribeToAngularVelocityChange(Action<Vector3> action)
	{
		onAngularVelocityChange += action;
	}

	public void Tick()
	{
		onVelocityChange.Invoke(vehicleModel.GetMovementVelocity());
		onAngularVelocityChange.Invoke(vehicleModel.GetAngularVelocity());
	}
}
