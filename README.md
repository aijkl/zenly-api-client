# Zenly Widgets Client  
####  ZenlyのAPIからフレンドの位置情報を取得する  
```csharp
var zenlyApiClient = new ZenlyAPIClient(token:"s-sample-sample-sample-sample");//token
var usersLocation = await zenlyApiClient.WidgetClient.FetchUsersLocation(new []{ "u-HRwfBLo8BqdU7WSEE0P8Nch1qiBVtUlG", "u-BgUiXncsnSk0C0mib0KJXmgoU0gxmBzr", "u-t0B0P4ub1FUR2pZc2YyvxU0LiVsFuHgB", "u-Kk4C7x108d8wkYj1rFkC2gwSkkCs8d7o" });
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
