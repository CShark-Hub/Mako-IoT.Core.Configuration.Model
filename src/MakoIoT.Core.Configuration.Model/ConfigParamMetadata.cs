namespace MakoIoT.ConfigurationApi.Model
{
    public class ConfigParamMetadata
    {
        /// <summary>
        /// Name of the field. Must match property name in config class.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Type of the value. Currently supported in configuration app are:
        /// string, int, bool, float, double, datetime, timezone
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Label of the field
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// True, if the field should not show on form
        /// </summary>
        public bool IsHidden { get; set; }

        /// <summary>
        /// True, if form field should be masked (like password)
        /// </summary>
        public bool IsSecret { get; set; }

        public object DefaultValue { get; set; }
    }
}
