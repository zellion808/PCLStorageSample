using PCLStorage;
using PCLStorage.Exceptions;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PCLStorageTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// URLから画像をダウンロードし、保存する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void DownloadButton_Clicked(object sender, EventArgs e)
        {
            var httpClient = new HttpClient();
            var byteImage = await httpClient.GetByteArrayAsync("https://s.yimg.jp/images/top/office/cmn/ylogo_office-140228.png");

            await SaveImage(byteImage, "image.png");
        }

        /// <summary>
        /// 保存された画像を読み込み、表示する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void LoadButton_Clicked(object sender, EventArgs e)
        {
            try
            {
                IFolder folder = FileSystem.Current.LocalStorage;
                var file = await folder.GetFileAsync("image.png");
                imgDownloaded.Source = ImageSource.FromFile(file.Path);
            }
            catch (FileNotFoundException)
            {
                // 何もしない
            }
        }

        /// <summary>
        /// 画像を保存する
        /// </summary>
        /// <param name="image"></param>
        /// <param name="fileName"></param>
        /// <param name="rootFolder"></param>
        /// <returns></returns>
        public async Task SaveImage(byte[] image, String fileName, IFolder rootFolder = null)
        {
            try
            {
                IFolder folder = rootFolder ?? FileSystem.Current.LocalStorage;
                IFile file = await folder.CreateFileAsync(fileName, CreationCollisionOption.ReplaceExisting);
                using (System.IO.Stream stream = await file.OpenAsync(FileAccess.ReadAndWrite))
                {
                    stream.Write(image, 0, image.Length);
                }
            }
            catch (UnauthorizedAccessException)
            {
                // 何もしない
            }
        }
    }
}
