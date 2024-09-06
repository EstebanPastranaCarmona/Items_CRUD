using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articles_CRUD.Entities
{
    /// <summary>
    /// A utility class with methods to validate
    /// </summary>
    public static class ValidationHelper
    {
        /// <summary>
        /// Checks if the provided string value is null or with only white spaces.
        /// </summary>
        /// <param name="value">The string value to check.</param>
        /// <param name="parameterName">The name of the parameter for exception message.</param>
        /// <exception cref="ArgumentNullException">Thrown when the string value is null or only with withe spaces.</exception>
        public static void ValidateIfValueIsNullOrEmpty(string value, string parameterName)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException(parameterName, "The field cannot be empty.");
            }
        }
    }
}
