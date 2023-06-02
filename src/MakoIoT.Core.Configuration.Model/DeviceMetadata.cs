namespace MakoIoT.ConfigurationApi.Model
{
    /// <summary>
    /// Device details shown in configuration app.
    /// </summary>
    public class DeviceMetadata
    {
        /// <summary>
        /// Device name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Device manufacturer
        /// </summary>
        public string Manufacturer { get; set; }

        /// <summary>
        /// Device serial number
        /// </summary>
        public string SerialNo { get; set; }

        /// <summary>
        /// Configuration sections (note: do not include config parameters here)
        /// </summary>
        public ConfigSectionMetadata[] ConfigSections { get; set; }

        /// <summary>
        /// True, if sections without metadata should be hidden in configuration app.
        /// </summary>
        public bool HideOtherSections { get; set; }
    }
}
