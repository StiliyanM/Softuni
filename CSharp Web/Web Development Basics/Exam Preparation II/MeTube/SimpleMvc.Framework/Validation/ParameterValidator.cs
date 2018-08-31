using System.Collections.Generic;
using System.Linq;

namespace SimpleMvc.Framework.Validation
{
    public class ParameterValidator
    {
        private Dictionary<string, IList<string>> modelErrors;

        public ParameterValidator()
        {
            this.modelErrors = new Dictionary<string, IList<string>>();
        }

        public IReadOnlyDictionary<string, IList<string>> ModelErrors => this.modelErrors;

        public string FirstErrorMessage => this.modelErrors.First().Value.First();

        public void AddModelError(string paramName, string message)
        {
            if (!this.modelErrors.ContainsKey(paramName))
            {
                this.modelErrors[paramName] = new List<string>();
            }

            this.modelErrors[paramName].Add(message);
        }
    }
}
