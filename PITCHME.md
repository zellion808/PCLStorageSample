## PCLStorageSample
####【Xamarin】
PCLStorageを使ってURLから画像の取得、保存、表示をするサンプルです。

---

## 手順（備忘録）
- NuGetパッケージ管理からMicrosoft.Net.Httpをインストール（PCLのみで可）  
これでHttpClientを使い、URLから画像をDL可能になる  
- http://www.c-sharpcorner.com/article/local-file-storage-using-xamarin-form/ を参考に実装<!-- .element: class="fragment" -->  
各プラットフォーム毎ではなく、PCL部分で画像の保存、読み込みが可能<!-- .element: class="fragment" -->    
  
---

### コード
+++?code=PCLStorageTest/PCLStorageTest/MainPage.xaml.cs
---

### 参考URL

+++
http://furuya02.hatenablog.com/entry/2014/10/05/053525<!-- .element: class="fragment" -->  
http://www.c-sharpcorner.com/article/local-file-storage-using-xamarin-form/ <!-- .element: class="fragment" -->    
https://developer.xamarin.com/guides/xamarin-forms/user-interface/images/<!-- .element: class="fragment" -->  

