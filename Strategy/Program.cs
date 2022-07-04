using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            //var imageStorage = new ImageStorage(
            //    new JpegCompressor(), 
            //    new BlackAndWhiteFilter());

            //imageStorage.Store("A");

            //var imageStorage2 = new ImageStorage(
            //    new PngCompressor(),
            //    new HighContrastFilter());

            //imageStorage2.Store("b");

            // SIMPLIFIED MORE FLEXBILE WAY
            var imageStorage = new ImageStorage();
            imageStorage.Store("A", new JpegCompressor(), new BlackAndWhiteFilter());
            imageStorage.Store("B", new PngCompressor(), new HighContrastFilter());
        }
    }
}
