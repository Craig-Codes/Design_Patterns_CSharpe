using System;

public class ImageStorage
{
    //private ICompressor compressor;
    //private IFilter filter;

    // Use the constructor to pass in the compression and filter type required
    //public ImageStorage(ICompressor compressor, IFilter filter)
    //{
    //    this.compressor = compressor;
    //    this.filter = filter;
    //}

    // Can use any concreate implementation of a filter or Storage object
    
    // IF we pass the compressor and filter into the Store method, image storage is even more flexible than using a constructor as commented out
    public void Store(string fileName, ICompressor compressor, IFilter filter)
    {
        compressor.Compress(fileName);
        filter.apply(fileName);
    }

}