using UnityEngine;
using Zenject;

public class VehicleView : MonoBehaviour
{
	private VehicleModelView vehicleModelView;
	private Rigidbody rigidbody;
	private Transform tBody;

	[Inject]
	public void Construct(VehicleModelView vehicleModelView)
	{
		this.vehicleModelView = vehicleModelView;
	}

	private void Start()
	{
		rigidbody = GetComponent<Rigidbody>();
		tBody = transform;

		vehicleModelView.SubscribeToVelocityChange(SetVelocity);
		vehicleModelView.SubscribeToAngularVelocityChange(SetAngularVelocity);
	}

	private void SetVelocity(Vector3 velocity)
	{
		rigidbody.velocity = tBody.TransformDirection(velocity);
	}

	private void SetAngularVelocity(Vector3 angularVelocity)
	{
		rigidbody.angularVelocity = angularVelocity;
	}
}
