namespace AssaultCubeTrainer
{
    internal static class PointersAddr
    {
        private const string localEntityAddr = "base+10F4F4";
        public static string HealthAddr = $"{localEntityAddr},F8";
        public static string ARiflePrimaryAmmoAddr = $"{localEntityAddr},150";
        public static string ARifleSecondaryAmmoAddr = $"{localEntityAddr},128";
        public static string KevlarArmorAddr = $"{localEntityAddr},FC";
        public static string PistolPrimaryAmmoAdr = $"{localEntityAddr},13c";
        public static string PistolSecondaryAmmoAdr = $"{localEntityAddr},114";
        public static string LocalPlayerXPosAddr = $"{localEntityAddr},04";
        public static string LocalPlayerYPosAddr = $"{localEntityAddr},08";
        public static string LocalPlayerZPosAddr = $"{localEntityAddr},0c";
    }
}
