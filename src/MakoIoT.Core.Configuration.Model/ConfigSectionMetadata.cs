namespace MakoIoT.ConfigurationApi.Model
{
    public class ConfigSectionMetadata
    {
        /// <summary>
        /// Section name. Must match SectionName in the config class.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Section label.
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// True, if section should be hidden on the form.
        /// </summary>
        public bool IsHidden { get; set; }

        /// <summary>
        /// List of section's parameters.
        /// </summary>
        public ConfigParamMetadata[] Parameters { get; set; }
    }
}
