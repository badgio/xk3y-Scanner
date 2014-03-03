﻿namespace XkeyBrew.Utils.IsoGameReader
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct IsoInfo
    {
        public byte[] Identifier;
        public uint RootDirSector;
        public uint RootDirSize;
        public byte[] ImageCreationTime;
        public uint SectorSize;
        public uint RootOffset;
        public ulong VolumeSize;
        public uint VolumeSectors;
    }
}
