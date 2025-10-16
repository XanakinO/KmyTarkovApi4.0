using BepInEx;
using KmyTarkovApi.Patches;

namespace KmyTarkovApi
{
    [BepInPlugin("com.kmyuhkyuk.KmyTarkovApi", "KmyTarkovApi", "1.4.0")]
    [BepInDependency("com.kmyuhkyuk.KmyTarkovReflection", "1.4.0")]
    // SPT 4.0+ support
    [BepInDependency("com.SPT.core", "4.0.0")]
    public class KmyTarkovApiPlugin : BaseUnityPlugin
    {
        private void Start()
        {
            EFTVersion.WriteVersionLog();

            //Init EFTHelpers Hooks
            EFTHelpers.InitHooks();

            //Player
            new GamePlayerOwnerPatchs().Enable();

            //GameWorld
            new TriggerWithIdPatchs().Enable();
        }
    }
}
