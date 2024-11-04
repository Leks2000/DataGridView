using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Library.Contracts.Models
{
    /// <summary>
    /// Выбор гендарного пола
    /// </summary>
    public enum Gender
    {
        /// <summary>
        /// Мужской
        /// </summary>
        [Description("Мужской")]
        Male = 1,

        /// <summary>
        /// Женский
        /// </summary>
		[Description("Женский")]
        Female = 2,
    }
}
