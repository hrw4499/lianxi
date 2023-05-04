namespace AutofacDemo.Common
{
    public class MyFactory
    {
        public string SetFactory<T>()
        {
            return SetFactory(typeof(T));
        }

        public string SetFactory(Type type)
        {
            return type.Name;
        }
    }
}
