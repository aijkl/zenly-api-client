# Zenly Widgets Client  
####  ZenlyのAPIからフレンドの位置情報を取得する  
```csharp
var zenlyApiClient = new ZenlyAPIClient(token:"s-sample-sample-sample-sample");//token
var userLocation = await zenlyApiClient.WidgetClient.FetchUserLocation("u-HRwfBLo8BqdU7WSEE0P8Nch1qiBVtUlG");
Console.WriteLine(userLocation.Latitude);//緯度
Console.WriteLine(userLocation.Longitude);//経度
```


# 注意  
```FetchUsersLocation```は3人以上の位置情報を取得できます  
ですが恐らくサーバーのバグです、iOS Widgetsからは3人までしか表示できません

<img width="325" src="https://user-images.githubusercontent.com/51302983/158004484-74b76bda-97ac-491c-8c7a-e0ea6ae6a96e.jpg">

### パケットキャプチャー  
https://www.telerik.com/forums/https-on-ios15  
↑を使用してiOSのWidlgetsをパケットキャプチャする  
![スクリーンショット 2022-03-10 235243](https://user-images.githubusercontent.com/51302983/157687708-82a39d3d-06c6-4453-a046-22df0ef2ca9a.jpg)  

活用プロジェクト  
https://github.com/aijkl/zenly-analytics
