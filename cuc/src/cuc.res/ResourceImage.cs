namespace cuc.res
{
    using System;
    using System.Windows.Media.Imaging;

    /// <summary>
    /// 从cuc.res获取内置图片文件
    /// </summary>
    public static class ResourceImage
    {
        #region public methods
        /// <summary>
        /// 获取内置图片路径
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static BitmapImage GetIcon(string name)
        {
            //create the resource reader stream
            var stream = ResourceAssembly.GetAssembly().GetManifestResourceStream(ResourceAssembly.GetNamespace() + "Img.Icon." + name);
            var image = new BitmapImage();

            //Construct and return img
            image.BeginInit();
            image.StreamSource = stream;
            //image.UriSource = new Uri("D:/VisualStudio/Template/cuc/src/cuc.res/Img/Icon/14_32x.png", UriKind.Absolute);
            image.EndInit();

            //Return constructed BitImage
            return image;
        }
        #endregion
    }
}
