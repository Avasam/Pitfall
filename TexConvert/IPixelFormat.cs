﻿using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;

namespace TexConvert;

interface IPixelFormat
{
    DDSPixelFormat PixelFormat { get; }
    uint Flag { get; }
    int GetSize(int width, int height);
    uint GetPitchOrLinear(int width, int height);
    byte[] Transform(int width, int height, byte[] data);

    Image<Rgba32>? Convert(in TextureHeader header, byte[] data) => null;

    int GetSize(in TextureHeader header) => GetSize(header.Width, header.Height);
    uint GetPitchOrLinear(in TextureHeader header) => GetPitchOrLinear(header.Width, header.Height);
    byte[] Transform(in TextureHeader header, byte[] data) => Transform(header.Width, header.Height, data);
}
