namespace NET_RGR.Core
{
    /// <summary>
    /// Озеро
    /// </summary>
    public class Lake
    {
        /// <summary>
        /// Название озера
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Местоположение озера
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// Бассейновый округ
        /// </summary>
        public string BasinDistrinct { get; set; }

        /// <summary>
        /// Речной бассейн
        /// </summary>
        public string RiverBasin { get; set; }

        /// <summary>
        /// Площадь в км2
        /// </summary>
        public string Square { get; set; }
    }
}
