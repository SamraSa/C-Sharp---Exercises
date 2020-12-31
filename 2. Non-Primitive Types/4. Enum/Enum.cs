using System;


namespace Enum
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }
    class Enum
    {
        static void Main(string[] args)
        {
            //Example 1.

            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);

            //Example 2.
            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);

            //Example 3. (converting enum to string)
            Console.WriteLine(method.ToString());

            //Example 4. (converting string to enum)
            var methodName = "Express";
            var shippingMethod = (ShippingMethod) global::Enum.Parse(typeof(ShippingMethod), methodName);
            Console.WriteLine(shippingMethod);
        }
    }
}
