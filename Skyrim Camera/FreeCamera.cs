using System;

namespace Skyrim
{
    class FreeCamera
    {
        public static Int64 FREECAMERA = 0x01739A18; // Base pointer 64-bit address
        public static Int32 XPOS = 0x18;             // Offset 18
        public static Int32 YPOS = 0x1C;             // Offset 1C
        public static Int32 ZPOS = 0x20;             // Offset 20
        public static Int32 PITCH = 0x24;            // Offset 24 x
        public static Int32 YAW = 0x28;              // Offset 28 z
        public static Int32 MOVEMENT = 0x34;         // Offset 34
        public static Int32 PLAYERCAMERA = 0x01B399A0; // info related to some camera different types
        public static Int32 LOCKCAMERA = 0x01B399C4; // When user opens map this changes to 0, when not in map it's 1.
        public static String RETURN_TYPE = "float";  // Type memory reads, float is pretty common

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

        public static String getYaw() {
            return getFreeCamrea() + "," + YAW.ToString("x");
        }

        public static Int32 getLockCamera() {
            return LOCKCAMERA;
        }
    }
}
