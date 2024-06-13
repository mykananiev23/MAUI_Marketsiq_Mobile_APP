using System.Reflection;

namespace MarketsIQ.Services.Google.Protobuf.Compatibility
{
    internal static class TypeExtensions
    {
        internal static bool IsAssignableFrom(this Type target, Type c)
        {
            return target.GetTypeInfo().IsAssignableFrom(c.GetTypeInfo());
        }

        internal static PropertyInfo GetProperty(this Type target, string name)
        {
            while ((object)target != null)
            {
                TypeInfo typeInfo = target.GetTypeInfo();
                PropertyInfo declaredProperty = typeInfo.GetDeclaredProperty(name);
                if ((object)declaredProperty != null && ((declaredProperty.CanRead && declaredProperty.GetMethod.IsPublic) || (declaredProperty.CanWrite && declaredProperty.SetMethod.IsPublic)))
                {
                    return declaredProperty;
                }

                target = typeInfo.BaseType;
            }

            return null;
        }

        internal static MethodInfo GetMethod(this Type target, string name)
        {
            while ((object)target != null)
            {
                TypeInfo typeInfo = target.GetTypeInfo();
                MethodInfo declaredMethod = typeInfo.GetDeclaredMethod(name);
                if ((object)declaredMethod != null && declaredMethod.IsPublic)
                {
                    return declaredMethod;
                }

                target = typeInfo.BaseType;
            }

            return null;
        }
    }
}
