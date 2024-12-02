using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pictures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            int picturesInAlbum = 52;
            int picturesInRow = 3;
            int rowsCount = picturesInAlbum / picturesInRow;
            int extraPicturesCount = picturesInAlbum % picturesInRow;

            Console.WriteLine($" { rowsCount } рядов(а) по {picturesInRow} картинки, {extraPicturesCount} картинки(а) сверх меры ");
        }
    }
}
