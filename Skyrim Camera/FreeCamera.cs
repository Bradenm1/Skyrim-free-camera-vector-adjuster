using System;

namespace Skyrim
{
    class FreeCamera
    {
        public const Int64 FREECAMERA = 0x01739A18; // Base pointer
        public const Int32 XPOS = 0x18;             // Offset 18
        public const Int32 YPOS = 0x1C;             // Offset 1C
        public const Int32 ZPOS = 0x20;             // Offset 20
        public const Int32 PITCH = 0x24;            // Offset 24 x
        public const Int32 YAW = 0x28;              // Offset 28 z
        public const Int32 MOVEMENT = 0x34;         // Offset 34
        public const String RETURN_TYPE = "float";  // Type memory reads

        public static String getFreeCamrea() {
            return FREECAMERA.ToString("x");
        }

        public static String getXPos() {
            return getFreeCamrea() + "," + XPOS.ToString("x");
        }

        public static String getYPos() {
            return getFreeCamrea() + "," + YPOS.ToString("x");
        }

        public static String getZPos() {
            return getFreeCamrea() + "," + ZPOS.ToString("x");
        }

        public static String getPitch() {
            return getFreeCamrea() + "," + PITCH.ToString("x");
        }

        public static String getYaw()
        {
            return getFreeCamrea() + "," + YAW.ToString("x");
        }
    }
}
