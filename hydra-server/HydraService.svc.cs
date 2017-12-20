using System;

namespace Hydra
{
    public class HydraService : IHydraService
    {
        public string GetData()
        {
            return string.Format("Something happened!");
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
