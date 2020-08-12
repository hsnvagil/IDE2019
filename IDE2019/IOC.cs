using Autofac;

namespace IDE2019 {
    public static class IOC {
        private static IContainer _container;
        private static readonly ContainerBuilder Builder;

        static IOC() {
            Builder = new ContainerBuilder();
        }

        public static void Register<TImplementation, TInterface>() {
            Builder.RegisterType<TImplementation>().As<TInterface>();
        }

        public static void Register<TImplementation>() {
            Builder.RegisterType<TImplementation>();
        }

        public static void Build() {
            _container = Builder.Build();
        }

        public static T Resolve<T>() {
            return _container.Resolve<T>();
        }
    }
}
