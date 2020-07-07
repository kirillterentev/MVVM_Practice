using UnityEngine;
using Zenject;

public class VehicleMonoInstaller : MonoInstaller
{
	[SerializeField]
	private VehicleView vehicle;

	public override void InstallBindings()
	{
		Container.Bind<InputSystem>().AsSingle().NonLazy();
		Container.Bind<VehicleModel>().AsSingle().NonLazy();
		Container.BindInterfacesAndSelfTo<VehicleModelView>().AsSingle().NonLazy();
		Container.Bind<VehicleView>().FromComponentInNewPrefab(vehicle).AsSingle().NonLazy();
	}
}
