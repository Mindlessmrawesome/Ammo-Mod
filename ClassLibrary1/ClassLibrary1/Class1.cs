using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Harmony;

namespace AmmoMod
{


    class QPatch
    {
        public static void Main()
        {
            var harmony = HarmonyInstance.Create("mindless.ttmm.ammo.mod");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }
    }

    public class Class1
    {

    }
}
