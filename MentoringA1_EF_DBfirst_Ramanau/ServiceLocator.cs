using MentoringA1_EF_DBfirst_Ramanau.Interfaces;
using Unity;

namespace MentoringA1_EF_DBfirst_Ramanau
{
    public class ServiceLocator
    {
        private readonly IUnityContainer _unityContainer;
        public ServiceLocator()
        {
            _unityContainer = new UnityContainer();
            RegisterDepandencies();
        }

        private void RegisterDepandencies()
        {
            _unityContainer.RegisterType<IOrderRepository, OrderRepository>();
        }

        public T Resolve<T>()
        {
            return _unityContainer.Resolve<T>();
        }
    }
}
