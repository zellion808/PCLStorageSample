## PCLStorageSample
####【Xamarin】
PCLStorageを使ってURLから画像の取得、保存、表示をするサンプルです。

---

## 手順（備忘録）
- NuGetパッケージ管理からMicrosoft.Net.Httpをインストール（PCLのみで可）  
これでHttpClientを使い、URLから画像をDL可能になる
- を参考に実装 
各プラットフォーム毎ではなく、PCL部分で画像の保存、読み込みが可能 |
  
---

### コード
+++?code=PCLStorageTest/PCLStorageTest/MainPage.xaml.cs
---

### 参考URL

+++
http://furuya02.hatenablog.com/entry/2014/10/05/053525  
http://www.c-sharpcorner.com/article/local-file-storage-using-xamarin-form/  
https://developer.xamarin.com/guides/xamarin-forms/user-interface/images/

